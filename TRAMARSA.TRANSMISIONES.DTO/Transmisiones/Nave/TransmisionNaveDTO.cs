using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmision.Nave
{
    [DataContract]
    public class TransmisionNaveDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoItinerario { get; set; }
        [DataMember(Order = 1)]
        public Int32? AnioManifiestoItinerario { get; set; }
        [DataMember(Order = 2)]
        public string NumeroManifiestoItinerario { get; set; }
        [DataMember(Order = 3)]
        public string NombreNave { get; set; }
        [DataMember(Order = 4)]
        public string NumeroViajeItinerario { get; set; }
        [DataMember(Order = 5)]
        public string NombreAduana { get; set; }
        [DataMember(Order = 6)]
        public string NombreTipoOperacion { get; set; }
        [DataMember(Order = 7)]
        public string NombreOperadorDescargaItinerario { get; set; }
        [DataMember(Order = 8)]
        public DateTime? FechaArriboItinerario { get; set; }
        [DataMember(Order = 9)]
        public Decimal? TotalPesoBrutoTransmision { get; set; }
        [DataMember(Order = 10)]
        public Int64? TotalBultosTransmision { get; set; }
        [DataMember(Order = 11)]
        public Int64? TotalContenedoresTransmision { get; set; }
        [DataMember(Order = 12)]
        public bool? EstadoEnvioAduanas { get; set; }
        [DataMember(Order = 13)]
        public bool? EstadoTransmision { get; set; }
        [DataMember(Order = 14)]
        public DateTime? FechaHoraCreacion { get; set; }
    }
}
