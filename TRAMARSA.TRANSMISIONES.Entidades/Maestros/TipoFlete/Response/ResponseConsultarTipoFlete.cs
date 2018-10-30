using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoFlete.Response
{
    public class ResponseConsultarTipoFlete : PaginacionResponseBase
    {
       public ResponseConsultarTipoFlete() {

           ListaTipoFlete = new List<TipoFlete>();
       }
    
        public List<TipoFlete> ListaTipoFlete { get; set; }
    }
}
