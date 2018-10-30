using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoLugarCarga.Response
{
    public class ResponseConsultarTipoLugarCarga : PaginacionResponseBase
    {
        public ResponseConsultarTipoLugarCarga() {

            ListaTipoLugarCarga = new List<TipoLugarCarga>();
       }

        public List<TipoLugarCarga> ListaTipoLugarCarga { get; set; }
    }
}
