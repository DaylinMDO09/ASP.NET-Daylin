using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CorreoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dominio(string correo)
        {
            string dominio = correo.Contains("@") ? correo.Split('@')[1] : "Correo no valido";

            ViewBag.Correo = correo;
            ViewBag.Dominio = dominio;

            return View();
        }
    }
}
