using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Documento
{
    [DataContract]
    public class DocumentoDetalleFleteDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoDocumentoDetalleFlete { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoDocumento { get; set; }
        [DataMember(Order = 2)]
        public Int64? CodigoTipoFlete { get; set; }
        [DataMember(Order = 3)]
        public string NombreTipoFlete { get; set; }
        [DataMember(Order = 4)]
        public Int64? CodigoMoneda { get; set; }
        [DataMember(Order = 5)]
        public string NombreMoneda { get; set; }
        [DataMember(Order = 6)]
        public Int64? CodigoModoPago { get; set; }
        [DataMember(Order = 7)]
        public string NombreModoPago { get; set; }
        [DataMember(Order = 8)]
        public Decimal? MontoDocumentoDetalleFlete { get; set; }
        //[DataMember(Order = 6)]
        //public bool EstadoRegistro { get; set; }
        //[DataMember(Order = 7)]
        //public string UsuarioRegistro { get; set; }
        [DataMember(Order = 9)]
        public string Accion { get; set; }

    }
}
