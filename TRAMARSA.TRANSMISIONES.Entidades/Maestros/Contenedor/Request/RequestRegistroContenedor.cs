using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Contenedor.Request
{
    public class RequestRegistroContenedor
    {
        public Int64? CodigoContenedor { get; set; }
        public Int64? CodigoTipoContenedor { get; set; }
        public string NumeroContenedor { get; set; }
        public Decimal? TaraContenedor { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
