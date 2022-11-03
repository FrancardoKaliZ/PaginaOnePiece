using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PaginaOneiece.Models;

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
        ViewBag.ListaTemporadas = BD.ListarTemporadas();
    }
       public IActionResult TemporadasById(int IdMar)
    {
        ViewBag.ListaTemporadasById=BD.ListarTemporadasById(IdMar);  
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
