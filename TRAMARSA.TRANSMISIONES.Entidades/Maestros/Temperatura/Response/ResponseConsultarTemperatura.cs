using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Temperatura.Response
{
    public class ResponseConsultarTemperatura : PaginacionResponseBase
    {
       public ResponseConsultarTemperatura() {

           ListaTemperatura = new List<Temperatura>();
       }
    
        public List<Temperatura> ListaTemperatura { get; set; }
    }
}
