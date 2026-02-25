using Microsoft.AspNetCore.Mvc;

namespace ARNY240498.AppMVC.Controllers
{
    public class sumaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // Acción para procesar la suma
        [HttpPost]
        public IActionResult Index(double num1, double num2)
        {
            double resultado = num1 + num2;
            ViewBag.Resultado = resultado;
            ViewBag.Num1 = num1;
            ViewBag.Num2 = num2;

            return View();
        }
    }
}