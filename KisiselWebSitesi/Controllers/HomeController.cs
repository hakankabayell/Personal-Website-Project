using KisiselWebSitesi.Models;
using KisiselWebSitesi.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KisiselWebSitesi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        Context c = new Context();
        public IActionResult Index()
        {
            Context c = new Context();
            var deger = c.AnaSayfas.ToList();
            return View(deger);
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
