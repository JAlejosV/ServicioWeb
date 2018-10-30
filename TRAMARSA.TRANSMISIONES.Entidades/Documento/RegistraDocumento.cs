using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TRAMARSA.TRANSMISIONES.Entidades.Documento
{
    public class RegistraDocumento
    {
        public RegistraDocumento()
        {
            this.ListaDocumentoDetalleCarga = new List<DocumentoDetalleCarga>();
            this.ListaDocumentoDetalleCliente = new List<DocumentoDetalleCliente>();
            this.ListaDocumentoDetalleFlete = new List<DocumentoDetalleFlete>();
        }

        public Int64 CodigoDocumento { get; set; }
        public Int64? CodigoItinerario { get; set; }
        public Int64? CodigoPuertoOrigenDocumento { get; set; }
        public Int64? CodigoPuertoEmbarqueDocumento { get; set; }
        public Int64? CodigoPuertoDescargaDocumento { get; set; }
        public Int64? CodigoPuertoFinalDocumento { get; set; }
        public Int64? CodigoLineaNaviera { get; set; }
        public Int64? CodigoAduana { get; set; }
        public Int64? CodigoTipoBL { get; set; }
        public Int64? CodigoTipoEnvio { get; set; }
        public Int64? CodigoCondicionContrato { get; set; }
        public Int64? CodigoRequerimientoServicio { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime? FechaEmisionDocumento { get; set; }
        public DateTime? FechaEmbarqueDocumento { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
        public string Accion { get; set; }

        public List<DocumentoDetalleCarga> ListaDocumentoDetalleCarga { get; set; }
        public List<DocumentoDetalleCliente> ListaDocumentoDetalleCliente { get; set; }
        public List<DocumentoDetalleFlete> ListaDocumentoDetalleFlete { get; set; }
    }
}
