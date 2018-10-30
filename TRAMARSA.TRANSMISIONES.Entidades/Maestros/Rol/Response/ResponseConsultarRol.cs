using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Rol.Response
{
    public class ResponseConsultarRol : PaginacionResponseBase
    {
       public ResponseConsultarRol() {

           ListaRol = new List<Rol>();
       }
    
        public List<Rol> ListaRol { get; set; }
    }
}
