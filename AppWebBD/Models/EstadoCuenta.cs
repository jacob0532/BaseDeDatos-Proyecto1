﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebBD.Models
{
    public class EstadoCuenta
    {
        public int id { get; set; }
        public long NumeroCuenta { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public long SaldoInicial { get; set; }
        public long SaldoFinal { get; set; }
    }
}
