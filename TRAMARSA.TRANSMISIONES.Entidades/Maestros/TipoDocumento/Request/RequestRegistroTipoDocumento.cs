using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoDocumento.Request
{
    public class RequestRegistroTipoDocumento
    {
        public Int64 CodigoTipoDocumento { get; set; }
        public Int16 CodigoTipoDocumentoSunat { get; set; }
        public string NombreTipoDocumento { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
