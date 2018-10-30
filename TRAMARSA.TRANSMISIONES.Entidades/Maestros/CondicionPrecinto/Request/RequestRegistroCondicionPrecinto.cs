using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.CondicionPrecinto.Request
{
    public class RequestRegistroCondicionPrecinto
    {
        public Int64 CodigoCondicionPrecinto { get; set; }
        public string CodigoCondicionPrecintoSunat { get; set; }
        public string NombreCondicionPrecinto { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
