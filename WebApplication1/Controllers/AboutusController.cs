using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class AboutusController : Controller
    {
        private readonly ILogger<AboutusController> _logger;

        public AboutusController(ILogger<AboutusController> logger)
        {
            _logger = logger;
        }
        public IActionResult Aboutus()
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
