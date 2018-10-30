using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Itinerario.Response
{
    [DataContract]
    public class ResponseRegistraItinerarioDTO: ResponseBaseDTO
    {
        [DataMember(Order = 0)]
        public string CodigoMensaje { get; set; }
        [DataMember(Order = 1)]
        public string Mensaje { get; set; }
        public ResponseRegistraItinerarioDTO()
        {
            this.Result = new Result();
        }
    }
}
