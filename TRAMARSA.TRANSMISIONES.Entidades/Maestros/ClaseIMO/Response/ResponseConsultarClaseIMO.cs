using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.ClaseIMO.Response
{
    public class ResponseConsultarClaseIMO : PaginacionResponseBase
    {
       public ResponseConsultarClaseIMO() {

           ListaClaseIMO = new List<ClaseIMO>();
       }
    
        public List<ClaseIMO> ListaClaseIMO { get; set; }
    }
}
