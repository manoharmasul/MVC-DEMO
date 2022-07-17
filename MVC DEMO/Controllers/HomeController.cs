using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_DEMO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MVC_DEMO.Models;

namespace MVC_DEMO.Controllers
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
            ViewData["Message"] = "This Is My First MVC Application";
            string[] names = { "Manohar", "Mansi", "Smith", "Linna" };
            int[] nums = { 10, 20, 30, 40 };
            ViewData["namelist"] = names;

            List<Employee> emplist = new List<Employee>
            {
                new Employee{Id=1,Name="Manohar",Department="IT",Salary=50000.00},
                new Employee{Id=2,Name="Mansi",Department="Med",Salary=30000.00},
                new Employee{Id=3,Name="Smith",Department="Testing",Salary=40000.00},
                new Employee{Id=4,Name="Scott",Department="Admin",Salary=60000.00}

            };
            ViewData["emplist"] = emplist;

            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
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
