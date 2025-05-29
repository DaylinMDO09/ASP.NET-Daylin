using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class TemperaturaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Convertir(double celsius)
        {
            double fahrenheit = (celsius * 9/5) + 32;

            ViewBag.Celsius = celsius;
            ViewBag.Fahrenheit = fahrenheit;

            return View();
        }
    }
}
