using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoEnvio.Response
{
    public class ResponseConsultarTipoEnvio : PaginacionResponseBase
    {
       public ResponseConsultarTipoEnvio() {

           ListaTipoEnvio = new List<TipoEnvio>();
       }
    
        public List<TipoEnvio> ListaTipoEnvio { get; set; }
    }
}
