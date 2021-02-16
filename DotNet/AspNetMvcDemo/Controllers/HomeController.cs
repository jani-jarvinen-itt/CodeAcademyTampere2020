using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetMvcDemo.Models;

namespace AspNetMvcDemo.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Sivu1()
        {
            return View();
        }

        public IActionResult Sivu2()
        {
            return View();
        }

        public IActionResult Laskin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Laskin(int luku1, int luku2)
        {
            int summa = luku1 + luku2;
            ViewBag.LaskennanTulos = summa;

            return View();
        }
    }
}
