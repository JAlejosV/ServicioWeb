using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.ViaTransporte.Request
{
    [DataContract]
    public class RequestConsultarViaTransporteDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoViaTransporte { get; set; }
        [DataMember(Order = 1)]
        public Byte? CodigoViaTransporteSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreViaTransporte { get; set; }
    }
}
