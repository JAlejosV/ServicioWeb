using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Documento
{
    public class LogTransmisionDocumento
    {
        public Int64? CodigoDocumento { get; set; }
        public string CampoLogTransmisionDocumento { get; set; }
        public string ValorLogTransmisionDocumento { get; set; }
        public string TextoLogTransmisionDocumento { get; set; }
        public DateTime? FechaLogTransmisionDocumento { get; set; }
    }
}
