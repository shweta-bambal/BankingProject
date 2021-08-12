using CDBBank.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using CDBBank.Models.Repositories;

namespace CDBBank.Controllers
{
    public class DefaultController : Controller
    {
        private readonly CDBBankContext _context;
       
        private readonly IConfiguration _config;
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private string generatedToken = null;


        public DefaultController(CDBBankContext context, IConfiguration configuration, IUserRepository userRepository, ITokenService tokenService)
        {
            _config = configuration;
            _context = context;
            _userRepository = userRepository;
            _tokenService = tokenService;
        }



        //static string apiurl = "https://localhost:44395/authentication";
        //BankUser user = new BankUser();
        //HttpClient client = new HttpClient();

        public IActionResult Index()
        {
            return View();
        }

      
        public IActionResult IsCustomer()
        {
           
            if (HttpContext.Session.GetString("UserName") != null && HttpContext.Session.GetString("Password") != null)
            {
                return RedirectToAction("Dashboard", "Users");
            }
            return View();
        }

        [AllowAnonymous]
        //[Route("login")]
        [HttpPost]
        public ActionResult AuthorizeUser(BankUser userModel)
        {
            var obj =_context.BankUsers.Where(a => a.Username.Equals(userModel.Username)).FirstOrDefault();
            if (obj.Password == userModel.Password)
            {
                generatedToken = _tokenService.BuildToken(_config["Authentication:AccessTokenKey"].ToString(), _config["Authentication:Issuer"].ToString(), obj);
                if (generatedToken != null)
                {
                    HttpContext.Session.SetString("Token", generatedToken);
                    HttpContext.Session.SetInt32("UserId", obj.Id);
                    HttpContext.Session.SetString("UserName", obj.Username.ToString());
                    HttpContext.Session.SetString("Fname", obj.FirstName.ToString());

                    HttpContext.Session.SetString("Balance", obj.Balance.ToString());
                    HttpContext.Session.SetString("AccType", obj.AccountType.ToString());

                    return RedirectToAction("AuthorizationSuccess");
                }
                else
                {
                    return (RedirectToAction("Error"));
                }
            }
            else
            {
                return (RedirectToAction("Error"));
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult AuthorizationSuccess()
        {

            string token = HttpContext.Session.GetString("Token");
            if (token == null)
            {
                return (RedirectToAction("IsCustomer"));
            }
            if (!_tokenService.ValidateToken(_config["Authentication:AccessTokenKey"].ToString(), _config["Authentication:Issuer"].ToString(), token))
            {
                return (RedirectToAction("IsCustomer"));
            }

            ViewBag.token = token;
            return RedirectToAction("Dashboard", "Users");
          //  return RedirectToAction("Dashboard", "Users");
        }

        //public ActionResult Services()
        //{
        //    ViewBag.Id = HttpContext.Session.GetInt32("UserId");
        //    ViewBag.Uname = HttpContext.Session.GetString("UserName");
        //    return View();
        //}



        public IActionResult Forgot()
        {
            //if (HttpContext.Session.GetString("UserId") != null && HttpContext.Session.GetString("FirstName") != null && HttpContext.Session.GetString("Password") != null)
            //{
            //    return RedirectToAction("Edit", "BankUsers");
            //}
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Forgot(BankUser u)
        {
            var obj = await _context.BankUsers.Where(a => a.Id.Equals(u.Id)).FirstOrDefaultAsync();
            if (obj != null && obj.Id == u.Id && obj.FirstName == u.FirstName && obj.Sques == u.Sques && obj.SAns == u.SAns)
            {
                HttpContext.Session.SetInt32("UserId", obj.Id);
                ViewBag.Id = HttpContext.Session.GetInt32("UserId");
                return RedirectToAction("Edit", "BankUsers", new { id = ViewBag.Id });
            }
            else
            {
                ModelState.AddModelError("", "Credentials are not matched");
            }
            return View();
        }
    }

   
    
}
