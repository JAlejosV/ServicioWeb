using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Persona.Request
{
    [DataContract]
    public class ConsultaDetallePersonaRequestDTO
    {
        [DataMember(Order = 0)]
        public Int64 CodigoPersona { get; set; }
    }
}
