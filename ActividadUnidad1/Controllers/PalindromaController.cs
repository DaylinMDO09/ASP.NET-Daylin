using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class PalindromaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Palabra(string palabra)
        {
            if (string.IsNullOrEmpty(palabra))
            {
                ViewBag.Mensaje = "Por favor, ingresa una palabra";
            }
            else
            {
                string palin = new string(palabra.ToLower().ToCharArray().Reverse().ToArray());
                bool palindroma = palabra.ToLower() == palin;

                ViewBag.Palabra = palabra;
                ViewBag.Palindroma = palindroma ? "Si, esta es una palabra palindroma" : "No, esta no es una palabra palindroma";
            }
                return View();
        }
    }
}
