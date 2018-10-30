using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.NaturalezaCarga.Response
{
    [DataContract]
    public class ResponseRegistraNaturalezaCargaDTO : ResponseBaseDTO
    {
        [DataMember(Order = 0)]
        public string CodigoMensaje { get; set; }
        [DataMember(Order = 1)]
        public string Mensaje { get; set; }
        public ResponseRegistraNaturalezaCargaDTO()
        {
            this.Result = new Result();
        }
    }
}
