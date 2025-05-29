using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroPerfectoController : Controller
    {
        public ActionResult NumPerfecto()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Confirmar(int num)
        {
            bool nump = perfecto(num);
            string mensaje = nump
                ? $"El numero {num} es perfecto"
                : $"el numero {num} no es perfecto";
            ViewBag.Mensaje=mensaje ;
            return View();
        }

        private bool perfecto(int num)
        {
            if (num <= 0) return false; 
             int suma = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    suma += i;
                }
            }
            return suma == num;
        }
    }
}
