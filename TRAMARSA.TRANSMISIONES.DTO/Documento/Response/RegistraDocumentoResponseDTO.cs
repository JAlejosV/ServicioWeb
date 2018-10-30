using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Documento.Response
{
    [DataContract]
    public class RegistraDocumentoResponseDTO : ResponseBaseDTO
    {
        public RegistraDocumentoResponseDTO()
        {
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public long CodigoDocumento { get; set; }
    }
}
