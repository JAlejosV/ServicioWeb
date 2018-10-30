using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoNave.Response
{
    [DataContract]
    public class ResponseConsultaTipoNaveDTO : ResponseBaseDTO
    {
        public ResponseConsultaTipoNaveDTO()
        {
            this.ListaTipoNave = new List<TipoNaveDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<TipoNaveDTO> ListaTipoNave { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
