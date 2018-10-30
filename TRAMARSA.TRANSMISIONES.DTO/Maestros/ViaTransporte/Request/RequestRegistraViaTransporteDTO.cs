using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.ViaTransporte.Request
{
    [DataContract]
    public class RequestRegistraViaTransporteDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoViaTransporte { get; set; }
        [DataMember(Order = 1)]
        public Byte? CodigoViaTransporteSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreViaTransporte { get; set; }
        [DataMember(Order = 3)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 4)]
        public string Accion { get; set; }
    }
}
