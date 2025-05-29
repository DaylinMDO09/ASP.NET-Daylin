using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class NumeroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ParImpar (int? num)
        {
            if(!num.HasValue)
            {
                ViewBag.Mensaje = "Ingresa un numero";
            }
            else
            {
                bool par = (num % 2 == 0);
                ViewBag.Num = num;
                ViewBag.Mensaje = par ? "Este numero es par" : "Este numero es impar";
            }
                return View();
        }
    }
}
