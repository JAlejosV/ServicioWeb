using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.CondicionTransporte.Response
{
    public class ResponseConsultarCondicionTransporte : PaginacionResponseBase
    {
       public ResponseConsultarCondicionTransporte() {

           ListaCondicionTransporte = new List<CondicionTransporte>();
       }
    
        public List<CondicionTransporte> ListaCondicionTransporte { get; set; }
    }
}
