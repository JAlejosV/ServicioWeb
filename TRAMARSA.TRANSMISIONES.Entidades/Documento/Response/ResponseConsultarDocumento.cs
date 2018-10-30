using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Documento.Response
{
    public class ResponseConsultarDocumento : PaginacionResponseBase
    {
        public ResponseConsultarDocumento()
        {
            ListaDocumento = new List<Documento>();
        }
        public List<Documento> ListaDocumento { get; set; }
    }
}
