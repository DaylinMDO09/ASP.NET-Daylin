using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class AnioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bisiesto(int anio)
        {
            bool bisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);

            ViewBag.anio = anio;
            ViewBag.Bisiesto = bisiesto;
            return View();
        }
    }
}
