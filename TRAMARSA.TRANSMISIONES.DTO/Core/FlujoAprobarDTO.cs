using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Core
{
    public class FlujoAprobarDTO
    {
        public int CodigoResponsableTarea { get; set; }
        public int CodigoTarea { get; set; }
        public string CodigoUsuario { get; set; }
        public int CodigoReclamo { get; set; }
        public int Nivel { get; set; }
        public string CodigoCliente { get; set; }
        public double Monto { get; set; }
    }
}
