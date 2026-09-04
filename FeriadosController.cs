using System.Collections.Generic;
using System.Threading.Tasks;
using FeriadosChileNet5.Models;
using FeriadosChileNet5.Services;
using Microsoft.AspNetCore.Mvc;

namespace FeriadosChileNet5.Controllers
{
    public class FeriadosController : Controller
    {
        private readonly IFeriadosService _feriadosService;

        public FeriadosController(IFeriadosService feriadosService)
        {
            _feriadosService = feriadosService;
        }

        public async Task<IActionResult> Index()
        {
            List<Feriado> feriados;

            try
            {
                feriados = await _feriadosService.ObtenerFeriadosAsync();
            }
            catch
            {
                feriados = new List<Feriado>();
                ViewBag.Error = "No fue posible obtener los feriados desde la API.";
            }

            return View(feriados);
        }
    }
}
