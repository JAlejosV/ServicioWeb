using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento.Response
{
    public class ResponseConsultarLogTransmisionDocumentoDTO : ResponseBaseDTO
    {
        public ResponseConsultarLogTransmisionDocumentoDTO()
        {
            this.ListaLogTransmisionDocumento = new List<LogTransmisionDocumentoDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<LogTransmisionDocumentoDTO> ListaLogTransmisionDocumento { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
