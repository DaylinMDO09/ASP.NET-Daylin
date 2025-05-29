using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class BienvenidoController : Controller
    {
        public ActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Saludo(string nombre)
        {
            ViewBag.Mensaje = $"Hola, {nombre}, bienvenido a ASP.NET MVC.";
            return View("Saludo");
        }
    }
}
