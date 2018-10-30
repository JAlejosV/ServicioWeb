using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.CondicionPrecinto.Request
{
    public class RequestConsultarCondicionPrecinto : PaginacionBase
    {
        public Int64? CodigoCondicionPrecinto { get; set; }
        public string CodigoCondicionPrecintoSunat { get; set; }
        public string NombreCondicionPrecinto { get; set; }
    }
}
