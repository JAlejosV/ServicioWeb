using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.CondicionContrato.Response
{
    public class ResponseConsultarCondicionContrato : PaginacionResponseBase
    {
       public ResponseConsultarCondicionContrato() {

           ListaCondicionContrato = new List<CondicionContrato>();
       }
    
        public List<CondicionContrato> ListaCondicionContrato { get; set; }
    }
}
