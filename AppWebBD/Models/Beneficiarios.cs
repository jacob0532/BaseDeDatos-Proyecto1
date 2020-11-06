using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebBD.Models
{
    public class Beneficiarios
    {
        public int Id { get; set; }
        public long NumeroCuenta { get; set; }
        public int ValorDocumentoIdentidad { get; set; }
        public int Parentezcoid { get; set; }
        public float Porcentaje { get; set; }
    }
}
