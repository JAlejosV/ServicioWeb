using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.EntidadPrecinto.Response
{
    public class ResponseConsultarEntidadPrecinto : PaginacionResponseBase
    {
       public ResponseConsultarEntidadPrecinto() {

           ListaEntidadPrecinto = new List<EntidadPrecinto>();
       }
    
        public List<EntidadPrecinto> ListaEntidadPrecinto { get; set; }
    }
}
