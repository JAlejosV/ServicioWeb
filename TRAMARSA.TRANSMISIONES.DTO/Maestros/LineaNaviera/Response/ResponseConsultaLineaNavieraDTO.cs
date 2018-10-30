using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.LineaNaviera.Response
{
    [DataContract]
    public class ResponseConsultaLineaNavieraDTO : ResponseBaseDTO
    {
        public ResponseConsultaLineaNavieraDTO()
        {
            this.ListaLineaNaviera = new List<LineaNavieraDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<LineaNavieraDTO> ListaLineaNaviera { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
