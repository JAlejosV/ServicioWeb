using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO
{
    [DataContract]
    public class ResponsePaginacionBaseDTO
    {
        public ResponsePaginacionBaseDTO()
        {
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public Result Result { get; set; }

        [DataMember(Order=99)]
        public int TotalRegistros { get; set; }
        [DataMember(Order = 99)]
        public int CantidadPaginas { get; set; }
    }
}
