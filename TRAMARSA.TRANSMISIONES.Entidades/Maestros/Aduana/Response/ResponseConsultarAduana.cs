using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Aduana.Response
{
    public class ResponseConsultarAduana : PaginacionResponseBase
    {
       public ResponseConsultarAduana() {

           ListaAduana = new List<Aduana>();
       }
    
        public List<Aduana> ListaAduana { get; set; }
    }
}
