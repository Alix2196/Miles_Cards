using Data.Entity;

namespace Web.Models
{
    public class VehiculoViewModel
    {

        public string? MensajeVehiculo { get; set; }

        public required List<VehiculosEntity> ListVehiculos { get; set; }

    }
}
