using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposBL.Response
{
    [DataContract]
        public class ConsultaTiposBLResponseDTO : ResponseBaseDTO
        {
            public ConsultaTiposBLResponseDTO()
            {
                this.Result = new Result();
                this.ListaTiposBL = new List<TiposBLDTO>();
            }

            [DataMember(Order = 0)]
            public List<TiposBLDTO> ListaTiposBL { get; set; }
        }
}
