using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Persona
{
    [DataContract]
    public class PersonaRolDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoPersonaRol { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoPersona { get; set; }
        [DataMember(Order = 2)]
        public Int64? CodigoRol { get; set; }
        //[DataMember(Order = 3)]
        //public string NombreRol { get; set; }
        [DataMember(Order = 3)]
        public string CodigoAduanaPersonaRol { get; set; }
        //[DataMember(Order = 3)]
        //public bool EstadoRegistro { get; set; }
        //[DataMember(Order = 4)]
        //public string UsuarioRegistro { get; set; }
        [DataMember(Order = 4)]
        public string Accion { get; set; }
    }
}
