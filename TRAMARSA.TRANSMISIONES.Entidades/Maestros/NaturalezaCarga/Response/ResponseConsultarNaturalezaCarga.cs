using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.NaturalezaCarga.Response
{
    public class ResponseConsultarNaturalezaCarga : PaginacionResponseBase
    {
       public ResponseConsultarNaturalezaCarga() {

           ListaNaturalezaCarga = new List<NaturalezaCarga>();
       }
    
        public List<NaturalezaCarga> ListaNaturalezaCarga { get; set; }
    }
}
