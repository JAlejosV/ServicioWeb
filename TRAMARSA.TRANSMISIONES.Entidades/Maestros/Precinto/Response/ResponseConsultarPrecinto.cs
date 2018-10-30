using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Precinto.Response
{
    public class ResponseConsultarPrecinto : PaginacionResponseBase
    {
        public ResponseConsultarPrecinto() {

           ListaPrecinto = new List<Precinto>();
       }

        public List<Precinto> ListaPrecinto { get; set; }
    }
}
