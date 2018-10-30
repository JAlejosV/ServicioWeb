using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.CondicionContrato.Request
{
    [DataContract]
    public class RequestConsultarCondicionContratoDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoCondicionContrato { get; set; }
        [DataMember(Order = 1)]
        public string CodigoCondicionContratoSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreCondicionContrato { get; set; }
    }
}
