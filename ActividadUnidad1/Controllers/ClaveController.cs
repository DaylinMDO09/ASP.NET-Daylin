using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace ActividadUnidad1.Controllers
{
    public class ClaveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Segura(string pass)
        {
            bool seguro = pass.Length >= 8 && 
                Regex.IsMatch(pass, @"[A-Z]") &&
                Regex.IsMatch(pass, @"\d");

            ViewBag.Pass = pass;
            ViewBag.Seguro = seguro;
            return View();
        }
    }
}
