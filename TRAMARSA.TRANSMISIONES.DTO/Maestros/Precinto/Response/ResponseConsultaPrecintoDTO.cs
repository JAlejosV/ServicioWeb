using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Precinto.Response
{
    [DataContract]
    public class ResponseConsultaPrecintoDTO : ResponseBaseDTO
    {
        public ResponseConsultaPrecintoDTO()
        {
            this.ListaPrecinto = new List<PrecintoDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<PrecintoDTO> ListaPrecinto { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
