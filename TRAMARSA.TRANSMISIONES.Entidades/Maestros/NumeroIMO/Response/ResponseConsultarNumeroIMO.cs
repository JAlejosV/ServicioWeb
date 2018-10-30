using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.NumeroIMO.Response
{
    public class ResponseConsultarNumeroIMO : PaginacionResponseBase
    {
        public ResponseConsultarNumeroIMO() {

           ListaNumeroIMO = new List<NumeroIMO>();
       }

        public List<NumeroIMO> ListaNumeroIMO { get; set; }
    }
}
