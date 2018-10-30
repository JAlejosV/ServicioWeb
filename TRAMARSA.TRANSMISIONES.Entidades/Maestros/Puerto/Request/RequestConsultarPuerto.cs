using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Puerto.Request
{
    public class RequestConsultarPuerto : PaginacionBase
    {
        public Int64? CodigoPuerto { get; set; }
        public Int64? CodigoPais { get; set; }
        public string CodigoPuertoSunat { get; set; }
        public string NombrePuerto { get; set; }
    }
}
