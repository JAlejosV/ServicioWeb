using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Nave.Request
{
    public class RequestConsultarNave : PaginacionBase
    {
        public Int64? CodigoNave { get; set; }
        public Int64? CodigoPais { get; set; }
        public Int64? CodigoTipoNave { get; set; }
        public Int64? CodigoLineaNaviera { get; set; }
        public string NombreNave { get; set; }
        //public bool EstadoRegistro { get; set; }
        //public string OrdenCampo { get; set; }
        //public string OrdenOrientacion { get; set; }

        //public int PaginaActual { get; set; }
        //public int NroRegistrosPorPagina { get; set; }
        //public int TotalRegistros { get; set; }
        //public int CantidadPaginas { get; set; }
    }
}
