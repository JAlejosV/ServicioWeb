using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoEnvio.Request
{
    public class RequestRegistroTipoEnvio
    {
        public Int64 CodigoTipoEnvio { get; set; }
        public Int16 CodigoTipoEnvioSunat { get; set; }
        public string NombreTipoEnvio { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
