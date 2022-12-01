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
        BD.EliminarPersonajeXtemp(IdTemporada);
        BD.EliminarTemporada(IdTemporada);
        return RedirectToAction("Temporadas", "Home");
    }
     public Mar mostrarInfoMarAjax(int IdMar)
    {
        return BD.verDetalleMar(IdMar);
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
    public IActionResult GuardarTemporada(Temporada temp, IFormFile Foto)
    {
        ViewBag.ListaTemporadas = BD.ListarTemporadas();
        if(Foto.Length>0)
        {
            string wwwRootLocal =this.Environment.ContentRootPath + @"\wwwroot\" + Foto.FileName;
            using (var Stream=System.IO.File.Create(wwwRootLocal))
            {
                Foto.CopyToAsync(Stream);
                temp.Foto = Foto.FileName;
            }
        }
         BD.AgregarTemporada(temp);
        return RedirectToAction("Temporadas", "Home");
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
    public IActionResult GuardarPersonaje(Personaje personaje,PersonajeXTemporada per, IFormFile Foto)
    {
        ViewBag.ListaTemporadas = BD.ListarTemporadas();
        ViewBag.listaPersonajes = BD.ListarPersonajes();
        if(Foto.Length>0)
        {
            string wwwRootLocal =this.Environment.ContentRootPath + @"\wwwroot\" + Foto.FileName;
            using (var Stream=System.IO.File.Create(wwwRootLocal))
            {
                Foto.CopyToAsync(Stream);
                personaje.Foto = Foto.FileName;
            }
        }
        int NuevoId = BD.AgregarPersonaje(personaje);
        per.IdPersonaje = NuevoId;
        BD.AgregarPersonajeInfoXtemporada(per);
        return RedirectToAction("Temporadas", "Home");
    }

     public IActionResult EditarPersonaje(int IdPersonaje)
    {   
        ViewBag.Personaje = BD.verDetallePersonaje(IdPersonaje);
        ViewBag.PersonajeXTemp = BD.GetPersonajeByIDNoTemp(IdPersonaje);
        ViewBag.ListaMares = BD.ListarMares();;
        ViewBag.ListaRazas =  BD.ListarRazas();
        ViewBag.ListaBandos =  BD.ListarBandos();
        ViewBag.ListaHakiA = BD.ListarHakiA();
        ViewBag.ListaHakiO = BD.ListarHakiO();
        ViewBag.ListaHakiR = BD.ListarHakiR();
        ViewBag.ListaTripulaciones = BD.ListarTripulacion();
        return View("EditarPersonaje");
    }
     public IActionResult GuardarPersonajeEditado(Personaje personaje, PersonajeXTemporada per, IFormFile Foto, string FotoAnterior)
    {   
        if(Foto!=null)
        {
            string wwwRootLocal =this.Environment.ContentRootPath + @"\wwwroot\" + Foto.FileName;
            using (var Stream=System.IO.File.Create(wwwRootLocal))
            {
                Foto.CopyToAsync(Stream);
            }
            personaje.Foto = Foto.FileName;
        }
        else{
            personaje.Foto = FotoAnterior;
        }

        BD.EditarPersonaje(personaje);
        ViewBag.listaPersonajes = BD.ListarPersonajes();
        BD.EditarPersonajeXtemporada(per);
         return RedirectToAction("Temporadas", "Home");
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
