using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using PaginaOnePiece.Models;
using Microsoft.AspNetCore.Hosting;

namespace PaginaOnePiece.Controllers;

public class HomeController : Controller
{
    private IWebHostEnvironment Environment;

    public HomeController(IWebHostEnvironment environment)
    {
        Environment = environment;
    }

    public IActionResult Index()
    {
        ViewBag.ListaMares = BD.ListarMares();
        return View();
    }
    public IActionResult MenuMares()
    {
        ViewBag.ListaMares= BD.ListarMares();
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
        foreach (PersonajeXTemporada personajextemporada in listaPersonajes)
        {
            infoxPersonaje.Add(BD.verDetallePersonaje(personajextemporada.IdPersonaje));
        }
        return Json(new { listaPersonajes, infoxPersonaje });
    }

    public PersonajeXTemporada verPersonajeInfo(int IdPersonaje)
    {
        return BD.GetPersonajeByIDNoTemp(IdPersonaje);
    }
    public IActionResult EliminarTemporada(int IdTemporada)
    {
        BD.EliminarTemporada(IdTemporada);
        return RedirectToAction("Temporadas", "Home");
    }

    public IActionResult EliminarPersonaje(int IdTemporada)
    {
        BD.EliminarPersonaje(IdTemporada);
        return View("Temporadas");
    }

    public IActionResult AgregarTemporada()
    {   
        ViewBag.ListaMares = BD.ListarMares();
        return View("AgregarTemporada");
    }
    [HttpPost]
    public IActionResult GuardarTemporada(Temporada temp, IFormFile file)
    {
        BD.AgregarTemporada(temp);
        ViewBag.ListaTemporadas = BD.ListarTemporadas();
        if(file.Length>0)
        {
            string wwwRootLocal =this.Environment.ContentRootPath + @"\wwwroot\" + file.FileName;
            using (var Stream=System.IO.File.Create(wwwRootLocal))
            {
                file.CopyToAsync(Stream);
            }
        }
        return View("Temporadas");
    }
    public IActionResult AgregarPersonaje(int IdTemporada)
    {
        ViewBag.ListaMares = BD.ListarMares();;
        ViewBag.ListaRazas =  BD.ListarRazas();
        ViewBag.ListaBandos =  BD.ListarBandos();
        ViewBag.ListaHakiA = BD.ListarHakiA();
        ViewBag.ListaHakiO = BD.ListarHakiO();
        ViewBag.ListaHakiR = BD.ListarHakiR();
        ViewBag.ListaTripulaciones = BD.ListarTripulacion();
        ViewBag.IdTemporada = IdTemporada;
        return View("AgregarPersonaje");
    }
    [HttpPost]
    public IActionResult GuardarPersonaje(Personaje personaje,PersonajeXTemporada per, IFormFile file)
    {
        int NuevoId = BD.AgregarPersonaje(personaje);
        per.IdPersonaje = NuevoId;
        BD.AgregarPersonajeInfoXtemporada(per);
        ViewBag.ListaTemporadas = BD.ListarTemporadas();
        ViewBag.listaPersonajes = BD.ListarPersonajes();
        if(file.Length>0)
        {
            string wwwRootLocal =this.Environment.ContentRootPath + @"\wwwroot\" + file.FileName;
            using (var Stream=System.IO.File.Create(wwwRootLocal))
            {
                file.CopyToAsync(Stream);
            }
        }
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
