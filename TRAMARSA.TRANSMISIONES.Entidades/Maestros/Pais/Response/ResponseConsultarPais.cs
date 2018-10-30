using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Pais.Response
{
   public class ResponseConsultarPais : PaginacionResponseBase
    {
       public ResponseConsultarPais() {

           ListaPais = new List<Pais>();
       }
    
        public List<Pais> ListaPais { get; set; }
    }
}
