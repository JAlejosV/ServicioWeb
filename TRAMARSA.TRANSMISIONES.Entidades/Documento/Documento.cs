using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Documento
{
    public class Documento
    {
        public Int64? CodigoDocumento { get; set; }
        public Int64? CodigoItinerario { get; set; }
        public Int64? CodigoPuertoOrigenDocumento { get; set; }
        public Int64? CodigoPuertoEmbarqueDocumento { get; set; }
        public Int64? CodigoPuertoDescargaDocumento { get; set; }
        public Int64? CodigoPuertoFinalDocumento { get; set; }
        public Int64? CodigoLineaNaviera { get; set; }
        public Int64? CodigoAduana { get; set; }
        public Int64? CodigoTipoBL { get; set; }
        public Int64? CodigoTipoEnvio { get; set; }
        public string NombreNave { get; set; }
        public string NumeroViajeItinerario { get; set; }
        public string NombrePuertoOrigenDocumento { get; set; }
        public string NombrePuertoEmbarqueDocumento { get; set; }
        public string NombrePuertoDescargaDocumento { get; set; }
        public string NombrePuertoFinalDocumento { get; set; }
        public string NombreLineaNaviera { get; set; }
        public string NombreAduana { get; set; }
        public string NombreTipoBL { get; set; }
        public string NombreTipoEnvio { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime? FechaEmisionDocumento { get; set; }
        public DateTime? FechaEmbarqueDocumento { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }

    }
}
