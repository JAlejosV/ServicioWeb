using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.NaturalezaCarga
{
    public class NaturalezaCarga
    {
        public Int64 CodigoNaturalezaCarga { get; set; }
        public string CodigoNaturalezaCargaSunat { get; set; }
        public string NombreNaturalezaCarga { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
