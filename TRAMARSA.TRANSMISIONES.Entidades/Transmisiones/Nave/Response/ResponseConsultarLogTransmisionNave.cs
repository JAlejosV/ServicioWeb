using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Nave.Response
{
    public class ResponseConsultarLogTransmisionNave : PaginacionResponseBase
    {
        public ResponseConsultarLogTransmisionNave()
        {
            ListaLogTransmisionNave = new List<LogTransmisionNave>();
        }

        public List<LogTransmisionNave> ListaLogTransmisionNave { get; set; }
    }
}
