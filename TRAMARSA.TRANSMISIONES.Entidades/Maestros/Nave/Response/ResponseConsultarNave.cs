using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Nave.Response
{
    public class ResponseConsultarNave : PaginacionResponseBase
    {
       public ResponseConsultarNave() {

           ListaNave = new List<Nave>();
       }

       public List<Nave> ListaNave { get; set; }
    }
}
