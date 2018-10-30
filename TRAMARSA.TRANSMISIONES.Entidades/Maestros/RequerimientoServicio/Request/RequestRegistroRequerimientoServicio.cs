using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.RequerimientoServicio.Request
{
    public class RequestRegistroRequerimientoServicio
    {
        public Int64 CodigoRequerimientoServicio { get; set; }
        public string CodigoRequerimientoServicioSunat { get; set; }
        public string NombreRequerimientoServicio { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
