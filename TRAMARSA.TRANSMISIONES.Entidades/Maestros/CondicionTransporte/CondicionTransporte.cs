using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.CondicionTransporte
{
    public class CondicionTransporte
    {
        public Int64 CodigoCondicionTransporte { get; set; }
        public string CodigoCondicionTransporteSunat { get; set; }
        public string NombreCondicionTransporte { get; set; }
        public string CodigoAduanaCondicionTransporte { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
