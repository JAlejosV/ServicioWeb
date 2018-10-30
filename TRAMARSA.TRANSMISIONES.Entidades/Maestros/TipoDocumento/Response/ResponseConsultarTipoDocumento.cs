using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoDocumento.Response
{
    public class ResponseConsultarTipoDocumento : PaginacionResponseBase
    {
       public ResponseConsultarTipoDocumento() {

           ListaTipoDocumento = new List<TipoDocumento>();
       }
    
        public List<TipoDocumento> ListaTipoDocumento { get; set; }
    }
}
