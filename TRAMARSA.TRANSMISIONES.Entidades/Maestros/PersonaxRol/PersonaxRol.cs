using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Maestros.PersonaxRol
{
    public class PersonaxRol
    {
        public Int64? CodigoPersona { get; set; }
        public string RazonSocialPersona { get; set; }
        public string NumeroDocumentoPersona { get; set; }
        public string NombreTipoDocumento { get; set; }
        public string NombrePais { get; set; }
        //public string UsuarioCreacion { get; set; }
        //public DateTime? FechaHoraCreacion { get; set; }
        //public string UsuarioActualizacion { get; set; }
        //public DateTime? FechaHoraActualizacion { get; set; }
    }
}
