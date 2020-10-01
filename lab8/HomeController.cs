using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoMVC.Models;
using System.Text;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test1()
        {
            int num1 = 15;
            int num2 = 20;
            int sum = num1 + num2;
            ViewBag.num1 = num1.ToString();
            ViewBag.num2 = num2.ToString();
            ViewBag.sum = sum.ToString();
            return View();
        }
       

        [HttpGet]
        public IActionResult Test2()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Test2(string n1,string n2)
        {
            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);
            int sum = num1 + num2;
            ViewBag.sum = sum;
            return View();
        }
        [HttpPost]
        public IActionResult user_registration(string name, string uname, string email)
        {
            ViewBag.name = name;
            ViewBag.uname = uname;
            ViewBag.email = email;
            return View();
        }

        [HttpGet]
        public IActionResult user_registration()
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
    }
}
