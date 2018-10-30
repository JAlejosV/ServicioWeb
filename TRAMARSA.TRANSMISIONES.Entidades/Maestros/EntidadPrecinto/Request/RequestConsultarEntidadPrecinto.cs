using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.EntidadPrecinto.Request
{
    public class RequestConsultarEntidadPrecinto : PaginacionBase
    {
        public Int64? CodigoEntidadPrecinto { get; set; }
        public string CodigoEntidadPrecintoSunat { get; set; }
        public string NombreEntidadPrecinto { get; set; }
    }
}
