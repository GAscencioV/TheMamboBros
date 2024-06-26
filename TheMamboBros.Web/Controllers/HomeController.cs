﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheMamboBros.Web.Models;

namespace TheMamboBros.Web.Controllers
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
	// Render the Page 
            return View();
        }

        public IActionResult Privacy()
        {
	   // Render the Privacy 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
