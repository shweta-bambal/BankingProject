﻿using CDBBank.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDBBank.Controllers
{
    public class DefaultController : Controller
    {
        private readonly CDBBankContext _context;

        public DefaultController(CDBBankContext context)
        {
            _context = context;
        }
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

        [HttpPost]
        public async Task<IActionResult> IsCustomer(BankUser u)
        {
            var obj = await _context.BankUsers.Where(a => a.Username.Equals(u.Username)).FirstOrDefaultAsync();
            if (obj != null && obj.Username == u.Username && obj.Password == u.Password)
            {
                HttpContext.Session.SetInt32("UserId", obj.Id);
                HttpContext.Session.SetString("UserName", obj.Username.ToString());
                HttpContext.Session.SetString("Fname", obj.FirstName.ToString());

                HttpContext.Session.SetString("Balance", obj.Balance.ToString());
                HttpContext.Session.SetString("AccType", obj.AccountType.ToString());

                return RedirectToAction("Dashboard", "Users");
            }
            else
            {
                ModelState.AddModelError("", "Credentials are not matched");
            }
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Id = HttpContext.Session.GetInt32("UserId");
            ViewBag.Uname = HttpContext.Session.GetString("UserName");
            return View();
        }



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
