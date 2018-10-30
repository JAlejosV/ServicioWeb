using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Persona.Request
{
    [DataContract]
    public class RegistraPersonaRequestDTO
    {
        public RegistraPersonaRequestDTO()
        {
            this.ListaPersonaRol = new List<PersonaRolDTO>();    
        }
        [DataMember(Order = 0)]
        public Int64? CodigoPersona { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoTipoDocumento { get; set; }
        [DataMember(Order = 2)]
        public Int64? CodigoPais { get; set; }
        [DataMember(Order = 3)]
        public string RazonSocialPersona { get; set; }
        [DataMember(Order = 4)]
        public string NumeroDocumentoPersona { get; set; }
        [DataMember(Order = 5)]
        public string DireccionPersona { get; set; }
        [DataMember(Order = 6)]
        public string TelefonoPersona { get; set; }
        [DataMember(Order = 7)]
        public string EmailPersona { get; set; }
        [DataMember(Order = 8)]
        public string ContactoPersona { get; set; }
        [DataMember(Order = 9)]
        public string WebPersona { get; set; }
        [DataMember(Order = 10)]
        public bool EstadoRegistro { get; set; }
        [DataMember(Order = 11)]
        public string UsuarioCreacion { get; set; }
        [DataMember(Order = 12)]
        public DateTime? FechaHoraCreacion { get; set; }
        [DataMember(Order = 13)]
        public string UsuarioActualizacion { get; set; }
        [DataMember(Order = 14)]
        public DateTime? FechaHoraActualizacion { get; set; }
        [DataMember(Order = 15)]
        public string Accion { get; set; }
        [DataMember(Order = 16)]
        public List<PersonaRolDTO> ListaPersonaRol { get; set; }
    }
}
