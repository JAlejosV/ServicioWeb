using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.CondicionesContrato.Response
{
    [DataContract]
    public class ConsultaCondicionesContratoResponseDTO : ResponseBaseDTO
        {
            public ConsultaCondicionesContratoResponseDTO()
            {
                this.Result = new Result();
                this.ListaCondicionesContrato = new List<CondicionesContratoDTO>();
            }

            [DataMember(Order = 0)]
            public List<CondicionesContratoDTO> ListaCondicionesContrato { get; set; }
    }
}
