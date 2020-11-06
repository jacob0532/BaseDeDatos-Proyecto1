using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebBD.Models
{
    public class CuentaAhorro
    {
        public int Clienteid { get; set; }
        public int TipoCuentaid { get; set; }
        public long NumeroCuenta { get; set; }
        public string FechaCreacion { get; set; }
        public long Saldo { get; set; }
    }
}
