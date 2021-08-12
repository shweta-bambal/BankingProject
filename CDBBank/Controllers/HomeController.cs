using CDBBank.Models;
using CDBBank.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CDBBank.Controllers
{
    public class HomeController : Controller
    {
       
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Offer1()
        {
            return View();
        }

        public IActionResult Offer2()
        {
            return View();
        }

        public IActionResult Offer3()
        {
            return View();
        }

        public IActionResult RD()
        {
            return View();
        }

        public IActionResult FD()
        {
            return View();
        }

        public IActionResult SIP()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //*********************8

    }
}