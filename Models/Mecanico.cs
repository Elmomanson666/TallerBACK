using System;
using System.Collections.Generic;

namespace Taller_de_Mecanica.Models
{
    public partial class Mecanico
    {
        public int IdMecanico { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Telefono { get; set; }
        public string? Cedula { get; set; }
    }
}
