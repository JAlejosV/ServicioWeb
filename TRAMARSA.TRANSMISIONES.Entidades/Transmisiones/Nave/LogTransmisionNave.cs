using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Nave
{
    public class LogTransmisionNave
    {
        public Int64? CodigoItinerario { get; set; }        
        public string CampoLogTransmisionItinerario { get; set; }
        public string ValorLogTransmisionItinerario { get; set; }
        public string TextoLogTransmisionItinerario { get; set; }
        public DateTime? FechaLogTransmisionItinerario { get; set; }
    }
}
