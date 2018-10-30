using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.RequerimientoServicio
{
    public class RequerimientoServicio
    {
        public Int64 CodigoRequerimientoServicio { get; set; }
        public string CodigoRequerimientoServicioSunat { get; set; }
        public string NombreRequerimientoServicio { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
