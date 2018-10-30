using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoMovimiento.Request
{
    public class RequestRegistroTipoMovimiento
    {
        public Int64 CodigoTipoMovimiento { get; set; }
        public string CodigoTipoMovimientoSunat { get; set; }
        public string NombreTipoMovimiento { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
