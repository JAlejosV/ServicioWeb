using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Itinerario.Response
{
    [DataContract]
    public class ResponseConsultaItinerarioDTO : ResponseBaseDTO
    {
        public ResponseConsultaItinerarioDTO()
        {
            this.ListaItinerario = new List<ItinerarioDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<ItinerarioDTO> ListaItinerario { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
