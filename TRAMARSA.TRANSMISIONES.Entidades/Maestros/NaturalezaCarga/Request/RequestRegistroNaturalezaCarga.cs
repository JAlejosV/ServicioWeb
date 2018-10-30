using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.NaturalezaCarga.Request
{
    public class RequestRegistroNaturalezaCarga
    {
        public Int64? CodigoNaturalezaCarga { get; set; }
        public string CodigoNaturalezaCargaSunat { get; set; }
        public string NombreNaturalezaCarga { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
