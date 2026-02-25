using Microsoft.AspNetCore.Mvc;

namespace AYRN24022026.Controllers
{
    public class RestarController : Controller
    {
        // Esta acción carga la página por primera vez (GET)
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Esta acción procesa la resta cuando presionas el botón (POST)
        [HttpPost]
        public IActionResult Index(double num1, double num2)
        {
            double resultado = num1 - num2;
            ViewBag.Resultado = resultado; // Pasamos el dato a la vista
            return View();
        }
    }
}
