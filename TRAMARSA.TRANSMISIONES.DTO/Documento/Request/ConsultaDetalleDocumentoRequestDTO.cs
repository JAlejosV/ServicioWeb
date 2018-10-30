using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Documento.Request
{
    [DataContract]
    public class ConsultaDetalleDocumentoRequestDTO
    {
        [DataMember(Order = 0)]
        public Int64 CodigoDocumento { get; set; }
    }
}
