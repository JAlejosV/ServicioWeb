using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.ClaseIMO.Request
{
    [DataContract]
    public class RequestConsultarClaseIMODTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoClaseIMO { get; set; }
        [DataMember(Order = 1)]
        public string CodigoClaseIMOSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreClaseIMO { get; set; }
    }
}
