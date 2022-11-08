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
        ViewBag.ListaMares = BD.ListarMares();
        return View();
    }
    public IActionResult TemporadasById(int IdMar)
    {
        ViewBag.ListaTemporadasById = BD.ListarTemporadasById(IdMar);
        return View();
    }
    public IActionResult Temporadas()
    {
        ViewBag.ListaTemporadas = BD.ListarTemporadas();
        return View();
    }

    public Temporada mostrarInfoTemporadaAjax(int IdTemporada)
    {
        return BD.verDetalleTemporada(IdTemporada);
    }
    public JsonResult verPersonajesAjax(int IdTemporada)
    {
        List<PersonajeXTemporada> listaPersonajes = BD.ListarPersonajeXtemporada(IdTemporada);
        List<Personaje> infoxPersonaje = new List<Personaje>();
        foreach(PersonajeXTemporada personajextemporada in listaPersonajes)
        {
            infoxPersonaje.Add(BD.verDetallePersonaje(personajextemporada.IdPersonaje));
        }
        return Json(new{listaPersonajes, infoxPersonaje});
    }
        public IActionResult EliminarTemporada(int IdTemporada)
    {
        BD.EliminarTemporada(IdTemporada);
        return View("Temporadas");
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
