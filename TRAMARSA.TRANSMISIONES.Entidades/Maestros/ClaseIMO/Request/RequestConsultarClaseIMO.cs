using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.ClaseIMO.Request
{
    public class RequestConsultarClaseIMO : PaginacionBase
    {
        public Int64? CodigoClaseIMO { get; set; }
        public string CodigoClaseIMOSunat { get; set; }
        public string NombreClaseIMO { get; set; }
    }
}
