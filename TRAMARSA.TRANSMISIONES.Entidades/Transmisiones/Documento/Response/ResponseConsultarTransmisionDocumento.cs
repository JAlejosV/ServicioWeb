using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Documento.Response
{
    public class ResponseConsultarTransmisionDocumento : PaginacionResponseBase
    {
        public ResponseConsultarTransmisionDocumento()
        {
            ListaTransmisionDocumento = new List<TransmisionDocumento>();
        }

        public List<TransmisionDocumento> ListaTransmisionDocumento { get; set; }
    }
}
