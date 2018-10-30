using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Persona.Response
{
    [DataContract]
    public class ConsultaDetallePersonaResponseDTO : ResponseBaseDTO
    {
        public ConsultaDetallePersonaResponseDTO()
        {
            this.Result = new Result();
            this.ListaDetallePersona = new List<DetallePersonaDTO>();
        }

        [DataMember(Order = 0)]
        public List<DetallePersonaDTO> ListaDetallePersona { get; set; }
    }
}
