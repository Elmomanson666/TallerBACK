using System;
using System.Collections.Generic;

namespace Taller_de_Mecanica.Models
{
    public partial class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public int? IdCliente { get; set; }
        public int? IdMecanico { get; set; }
        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public string? Color { get; set; }
    }
}
