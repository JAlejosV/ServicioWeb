using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento.Response
{
    [DataContract]
    public class ResponseConsultarTransmisionDocumentoDTO : ResponseBaseDTO
    {
        public ResponseConsultarTransmisionDocumentoDTO()
        {
            this.ListaTransmisionDocumento = new List<TransmisionDocumentoDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<TransmisionDocumentoDTO> ListaTransmisionDocumento { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
