using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Persona.Request
{
    public class RequestConsultarPersona : PaginacionBase
    {
        public Int64? CodigoPersona { get; set; }
        public Int64? CodigoTipoDocumento { get; set; }
        public string RazonSocialPersona { get; set; }
        public string NumeroDocumentoPersona { get; set; }
    }
}
