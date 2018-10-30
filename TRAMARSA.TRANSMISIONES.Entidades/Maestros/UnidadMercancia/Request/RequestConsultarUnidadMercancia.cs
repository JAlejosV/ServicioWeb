using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.UnidadMercancia.Request
{
    public class RequestConsultarUnidadMercancia : PaginacionBase
    {
        public Int64? CodigoUnidadMercancia { get; set; }
        public string CodigoUnidadMercanciaSunat { get; set; }
        public string NombreUnidadMercancia { get; set; }
        public string CodigoAduanaUnidadMercancia { get; set; }
    }
}
