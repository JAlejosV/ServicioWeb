using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoEnvio
{
    public class TipoEnvio
    {
        public Int64 CodigoTipoEnvio { get; set; }
        public Int16 CodigoTipoEnvioSunat { get; set; }
        public string NombreTipoEnvio { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
