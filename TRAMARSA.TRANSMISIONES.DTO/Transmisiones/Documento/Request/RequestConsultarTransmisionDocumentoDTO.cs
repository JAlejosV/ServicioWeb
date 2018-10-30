using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento.Request
{
    [DataContract]
    public class RequestConsultarTransmisionDocumentoDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoDocumento { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoItinerario { get; set; }
        [DataMember(Order = 2)]
        public string NumeroManifiestoItinerario { get; set; }
        [DataMember(Order = 3)]
        public Int32? AnioManifiestoItinerario { get; set; }
        [DataMember(Order = 4)]
        public string NumeroDocumento { get; set; }
        [DataMember(Order = 5)]
        public Int64? CodigoTipoEnvio { get; set; }
        [DataMember(Order = 6)]
        public bool? EstadoEnvioAduanas { get; set; }
        [DataMember(Order = 7)]
        public bool? EstadoTransmision { get; set; }
        [DataMember(Order = 8)]
        public DateTime? FechaInicio { get; set; }
        [DataMember(Order = 9)]
        public DateTime? FechaFin { get; set; }
    }
}
