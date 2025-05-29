using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Sumar(int num1, int num2)
        {
            return View(num1 + num2);
        }

        public IActionResult Restar(int num1, int num2)
        {
            return View(num1 - num2);
        }

        public IActionResult Multiplicar(int num1, int num2)
        {
            return View(num1 * num2);
        }

        public IActionResult Dividir(int num1, int num2)
        {
            return View(num1 / num2);    
        }
    }
}
