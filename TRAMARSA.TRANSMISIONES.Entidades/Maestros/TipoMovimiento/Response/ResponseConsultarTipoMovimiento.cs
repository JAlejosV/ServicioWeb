using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoMovimiento.Response
{
    public class ResponseConsultarTipoMovimiento : PaginacionResponseBase
    {
        public ResponseConsultarTipoMovimiento() {

            ListaTipoMovimiento = new List<TipoMovimiento>();
       }

        public List<TipoMovimiento> ListaTipoMovimiento { get; set; }
    }
}
