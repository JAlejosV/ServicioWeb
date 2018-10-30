using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoContenedor.Request
{
    public class RequestConsultarTipoContenedor : PaginacionBase
    {
        public Int64? CodigoTipoContenedor { get; set; }
        public string CodigoIsoTipoContenedor { get; set; }
        public string CodigoIsoGrupoTipoContenedor { get; set; }
        public string NombreTipoContenedor { get; set; }
        //public string CodigoAduanaTipoContenedor { get; set; }
        public string CodTipoContenedor { get; set; }
        public string TamanioTipoContenedor { get; set; }
        //public string IsoTipoContenedor { get; set; }
        //public bool EstadoRegistro { get; set; }
        //public string OrdenCampo { get; set; }
        //public string OrdenOrientacion { get; set; }

        //public int PaginaActual { get; set; }
        //public int NroRegistrosPorPagina { get; set; }
        //public int TotalRegistros { get; set; }
        //public int CantidadPaginas { get; set; }
    }
}
