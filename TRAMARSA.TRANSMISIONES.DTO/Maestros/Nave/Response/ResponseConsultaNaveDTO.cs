using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Nave.Response
{
    [DataContract]
    public class ResponseConsultaNaveDTO : ResponseBaseDTO
    {
        public ResponseConsultaNaveDTO()
        {
            this.ListaNave = new List<NaveDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<NaveDTO> ListaNave { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
