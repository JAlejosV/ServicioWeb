using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoFlete.Response
{
    [DataContract]
    public class ResponseConsultaTipoFleteDTO : ResponseBaseDTO
    {
        public ResponseConsultaTipoFleteDTO()
        {
            this.ListaTipoFlete = new List<TipoFleteDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<TipoFleteDTO> ListaTipoFlete { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
