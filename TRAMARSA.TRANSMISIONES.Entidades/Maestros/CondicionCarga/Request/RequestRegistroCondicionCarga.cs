using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.CondicionCarga.Request
{
    public class RequestRegistroCondicionCarga
    {
        public Int64 CodigoCondicionCarga { get; set; }
        public string CodigoCondicionCargaSunat { get; set; }
        public string NombreCondicionCarga { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
