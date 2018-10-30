using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.PersonaxRol
{
    [DataContract]
    public class PersonaxRolDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoPersona { get; set; }
        [DataMember(Order = 1)]
        public string RazonSocialPersona { get; set; }
        [DataMember(Order = 2)]
        public string NumeroDocumentoPersona { get; set; }
        [DataMember(Order = 3)]
        public string NombreTipoDocumento { get; set; }
        [DataMember(Order = 4)]
        public string NombrePais { get; set; }
    }
}
