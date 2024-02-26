using Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class VehiculoController(ILogger<VehiculoController> logger, VehiculoService vehiculoService) : Controller
    {
        private readonly ILogger<VehiculoController> _logger = logger;
        private readonly VehiculoService _vehiculoService = vehiculoService;

        public IActionResult Index()
        {
            _logger.LogInformation("Inicia Controller Vista Vehiculo");
            var viewModel = new VehiculoViewModel
            {
                MensajeVehiculo = _vehiculoService.Vehiculos(),
                ListVehiculos = _vehiculoService.ObtenerVehiculos()
            };

            return View(viewModel);
        }


    }
}
