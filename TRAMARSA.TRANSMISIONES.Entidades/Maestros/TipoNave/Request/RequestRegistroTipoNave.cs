using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoNave.Request
{
    public class RequestRegistroTipoNave
    {
        public Int64 CodigoTipoNave { get; set; }
        public string CodigoTipoNaveSunat { get; set; }
        public string NombreTipoNave { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
