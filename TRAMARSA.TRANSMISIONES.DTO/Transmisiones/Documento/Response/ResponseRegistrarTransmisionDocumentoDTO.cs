using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento.Response
{
    [DataContract]
    public class ResponseRegistrarTransmisionDocumentoDTO : ResponseBaseDTO
    {
        public ResponseRegistrarTransmisionDocumentoDTO()
        {
            this.Result = new Result();
        }
    }
}
