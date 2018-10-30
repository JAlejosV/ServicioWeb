using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Nave.Request
{
    public class RequestConsultarLogTransmisionNave : PaginacionBase
    {
        public Int64? CodigoItinerario { get; set; }
    }
}
