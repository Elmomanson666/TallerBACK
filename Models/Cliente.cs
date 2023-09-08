using System;
using System.Collections.Generic;

namespace Taller_de_Mecanica.Models
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string? Nombre { get; set; }
        public string? Cedula { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
    }
}
