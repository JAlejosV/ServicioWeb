using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoBL.Request
{
    public class RequestRegistroTipoBL
    {
        public Int64 CodigoTipoBL { get; set; }
        public string CodigoTipoBLSunat { get; set; }
        public string NombreTipoBL { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
