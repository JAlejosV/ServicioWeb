using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.ViaTransporte.Request
{
    public class RequestRegistroViaTransporte
    {
        public Int64? CodigoViaTransporte { get; set; }
        public Byte? CodigoViaTransporteSunat { get; set; }
        public string NombreViaTransporte { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
