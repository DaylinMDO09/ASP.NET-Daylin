using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class FraseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult contarpalabras (string frase) 
        {
            if (string.IsNullOrEmpty(frase))
            {
                ViewBag.Mensaje = "Por favor, escriba una frase";
                ViewBag.Numeropal = 0;
            }
            else
            {
                int numpal = frase.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Length;

                ViewBag.Frase = frase;
                ViewBag.Numeropal = numpal;
            }
            return View();
        }
    }
}
