using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoOperacion.Response
{
    public class ResponseConsultarTipoOperacion : PaginacionResponseBase
    {
        public ResponseConsultarTipoOperacion() {

            ListaTipoOperacion = new List<TipoOperacion>();
       }

        public List<TipoOperacion> ListaTipoOperacion { get; set; }
    }
}
