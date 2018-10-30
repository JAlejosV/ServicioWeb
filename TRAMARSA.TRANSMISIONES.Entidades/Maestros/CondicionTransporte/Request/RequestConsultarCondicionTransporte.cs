using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.CondicionTransporte.Request
{
    public class RequestConsultarCondicionTransporte : PaginacionBase
    {
        public Int64? CodigoCondicionTransporte { get; set; }
        public string CodigoCondicionTransporteSunat { get; set; }
        public string NombreCondicionTransporte { get; set; }
        public string CodigoAduanaCondicionTransporte { get; set; }
    }
}
