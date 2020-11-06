using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebBD.Models
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int ValorDocIdentidad { get; set; }
        public string Email { get; set; }
        public string FechaNacimiento { get; set; }
        public long Telefono1 { get; set; }
        public long Telefono2 { get; set; }
        public int TipoDocIdentidadid { get; set; }
    }
}
