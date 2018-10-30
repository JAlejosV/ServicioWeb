using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.CondicionPrecinto.Response
{
    public class ResponseConsultarCondicionPrecinto : PaginacionResponseBase
    {
       public ResponseConsultarCondicionPrecinto() {

           ListaCondicionPrecinto = new List<CondicionPrecinto>();
       }
    
        public List<CondicionPrecinto> ListaCondicionPrecinto { get; set; }
    }
}
