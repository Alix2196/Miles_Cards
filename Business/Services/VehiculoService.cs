using Data;
using Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class VehiculoService
    {
        private readonly AppDbContext _context;

        public VehiculoService(AppDbContext context)
        {
            _context = context;
        }

        public string Vehiculos()
        {
            string respuesta = "Hola Mundo desde del services...";
            return respuesta;
        }

        public List<VehiculosEntity> ObtenerVehiculos()
        {
            var listaVehiculos = _context.VehiculosEntity.ToList();
            return listaVehiculos;
        }
    }
}
