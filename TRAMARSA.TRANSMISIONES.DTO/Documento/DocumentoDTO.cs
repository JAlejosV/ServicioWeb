using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Documento
{
    [DataContract]
    public class DocumentoDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoDocumento { get; set; }
        //[DataMember(Order = 1)]
        //public Int64? CodigoItinerario { get; set; }
        //[DataMember(Order = 2)]
        //public Int64? CodigoPuertoOrigenDocumento { get; set; }
        //[DataMember(Order = 3)]
        //public Int64? CodigoPuertoEmbarqueDocumento { get; set; }
        //[DataMember(Order = 4)]
        //public Int64? CodigoPuertoDescargaDocumento { get; set; }
        //[DataMember(Order = 5)]
        //public Int64? CodigoPuertoFinalDocumento { get; set; }
        //[DataMember(Order = 6)]
        //public Int64? CodigoLineaNaviera { get; set; }
        //[DataMember(Order = 7)]
        //public Int64? CodigoAduana { get; set; }
        //[DataMember(Order = 8)]
        //public Int64? CodigoTipoBL { get; set; }
        //[DataMember(Order = 9)]
        //public Int64? CodigoTipoEnvio { get; set; }
        [DataMember(Order = 10)]
        public string NombreNave { get; set; }
        [DataMember(Order = 11)]
        public string NumeroViajeItinerario { get; set; }
        [DataMember(Order = 12)]
        public string NombrePuertoOrigenDocumento { get; set; }
        [DataMember(Order = 13)]
        public string NombrePuertoEmbarqueDocumento { get; set; }
        [DataMember(Order = 14)]
        public string NombrePuertoDescargaDocumento { get; set; }
        [DataMember(Order = 15)]
        public string NombrePuertoFinalDocumento { get; set; }
        [DataMember(Order = 16)]
        public string NombreLineaNaviera { get; set; }
        [DataMember(Order = 17)]
        public string NombreAduana { get; set; }
        [DataMember(Order = 18)]
        public string NombreTipoBL { get; set; }
        [DataMember(Order = 19)]
        public string NombreTipoEnvio { get; set; }
        [DataMember(Order = 20)]
        public string NumeroDocumento { get; set; }
        [DataMember(Order = 21)]
        public DateTime? FechaEmisionDocumento { get; set; }
        [DataMember(Order = 22)]
        public DateTime? FechaEmbarqueDocumento { get; set; }
        [DataMember(Order = 23)]
        public string UsuarioCreacion { get; set; }
        [DataMember(Order = 24)]
        public DateTime? FechaHoraCreacion { get; set; }
        [DataMember(Order = 25)]
        public string UsuarioActualizacion { get; set; }
        [DataMember(Order = 26)]
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
