using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Rol.Request
{
    public class RequestRegistroRol
    {
        public Int64 CodigoRol { get; set; }
        public string CodigoRolSunat { get; set; }
        public string NombreRol { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
