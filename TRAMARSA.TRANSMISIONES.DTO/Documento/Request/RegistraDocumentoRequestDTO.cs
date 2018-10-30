using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Documento.Request
{
    [DataContract]
    public class RegistraDocumentoRequestDTO
    {
        public RegistraDocumentoRequestDTO()
        {
            this.ListaDocumentoDetalleCarga = new List<DocumentoDetalleCargaDTO>();
            this.ListaDocumentoDetalleCliente = new List<DocumentoDetalleClienteDTO>();
            this.ListaDocumentoDetalleFlete = new List<DocumentoDetalleFleteDTO>();      
        }
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
        public Int64? CodigoCondicionContrato { get; set; }
        [DataMember(Order = 11)]
        public Int64? CodigoRequerimientoServicio { get; set; }
        [DataMember(Order = 12)]
        public string NumeroDocumento { get; set; }
        [DataMember(Order = 13)]
        public DateTime? FechaEmisionDocumento { get; set; }
        [DataMember(Order = 14)]
        public DateTime? FechaEmbarqueDocumento { get; set; }
        [DataMember(Order = 15)]
        public bool EstadoRegistro { get; set; }
        [DataMember(Order = 16)]
        public string UsuarioCreacion { get; set; }
        [DataMember(Order = 17)]
        public DateTime? FechaHoraCreacion { get; set; }
        [DataMember(Order = 18)]
        public string UsuarioActualizacion { get; set; }
        [DataMember(Order = 19)]
        public DateTime? FechaHoraActualizacion { get; set; }
        [DataMember(Order = 20)]
        public string Accion { get; set; }
        [DataMember(Order = 21)]
        public List<DocumentoDetalleCargaDTO> ListaDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 22)]
        public List<DocumentoDetalleClienteDTO> ListaDocumentoDetalleCliente { get; set; } 
        [DataMember(Order = 23)]
        public List<DocumentoDetalleFleteDTO> ListaDocumentoDetalleFlete { get; set; } 
    }
}
