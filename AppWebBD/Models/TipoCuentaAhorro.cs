

namespace AppWebBD.Models
{
    public class TipoCuentaAhorro
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public int  idTipoMoneda { get; set; }
        public long SaldoMinimo { get; set; }
        public long MultaSaldoMin { get; set; }
        public long CargoAnual { get; set; }
        public int NumRetirosHumano { get; set; }
        public int NumRetirosAutomatico { get; set; }
        public float ComisionHumano { get; set; }
        public float ComisionAutomatico { get; set; }
        public float Intereses { get; set; }


    }
}
