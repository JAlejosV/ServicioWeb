using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.RequerimientoServicio.Response
{
    public class ResponseConsultarRequerimientoServicio : PaginacionResponseBase
    {
       public ResponseConsultarRequerimientoServicio() {

           ListaRequerimientoServicio = new List<RequerimientoServicio>();
       }
    
        public List<RequerimientoServicio> ListaRequerimientoServicio { get; set; }
    }
}
