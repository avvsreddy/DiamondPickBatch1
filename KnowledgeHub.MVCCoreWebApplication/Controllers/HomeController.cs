using KnowledgeHub.MVCCoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeHub.MVCCoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
       // domain
        public IActionResult Index()
        {
            return View();
        }

        // /home/privacy
        public IActionResult Privacy()
        {
            return View();
        }
        // /home/aboutus
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            string toDay = DateTime.Now.ToString();
            ViewBag.ToDay = toDay;
            ViewData["toDay"] = toDay;
            return View();
        }
     
    }
}
