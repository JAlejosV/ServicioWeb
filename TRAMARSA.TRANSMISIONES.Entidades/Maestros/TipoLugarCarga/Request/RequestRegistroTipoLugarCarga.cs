using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoLugarCarga.Request
{
    public class RequestRegistroTipoLugarCarga
    {
        public Int64 CodigoTipoLugarCarga { get; set; }
        public Int16 CodigoTipoLugarCargaSunat { get; set; }
        public string NombreTipoLugarCarga { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
