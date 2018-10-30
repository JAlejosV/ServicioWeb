using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.ModoPago.Request
{
    public class RequestRegistroModoPago
    {
        public Int64 CodigoModoPago { get; set; }
        public string CodigoModoPagoSunat { get; set; }
        public string NombreModoPago { get; set; }
        public string CodigoEquivalencia { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
