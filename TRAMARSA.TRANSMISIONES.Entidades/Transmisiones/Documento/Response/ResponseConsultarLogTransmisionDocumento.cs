using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Documento.Response
{
    public class ResponseConsultarLogTransmisionDocumento : PaginacionResponseBase
    {
        public ResponseConsultarLogTransmisionDocumento()
        {
            ListaLogTransmisionDocumento = new List<LogTransmisionDocumento>();
        }

        public List<LogTransmisionDocumento> ListaLogTransmisionDocumento { get; set; }
    }
}
