using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using elecciones.Models;

namespace elecciones.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.listaPartidos = BD.ListarPartidos();
        return View();
    }

    public IActionResult VerDetallePartido(int idPartido)
    {
        ViewBag.Partido = BD.VerInfoPartido(idPartido);
        ViewBag.listaCandidatos = BD.ListarCandidatos(idPartido);
        return View();
    }

    public IActionResult VerDetalleCandidato(int idCandidato)
    {
        ViewBag.candidato = BD.VerInfoCandidato(idCandidato);
        return View();
    }

     public IActionResult AgregarCandidato(int idPartido)
    {
        ViewBag.IdPartido = idPartido;
        return View();
    }

    public IActionResult GuardarCandidato(Candidato can, int idPartido)
    {
        BD.AgregarCandidato(can);
        ViewBag.partido = BD.VerInfoPartido(idPartido);
        ViewBag.listaCandidatos = BD.ListarCandidatos(idPartido);
        return View("VerDetallePartido");
    }

    public IActionResult EliminarCandidato(int idCandidato, int idPartido)
    {
        BD.EliminarCandidato(idCandidato);
        ViewBag.partido = BD.VerInfoPartido(idPartido);
        ViewBag.listaCandidatos = BD.ListarCandidatos(idPartido);
        return View("VerDetallePartido");
    }

    public IActionResult Elecciones() 
    {
        return View();
    }
    public IActionResult Creditos() 
    {
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
