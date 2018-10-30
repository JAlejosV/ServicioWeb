using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoOperacion.Response
{
    [DataContract]
    public class ResponseConsultaTipoOperacionDTO : ResponseBaseDTO
    {
        public ResponseConsultaTipoOperacionDTO()
        {
            this.ListaTipoOperacion = new List<TipoOperacionDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<TipoOperacionDTO> ListaTipoOperacion { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
