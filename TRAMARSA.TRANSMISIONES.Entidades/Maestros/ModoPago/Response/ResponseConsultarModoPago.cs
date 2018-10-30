using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.ModoPago.Response
{
    public class ResponseConsultarModoPago : PaginacionResponseBase
    {
       public ResponseConsultarModoPago() {

           ListaModoPago = new List<ModoPago>();
       }
    
        public List<ModoPago> ListaModoPago { get; set; }
    }
}
