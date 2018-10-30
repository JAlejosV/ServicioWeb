using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.MedioTransporte.Request
{
    public class RequestRegistroMedioTransporte
    {
        public Int64 CodigoMedioTransporte { get; set; }
        public Byte CodigoMedioTransporteSunat { get; set; }
        public string NombreMedioTransporte { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
