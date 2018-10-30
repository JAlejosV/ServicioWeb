using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.CondicionCarga.Response
{
    public class ResponseConsultarCondicionCarga : PaginacionResponseBase
    {
       public ResponseConsultarCondicionCarga() {

           ListaCondicionCarga = new List<CondicionCarga>();
       }
    
        public List<CondicionCarga> ListaCondicionCarga { get; set; }
    }
}
