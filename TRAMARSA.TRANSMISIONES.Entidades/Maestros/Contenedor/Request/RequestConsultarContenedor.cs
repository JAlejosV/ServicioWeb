using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Contenedor.Request
{
    public class RequestConsultarContenedor : PaginacionBase
    {
        public Int64? CodigoContenedor { get; set; }
        public Int64? CodigoTipoContenedor { get; set; }
        public string NumeroContenedor { get; set; }
        public string CodTipoContenedor { get; set; }
        public string TamanioTipoContenedor { get; set; }
        public Decimal? TaraContenedor { get; set; }
    }
}
