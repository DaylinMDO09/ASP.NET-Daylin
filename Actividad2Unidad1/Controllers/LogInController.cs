using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class LogInController : Controller
    {
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Validar(string usuario, string pass)
        {
            if (usuario == "admin" && pass == "123456")
            {
                return RedirectToAction("Bienvenida");
            }
            else 
            {
                ViewBag.Error = "Usuario incorrecto o inexistente.";
                return View("LogIn");
            }
        }

        public ActionResult Bienvenida()
        {
            return View();
        }
    }
}
