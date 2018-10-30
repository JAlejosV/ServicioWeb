using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Maestros.PersonaxRol.Request
{
    public class RequestConsultarPersonaxRol : PaginacionBase
    {
        public Int64? CodigoPersona { get; set; }
        public Int64? CodigoRol { get; set; }
        public string RazonSocialPersona { get; set; }
        public string NumeroDocumentoPersona { get; set; }
    }
}
