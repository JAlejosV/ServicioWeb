using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.ModoPago.Request
{
    public class RequestConsultarModoPago : PaginacionBase
    {
        public Int64? CodigoModoPago { get; set; }
        public string CodigoModoPagoSunat { get; set; }
        public string NombreModoPago { get; set; }
        public string CodigoEquivalencia { get; set; }
        //public bool EstadoRegistro { get; set; }
        //public string OrdenCampo { get; set; }
        //public string OrdenOrientacion { get; set; }

        //public int PaginaActual { get; set; }
        //public int NroRegistrosPorPagina { get; set; }
        //public int TotalRegistros { get; set; }
        //public int CantidadPaginas { get; set; }
    }
}
