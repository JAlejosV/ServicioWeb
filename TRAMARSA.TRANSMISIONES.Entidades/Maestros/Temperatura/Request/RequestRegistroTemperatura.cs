using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Temperatura.Request
{
    public class RequestRegistroTemperatura
    {
        public Int64 CodigoTemperatura { get; set; }
        public string CodigoTemperaturaSunat { get; set; }
        public string NombreTemperatura { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
