using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoOperacion.Request
{
    public class RequestRegistroTipoOperacion
    {
        public Int64 CodigoTipoOperacion { get; set; }
        public string CodigoTipoOperacionSunat { get; set; }
        public string NombreTipoOperacion { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
