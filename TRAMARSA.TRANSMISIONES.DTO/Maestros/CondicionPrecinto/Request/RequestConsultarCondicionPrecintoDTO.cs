using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.CondicionPrecinto.Request
{
    [DataContract]
    public class RequestConsultarCondicionPrecintoDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoCondicionPrecinto { get; set; }
        [DataMember(Order = 1)]
        public string CodigoCondicionPrecintoSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreCondicionPrecinto { get; set; }
    }
}
