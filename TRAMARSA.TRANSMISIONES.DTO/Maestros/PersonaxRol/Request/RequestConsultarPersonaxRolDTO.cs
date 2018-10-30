using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.PersonaxRol.Request
{
    [DataContract]
    public class RequestConsultarPersonaxRolDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoPersona { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoRol { get; set; }
        [DataMember(Order = 2)]
        public string RazonSocialPersona { get; set; }
        [DataMember(Order = 3)]
        public string NumeroDocumentoPersona { get; set; }
    }
}
