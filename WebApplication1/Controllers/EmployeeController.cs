﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger <EmployeeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Employee()
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
