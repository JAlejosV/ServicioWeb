using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Documento.Response
{
    [DataContract]
    public class ConsultaDetalleDocumentoResponseDTO : ResponseBaseDTO
    {
        public ConsultaDetalleDocumentoResponseDTO()
        {
            this.Result = new Result();
            this.ListaDetalleDocumento = new List<DetalleDocumentoDTO>();
        }

        [DataMember(Order = 0)]
        public List<DetalleDocumentoDTO> ListaDetalleDocumento { get; set; }
    }
}
