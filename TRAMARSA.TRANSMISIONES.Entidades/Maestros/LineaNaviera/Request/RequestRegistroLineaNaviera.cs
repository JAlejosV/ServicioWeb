using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.LineaNaviera.Request
{
    public class RequestRegistroLineaNaviera
    {
        public Int64 CodigoLineaNaviera { get; set; }
        public string NombreLineaNaviera { get; set; }
        public string DireccionLineaNaviera { get; set; }
        public string RucLineaNaviera { get; set; }
        public string CodigoEquivalencia { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
