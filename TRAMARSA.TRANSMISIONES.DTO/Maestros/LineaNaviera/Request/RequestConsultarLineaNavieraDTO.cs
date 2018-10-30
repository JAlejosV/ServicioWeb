using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.LineaNaviera.Request
{
    [DataContract]
    public class RequestConsultarLineaNavieraDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoLineaNaviera { get; set; }
        [DataMember(Order = 1)]
        public string NombreLineaNaviera { get; set; }
        [DataMember(Order = 2)]
        public string RucLineaNaviera { get; set; }
    }
}
