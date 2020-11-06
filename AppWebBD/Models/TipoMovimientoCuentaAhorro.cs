using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebBD.Models
{
    public class TipoMovimientoCuentaAhorro
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public int TipoOperacion { get; set; }  //Booleano 1 o 0 

    }
}
