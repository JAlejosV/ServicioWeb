using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoNave.Response
{
    public class ResponseConsultarTipoNave : PaginacionResponseBase
    {
        public ResponseConsultarTipoNave() {

            ListaTipoNave = new List<TipoNave>();
       }

        public List<TipoNave> ListaTipoNave { get; set; }
    }
}
