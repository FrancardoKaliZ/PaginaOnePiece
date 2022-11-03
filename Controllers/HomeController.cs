using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PaginaOnePiece.Models;

namespace PaginaOnePiece.Controllers;

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
        ViewBag.ListaMares = BD.ListarMares();
    }
       public IActionResult TemporadasById(int IdMar)
    {
        ViewBag.ListaTemporadasById=BD.ListarTemporadasById(IdMar);  
        return View();
    }
        public IActionResult Temporadas()
    {
        ViewBag.ListaTemporadas = BD.ListarTemporadas();
        return View();
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
