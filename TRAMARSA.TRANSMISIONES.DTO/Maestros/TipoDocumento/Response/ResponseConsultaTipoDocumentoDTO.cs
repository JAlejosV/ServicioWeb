using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoDocumento.Response
{
    [DataContract]
    public class ResponseConsultaTipoDocumentoDTO : ResponseBaseDTO
    {
        public ResponseConsultaTipoDocumentoDTO()
        {
            this.ListaTipoDocumento = new List<TipoDocumentoDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<TipoDocumentoDTO> ListaTipoDocumento { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
