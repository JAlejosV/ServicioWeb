using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Contenedor.Response
{
    public class ResponseConsultarContenedor : PaginacionResponseBase
    {
        public ResponseConsultarContenedor() {

           ListaContenedor = new List<Contenedor>();
       }

        public List<Contenedor> ListaContenedor { get; set; }
    }
}
