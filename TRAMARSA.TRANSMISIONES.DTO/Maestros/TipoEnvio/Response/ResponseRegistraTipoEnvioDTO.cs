using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoEnvio.Response
{
    [DataContract]
    public class ResponseRegistraTipoEnvioDTO : ResponseBaseDTO
    {
        [DataMember(Order = 0)]
        public string CodigoMensaje { get; set; }
        [DataMember(Order = 1)]
        public string Mensaje { get; set; }
        public ResponseRegistraTipoEnvioDTO()
        {
            this.Result = new Result();
        }
    }
}
