using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Persona
{
    public class PersonaRol
    {
        public Int64? CodigoPersonaRol { get; set; }
        public Int64? CodigoPersona { get; set; }
        public Int64? CodigoRol { get; set; }
        public string CodigoAduanaPersonaRol { get; set; }
        //public bool EstadoRegistro { get; set; }
        //public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }

    public class PersonaRolConsulta
    {
        public Int64? CodigoPersonaRol { get; set; }
        public Int64? CodigoPersona { get; set; }
        //public Int64? CodigoRol { get; set; }
        public long CodigoRol { get; set; }
        public string CodigoAduanaPersonaRol { get; set; }
        public string NombreRol { get; set; }
        //public bool EstadoRegistro { get; set; }
        //public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
