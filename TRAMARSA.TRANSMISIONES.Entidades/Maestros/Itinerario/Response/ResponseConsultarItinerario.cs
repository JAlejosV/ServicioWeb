using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Itinerario.Response
{
    public class ResponseConsultarItinerario  : PaginacionResponseBase
    {
       public ResponseConsultarItinerario() {

           ListaItinerario = new List<Itinerario>();
       }
    
        public List<Itinerario> ListaItinerario { get; set; }
    }
}
