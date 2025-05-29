using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        public ActionResult Calculadora()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calcular(int num1, int num2, string calculo)
        {
            int resultado = 0;
            string mensaje = "";

            switch (calculo)
            {
                case "suma":
                    resultado = num1 + num2;
                    mensaje = $"El resultado de {num1} + {num2} es {resultado}";
                    break;
                case "resta":
                    resultado = num1 - num2;
                    mensaje = $"El resultado de {num1} - {num2} es {resultado}";
                    break;
                case "multiplicacion":
                    resultado = num1 * num2;
                    mensaje = $"El resultado de {num1} x {num2} es {resultado}";
                    break;
                case "division":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        mensaje = $"El resultado de {num1} entre {num2} es {resultado}";
                    
                    }
                    else
                    {
                        mensaje = "no se divide entre 0";
                    }
                    break;
                default:
                    mensaje = "Calculo invalido";
                    break;
            }

            ViewBag.Mensaje = mensaje;
            return View("Calculo");
        }
    }
}
