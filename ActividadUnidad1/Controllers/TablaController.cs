using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class TablaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Multiplicar (int? num)
        {
            if (!num.HasValue)
            {
                ViewBag.Mensaje = "Ingresa un numero para ver la multiplicacion";
                return View();
            }
            ViewBag.Num = num.Value;
            int[] tabla = new int[10];
            for (int i = 1; i < 10; i++)
            {
                tabla[i] = num.Value * (i + 1);
            }
            ViewBag.Tabla = tabla;
            return View();
        }
    }
}
