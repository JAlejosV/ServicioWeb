using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoBL.Response
{
    public class ResponseConsultarTipoBL : PaginacionResponseBase
    {
       public ResponseConsultarTipoBL() {

           ListaTipoBL = new List<TipoBL>();
       }
    
        public List<TipoBL> ListaTipoBL { get; set; }
    }
}
