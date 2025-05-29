using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class EvaluacionController : Controller
    {
        public ActionResult Evaluacion()
        {
            return View();
        }

        public ActionResult CalcProm(int n1, int n2, int n3, int n4)
        {
            int promedio = (n1 + n2 + n3 + n4) / 4;
            string situacion;

            if (promedio >= 70)
            {
                situacion = "Aprobado";
            }
            else if (promedio >= 60)
            {
                situacion = "En recuperacion";
            }
            else 
            {
                situacion = "Reprobado";
            }
            ViewBag.Mensaje = $"El promedio es {promedio}. Su situacion es {situacion}";
            return View("CalcProm");
        }
    }
}
