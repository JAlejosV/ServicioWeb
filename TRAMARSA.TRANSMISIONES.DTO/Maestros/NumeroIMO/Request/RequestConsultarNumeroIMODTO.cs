using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.NumeroIMO.Request
{
    [DataContract]
    public class RequestConsultarNumeroIMODTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoNumeroIMO { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoClaseIMO { get; set; }
        [DataMember(Order = 2)]
        public string NumberIMO { get; set; }
        [DataMember(Order = 3)]
        public string NombreNumeroIMO { get; set; }
        [DataMember(Order = 4)]
        public Int32? PaginaNumeroIMO { get; set; }
    }
}
