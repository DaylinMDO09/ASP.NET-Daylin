using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class MonedaController : Controller
    {
        public ActionResult cambiomoneda()
        {
            return View();
        }

        [HttpPost]
        public ActionResult conversion(int monto, string divisa)
        {
            int dolar = 58;
            int euro = 65;
            int libraester = 80;
            int franco = 70;
            int resultado = 0;
            string mensaje = "";

            switch (divisa)
            {
                case "dolar":
                    resultado = monto / dolar;
                    mensaje = $"RD$ {monto} equivalen a $ {resultado} dolar(es).";
                    break;
                case "euro":
                    resultado = monto / euro;
                    mensaje=$"RD$ {monto} equivalen a $ {resultado} euro(s).";
                    break;
                case "libras esterlinas":
                    resultado = monto / libraester;
                    mensaje = $"RD$ {monto} equivalen a $ {resultado} libra(s) esterlina(s).";
                    break;
                case "franco suizo":
                    resultado = monto / franco;
                    mensaje=$"RD$ {monto} equivalen a $ {resultado} franco suizo.";
                    break;
                default:
                    mensaje = "moneda no valida.";
                    break;
            }
            ViewBag.Mensaje = mensaje;
            return View("Conversion");
        }
    }
}
