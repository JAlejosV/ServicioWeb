using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.EntidadPrecinto.Response
{
    [DataContract]
    public class ResponseConsultaEntidadPrecintoDTO : ResponseBaseDTO
    {
        public ResponseConsultaEntidadPrecintoDTO()
        {
            this.ListaEntidadPrecinto = new List<EntidadPrecintoDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<EntidadPrecintoDTO> ListaEntidadPrecinto { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
