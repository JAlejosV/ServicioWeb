using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.ClaseIMO
{
    public class ClaseIMO
    {
        public Int64 CodigoClaseIMO { get; set; }
        public string CodigoClaseIMOSunat { get; set; }
        public string NombreClaseIMO { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
