using KisiselWebSitesi.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;

namespace KisiselWebSitesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }
    }
}


