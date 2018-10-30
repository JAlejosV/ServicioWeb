using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Moneda.Request
{
    public class RequestRegistroMoneda
    {
        public Int64 CodigoMoneda { get; set; }
        public string CodigoMonedaSunat { get; set; }
        public string NombreMoneda { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
