using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroController : Controller
    {
        public ActionResult NumPrimo()
        {
            return View();
        }

        public ActionResult Confirmar(int num)
        {
            bool primo = esprimo(num);
            string mensaje = primo
                ? $"El numero {num} es primo."
                : $"El numero {num} no es primo";

            ViewBag.Mensaje = mensaje;
            return View("Confirmar");
        }

        private bool esprimo(int nump)
        {
            if (nump <= 1) return false;
            if (nump == 2) return true;

            for (int i = 2; i * i <= nump; i++)
            {
                if (nump % i == 0) return false;
            }
            return true;
        }
    }
}
