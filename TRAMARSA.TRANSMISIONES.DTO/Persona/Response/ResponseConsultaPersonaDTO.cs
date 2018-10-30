using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Persona.Response
{
    [DataContract]
    public class ResponseConsultaPersonaDTO : ResponseBaseDTO
    {
        public ResponseConsultaPersonaDTO()
        {
            this.ListaPersona = new List<PersonaDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<PersonaDTO> ListaPersona { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
