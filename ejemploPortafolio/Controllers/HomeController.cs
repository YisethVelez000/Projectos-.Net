using ejemploPortafolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace ejemploPortafolio.Controllers
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
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };

            return View(modelo);
        }
        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
            new Proyecto
            {
            Titulo="App para certificaciones Microsoft ",
            Descripcion = "Portal de entrenamiento Tecnologias Microsoft",
            Link = "https://learn.microsoft.com/es-es/certifications",
            ImagenUrl ="/img/Microsoft.jpg"
            },
            new Proyecto
            {
                Titulo = "Grupo Bancolombia",
                Descripcion = "Desarrollo App Clientes",
                Link = "https://www.bancolombia.com/personas",
                ImagenUrl = "/img/Bancolombia.jpg"

            },
            new Proyecto
            {
                Titulo ="Desarrollo App Virtual Exito",
                Descripcion ="Desarrollo App Compras Online Angular",
                Link ="https://www.exito.com/",
                ImagenUrl ="/img/Exito.png"
            },
            new Proyecto
            {
                Titulo = "Desarrollo App Simulador de Prestamos",
                Descripcion = "Desarrolo App de prestamos",
                Link ="https://www.bancoldex.com/",
                ImagenUrl ="/img/Bancoldex.png"
            }
        };
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
