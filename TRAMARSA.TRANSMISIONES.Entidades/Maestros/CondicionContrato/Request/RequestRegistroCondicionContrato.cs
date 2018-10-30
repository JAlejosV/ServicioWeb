using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.CondicionContrato.Request
{
    public class RequestRegistroCondicionContrato
    {
        public Int64 CodigoCondicionContrato { get; set; }
        public string CodigoCondicionContratoSunat { get; set; }
        public string NombreCondicionContrato { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
