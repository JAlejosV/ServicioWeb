using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposTransmision.Response
{
    [DataContract]
    public class ConsultaTiposTransmisionDocumentoResponseDTO : ResponseBaseDTO
    {
        public ConsultaTiposTransmisionDocumentoResponseDTO()
        {
            this.Result = new Result();
            this.ListaTiposTransmisionDocumento = new List<TiposTransmisionDocumentoDTO>();
        }

        [DataMember(Order = 0)]
        public List<TiposTransmisionDocumentoDTO> ListaTiposTransmisionDocumento { get; set; }
    }
}
