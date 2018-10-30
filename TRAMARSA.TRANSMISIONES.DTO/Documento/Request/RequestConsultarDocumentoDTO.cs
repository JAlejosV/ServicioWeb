using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Documento.Request
{
    [DataContract]
    public class RequestConsultarDocumentoDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoDocumento { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoItinerario { get; set; }
        [DataMember(Order = 2)]
        public Int64? CodigoPuertoOrigenDocumento { get; set; }
        [DataMember(Order = 3)]
        public Int64? CodigoPuertoEmbarqueDocumento { get; set; }
        [DataMember(Order = 4)]
        public Int64? CodigoPuertoDescargaDocumento { get; set; }
        [DataMember(Order = 5)]
        public Int64? CodigoPuertoFinalDocumento { get; set; }
        [DataMember(Order = 6)]
        public Int64? CodigoLineaNaviera { get; set; }
        [DataMember(Order = 7)]
        public Int64? CodigoAduana { get; set; }
        [DataMember(Order = 8)]
        public Int64? CodigoTipoBL { get; set; }
        [DataMember(Order = 9)]
        public Int64? CodigoTipoEnvio { get; set; }
        [DataMember(Order = 10)]
        public string NumeroDocumento { get; set; }
        [DataMember(Order = 11)]
        public DateTime? FechaEmisionDocumentoInicio { get; set; }
        [DataMember(Order = 12)]
        public DateTime? FechaEmisionDocumentoFin { get; set; }
    }
}
