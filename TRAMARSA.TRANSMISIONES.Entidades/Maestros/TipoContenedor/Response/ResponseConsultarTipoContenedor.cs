using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoContenedor.Response
{
    public class ResponseConsultarTipoContenedor : PaginacionResponseBase
    {
       public ResponseConsultarTipoContenedor() {

           ListaTipoContenedor = new List<TipoContenedor>();
       }
    
        public List<TipoContenedor> ListaTipoContenedor { get; set; }
    }
}
