using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Moneda.Response
{
    public class ResponseConsultarMoneda : PaginacionResponseBase
    {
       public ResponseConsultarMoneda() {

           ListaMoneda = new List<Moneda>();
       }
    
        public List<Moneda> ListaMoneda { get; set; }
    }
}
