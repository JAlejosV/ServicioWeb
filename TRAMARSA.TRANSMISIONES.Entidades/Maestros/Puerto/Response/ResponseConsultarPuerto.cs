using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Puerto.Response
{
    public class ResponseConsultarPuerto : PaginacionResponseBase
    {
        public ResponseConsultarPuerto() {

           ListaPuerto = new List<Puerto>();
       }

        public List<Puerto> ListaPuerto { get; set; }
    }
}
