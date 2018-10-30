using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposEnvio.Response
{
    [DataContract]
    public class ConsultaTiposEnvioResponseDTO : ResponseBaseDTO
    {
        public ConsultaTiposEnvioResponseDTO()
        {
            this.Result = new Result();
            this.ListaTiposEnvio = new List<TiposEnvioDTO>();
        }

        [DataMember(Order = 0)]
        public List<TiposEnvioDTO> ListaTiposEnvio { get; set; }
    }
}
