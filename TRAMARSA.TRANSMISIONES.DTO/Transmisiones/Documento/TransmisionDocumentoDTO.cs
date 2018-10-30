using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento
{
    [DataContract]
    public class TransmisionDocumentoDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoDocumento { get; set; }
        [DataMember(Order = 1)]
        public string NumeroDocumento { get; set; }
        [DataMember(Order = 2)]
        public string NombreNave { get; set; }
        [DataMember(Order = 3)]
        public string NumeroViajeItinerario { get; set; }
        [DataMember(Order = 4)]
        public Int32? AnioManifiestoItinerario { get; set; }
        [DataMember(Order = 5)]
        public string NumeroManifiestoItinerario { get; set; }
        [DataMember(Order = 6)]
        public string NombreAduana { get; set; }
        [DataMember(Order = 7)]
        public string NombreTipoEnvio { get; set; }
        [DataMember(Order = 8)]
        public Decimal? TotalPesoBrutoTransmision { get; set; }
        [DataMember(Order = 9)]
        public Int64? TotalBultosTransmision { get; set; }
        [DataMember(Order = 10)]
        public Int64? TotalContenedoresTransmision { get; set; }
        [DataMember(Order = 11)]
        public string Consignatario { get; set; }
        [DataMember(Order = 12)]
        public string Embarcador { get; set; }
        [DataMember(Order = 13)]
        public string PuertoEmbarque { get; set; }
        [DataMember(Order = 14)]
        public string PuertoFinal { get; set; }
        [DataMember(Order = 15)]
        public bool? EstadoEnvioAduanas { get; set; }
        [DataMember(Order = 16)]
        public bool? EstadoTransmision { get; set; }
        [DataMember(Order = 16)]
        public DateTime? FechaHoraCreacion { get; set; }
    }
}
