using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CapicuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Verificar(int num)
        {
            string num1 = num.ToString();
            string num2 = new string (num1.Reverse().ToArray());

            bool capicu = num1 == num2;

            ViewBag.Numero = num1;
            ViewBag.Capicu = capicu;
            return View();
        }
    }
}
