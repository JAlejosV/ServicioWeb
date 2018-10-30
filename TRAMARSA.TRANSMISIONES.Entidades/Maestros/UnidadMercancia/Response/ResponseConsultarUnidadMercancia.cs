using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.UnidadMercancia.Response
{
    public class ResponseConsultarUnidadMercancia : PaginacionResponseBase
    {
       public ResponseConsultarUnidadMercancia() {

           ListaUnidadMercancia = new List<UnidadMercancia>();
       }
    
        public List<UnidadMercancia> ListaUnidadMercancia { get; set; }
    }
}
