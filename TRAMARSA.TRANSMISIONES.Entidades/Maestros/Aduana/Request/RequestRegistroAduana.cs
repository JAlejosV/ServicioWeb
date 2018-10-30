using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Aduana.Request
{
    public class RequestRegistroAduana
    {
        public Int64? CodigoAduana { get; set; }
        public Int64? CodigoPuerto { get; set; }
        public Int64? CodigoViaTransporte { get; set; }
        public Int32? CodigoAduanaSunat { get; set; }
        public string NombreAduana { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
