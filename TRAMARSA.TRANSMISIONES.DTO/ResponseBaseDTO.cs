using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO
{
    [DataContract]
    public class ResponseBaseDTO
    {
        [DataMember(Order = 0)]
        public Result Result { get; set; }
    }
}
