using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Documento.Response
{
    [DataContract]
    public class ResponseConsultaDocumentoDTO : ResponseBaseDTO
    {
        public ResponseConsultaDocumentoDTO()
        {
            this.ListaDocumento = new List<DocumentoDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<DocumentoDTO> ListaDocumento { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
