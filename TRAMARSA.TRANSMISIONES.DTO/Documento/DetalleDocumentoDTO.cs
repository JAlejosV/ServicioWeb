using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Documento
{
    [DataContract]
    public class DetalleDocumentoDTO
    {
        public DetalleDocumentoDTO()
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
        public string NombreNave { get; set; }
        [DataMember(Order = 3)]
        public string NumeroViajeItinerario { get; set; }
        [DataMember(Order = 4)]
        public string NombreAduanaNave { get; set; }
        [DataMember(Order = 5)]
        public string NombreTipoOperacion { get; set; }
        [DataMember(Order = 6)]
        public Int64? CodigoPuertoOrigenDocumento { get; set; }
        [DataMember(Order = 7)]
        public string NombrePuertoOrigen { get; set; }
        [DataMember(Order = 8)]
        public Int64? CodigoPuertoEmbarqueDocumento { get; set; }
        [DataMember(Order = 9)]
        public string NombrePuertoEmbarque { get; set; }
        [DataMember(Order = 10)]
        public Int64? CodigoPuertoDescargaDocumento { get; set; }
        [DataMember(Order = 11)]
        public string NombrePuertoDescarga { get; set; }
        [DataMember(Order = 12)]
        public Int64? CodigoPuertoFinalDocumento { get; set; }
        [DataMember(Order = 13)]
        public string NombrePuertoFinal { get; set; }
        [DataMember(Order = 14)]
        public Int64? CodigoLineaNaviera { get; set; }
        [DataMember(Order = 15)]
        public string NombreLineaNaviera { get; set; }
        [DataMember(Order = 16)]
        public Int64? CodigoAduana { get; set; }
        [DataMember(Order = 17)]
        public string NombreAduana { get; set; }
        [DataMember(Order = 18)]
        public Int64? CodigoTipoBL { get; set; }
        [DataMember(Order = 19)]
        public string NombreTipoBL { get; set; }
        [DataMember(Order = 20)]
        public Int64? CodigoTipoEnvio { get; set; }
        [DataMember(Order = 21)]
        public string NombreTipoEnvio { get; set; }
        [DataMember(Order = 22)]
        public Int64? CodigoCondicionContrato { get; set; }
        [DataMember(Order = 23)]
        public string NombreCondicionContrato { get; set; }
        [DataMember(Order = 24)]
        public Int64? CodigoRequerimientoServicio { get; set; }
        [DataMember(Order = 25)]
        public string NombreRequerimientoServicio { get; set; }
        [DataMember(Order = 26)]
        public string NumeroDocumento { get; set; }
        [DataMember(Order = 27)]
        public DateTime? FechaEmisionDocumento { get; set; }
        [DataMember(Order = 28)]
        public DateTime? FechaEmbarqueDocumento { get; set; }
        [DataMember(Order = 29)]
        public bool EstadoRegistro { get; set; }
        [DataMember(Order = 30)]
        public string UsuarioCreacion { get; set; }
        [DataMember(Order = 31)]
        public DateTime? FechaHoraCreacion { get; set; }
        [DataMember(Order = 32)]
        public string UsuarioActualizacion { get; set; }
        [DataMember(Order = 33)]
        public DateTime? FechaHoraActualizacion { get; set; }
        [DataMember(Order = 34)]
        public List<DocumentoDetalleCargaDTO> ListaDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 35)]
        public List<DocumentoDetalleClienteDTO> ListaDocumentoDetalleCliente { get; set; }
        [DataMember(Order = 36)]
        public List<DocumentoDetalleFleteDTO> ListaDocumentoDetalleFlete { get; set; }

    }
}
