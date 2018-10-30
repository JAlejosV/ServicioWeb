using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Nave.Response
{
    public class ResponseConsultarTransmisionNave : PaginacionResponseBase
    {
        public ResponseConsultarTransmisionNave()
        {
            ListaTransmisionNave = new List<TransmisionNave>();
        }

        public List<TransmisionNave> ListaTransmisionNave { get; set; }
    }
}
