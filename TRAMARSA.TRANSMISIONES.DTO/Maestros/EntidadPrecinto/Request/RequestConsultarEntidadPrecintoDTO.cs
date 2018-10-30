using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.EntidadPrecinto.Request
{
    [DataContract]
    public class RequestConsultarEntidadPrecintoDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoEntidadPrecinto { get; set; }
        [DataMember(Order = 1)]
        public string CodigoEntidadPrecintoSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreEntidadPrecinto { get; set; }
    }
}
