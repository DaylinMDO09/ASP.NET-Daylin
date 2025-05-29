using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class PrimerEjercicioController : Controller
    {
        public IActionResult Inicio()
        {
            ViewBag.Mensaje = "Hola soy Daylin Monte De Oca, SD-2023-05115";
            return View();
        }
    }
}
