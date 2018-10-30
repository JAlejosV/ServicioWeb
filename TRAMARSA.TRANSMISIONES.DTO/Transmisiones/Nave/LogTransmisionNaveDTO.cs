using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave
{
    [DataContract]
    public class LogTransmisionNaveDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoItinerario { get; set; }
        [DataMember(Order = 1)]
        public string CampoLogTransmisionItinerario { get; set; }
        [DataMember(Order = 2)]
        public string ValorLogTransmisionItinerario { get; set; }
        [DataMember(Order = 3)]
        public string TextoLogTransmisionItinerario { get; set; }
        [DataMember(Order = 4)]
        public DateTime? FechaLogTransmisionItinerario { get; set; }
    }
}
