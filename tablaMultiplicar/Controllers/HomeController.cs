using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tablaMultiplicar.Models;

namespace tablaMultiplicar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int numero)
        {

            var lista = new List<Tabla>();

            for(int indice = 1; indice < 11; indice++)
            {
                lista.Add(new Tabla { factor = numero, indice = indice, resultado = indice * numero });
                
            }
           
            return View(lista);
        }





        public IActionResult Privacy()
        {
            return View();
        }

   






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
