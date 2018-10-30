using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Pais.Response
{
    [DataContract]
    public class ResponseConsultaPaisDTO : ResponseBaseDTO
    {
        public ResponseConsultaPaisDTO()
        {
            this.ListaPais = new List<PaisDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<PaisDTO> ListaPais { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
