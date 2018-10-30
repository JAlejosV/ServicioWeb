using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Aduana.Response
{
    [DataContract]
    public class ResponseConsultaAduanaDTO : ResponseBaseDTO
    {
        public ResponseConsultaAduanaDTO()
        {
            this.ListaAduana = new List<AduanaDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<AduanaDTO> ListaAduana { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
