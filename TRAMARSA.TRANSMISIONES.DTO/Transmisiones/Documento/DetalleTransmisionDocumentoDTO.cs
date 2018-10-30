using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento
{
    [DataContract]
    public class DetalleTransmisionDocumentoDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoDocumento { get; set; }
    }
}
