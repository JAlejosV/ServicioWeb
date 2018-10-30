using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.ModoPago
{
    public class ModoPago
    {
        public Int64 CodigoModoPago { get; set; }
        public string CodigoModoPagoSunat { get; set; }
        public string NombreModoPago { get; set; }
        public string CodigoEquivalencia { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
