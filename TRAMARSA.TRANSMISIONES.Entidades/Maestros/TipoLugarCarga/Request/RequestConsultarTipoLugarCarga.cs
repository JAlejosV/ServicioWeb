using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoLugarCarga.Request
{
    public class RequestConsultarTipoLugarCarga : PaginacionBase
    {
        public Int64? CodigoTipoLugarCarga { get; set; }
        public Int16? CodigoTipoLugarCargaSunat { get; set; }
        public string NombreTipoLugarCarga { get; set; }
    }
}
