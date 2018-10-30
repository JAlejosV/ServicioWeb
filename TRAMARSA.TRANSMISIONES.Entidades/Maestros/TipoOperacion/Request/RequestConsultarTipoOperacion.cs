using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoOperacion.Request
{
    public class RequestConsultarTipoOperacion : PaginacionBase
    {
        public Int64? CodigoTipoOperacion { get; set; }
        public Byte? CodigoTipoOperacionSunat { get; set; }
        public string NombreTipoOperacion { get; set; }
        //public bool EstadoRegistro { get; set; }
        //public string OrdenCampo { get; set; }
        //public string OrdenOrientacion { get; set; }

        //public int PaginaActual { get; set; }
        //public int NroRegistrosPorPagina { get; set; }
        //public int TotalRegistros { get; set; }
        //public int CantidadPaginas { get; set; }
    }
}
