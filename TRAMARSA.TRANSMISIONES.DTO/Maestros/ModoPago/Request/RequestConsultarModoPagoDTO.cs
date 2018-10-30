using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.ModoPago.Request
{
    [DataContract]
    public class RequestConsultarModoPagoDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoModoPago { get; set; }
        [DataMember(Order = 1)]
        public string CodigoModoPagoSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreModoPago { get; set; }
    }
}
