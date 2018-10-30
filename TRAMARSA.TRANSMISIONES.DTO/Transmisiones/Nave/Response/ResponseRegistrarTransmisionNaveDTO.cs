using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TRAMARSA.TRANSMISIONES.DTO.Transmision.Nave;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave.Response
{
    [DataContract]
    public class ResponseRegistrarTransmisionNaveDTO : ResponseBaseDTO
    {
        public ResponseRegistrarTransmisionNaveDTO()
        {
            this.Result = new Result();
        }
    }
}
