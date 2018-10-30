using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.LineaNaviera.Response
{
    public class ResponseConsultarLineaNaviera : PaginacionResponseBase
    {
       public ResponseConsultarLineaNaviera() {

           ListaLineaNaviera = new List<LineaNaviera>();
       }
    
        public List<LineaNaviera> ListaLineaNaviera { get; set; }
    }
}
