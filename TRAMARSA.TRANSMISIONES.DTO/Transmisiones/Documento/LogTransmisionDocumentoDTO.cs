using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento
{
    [DataContract]
    public class LogTransmisionDocumentoDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoDocumento { get; set; }
        [DataMember(Order = 1)]
        public string CampoLogTransmisionDocumento { get; set; }
        [DataMember(Order = 2)]
        public string ValorLogTransmisionDocumento { get; set; }
        [DataMember(Order = 3)]
        public string TextoLogTransmisionDocumento { get; set; }
        [DataMember(Order = 4)]
        public DateTime? FechaLogTransmisionDocumento { get; set; }
    }
}
