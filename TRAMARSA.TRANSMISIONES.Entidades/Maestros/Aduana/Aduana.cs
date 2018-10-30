using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Aduana
{
    public class Aduana
    {
        public Int64? CodigoAduana { get; set; }
        public Int64? CodigoPuerto { get; set; }
        public Int64? CodigoViaTransporte { get; set; }
        public Int32? CodigoAduanaSunat { get; set; }
        public string NombreAduana { get; set; }
        public string NombrePuerto { get; set; }
        public string NombreViaTransporte { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
