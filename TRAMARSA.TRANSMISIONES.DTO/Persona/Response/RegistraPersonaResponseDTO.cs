using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Persona.Response
{
    [DataContract]
    public class RegistraPersonaResponseDTO : ResponseBaseDTO
    {
        public RegistraPersonaResponseDTO()
        {
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public long CodigoPersona { get; set; }
    }
}
