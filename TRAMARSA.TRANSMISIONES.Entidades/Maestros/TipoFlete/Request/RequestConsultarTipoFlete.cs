using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoFlete.Request
{
    public class RequestConsultarTipoFlete : PaginacionBase
    {
        public Int64? CodigoTipoFlete { get; set; }
        public string NombreTipoFlete { get; set; }
        public string CodigoAduanaTipoFlete { get; set; }
        public string CodigoEquivalencia { get; set; }
    }
}
