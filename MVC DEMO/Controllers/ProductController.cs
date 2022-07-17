using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_DEMO.Models;
using Microsoft.AspNetCore.Http;

namespace MVC_DEMO.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> plist = new List<Product>()
            {
                new Product { Id=1,Name="Hp Laptop",Price=34000.00},
                new Product { Id=2,Name="Dell Laptop",Price=23000.00},
                new Product{Id=3,Name="Lenove Laptop",Price=40000.00}
            };

            ViewBag.ProductList = plist;

            return View();
        }
        [HttpGet]//by default it is httpget
       public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(IFormCollection form)
        {
            ViewBag.Id = form["pid"];
            ViewBag.Name = form["pname"];
            ViewBag.Price = form["price"];
            return View("Details");
        }
    }
}
