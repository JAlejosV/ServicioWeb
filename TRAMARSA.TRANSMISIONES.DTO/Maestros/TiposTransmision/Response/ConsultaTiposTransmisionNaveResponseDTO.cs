using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposTransmision.Response
{
    [DataContract]
    public class ConsultaTiposTransmisionNaveResponseDTO : ResponseBaseDTO
    {
        public ConsultaTiposTransmisionNaveResponseDTO()
        {
            this.Result = new Result();
            this.ListaTiposTransmisionNave = new List<TiposTransmisionNaveDTO>();
        }

        [DataMember(Order = 0)]
        public List<TiposTransmisionNaveDTO> ListaTiposTransmisionNave { get; set; }
    }
}
