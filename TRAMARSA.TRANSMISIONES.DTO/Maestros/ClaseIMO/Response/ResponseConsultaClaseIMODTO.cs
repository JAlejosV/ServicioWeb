using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.ClaseIMO.Response
{
    [DataContract]
    public class ResponseConsultaClaseIMODTO : ResponseBaseDTO
    {
        public ResponseConsultaClaseIMODTO()
        {
            this.ListaClaseIMO = new List<ClaseIMODTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<ClaseIMODTO> ListaClaseIMO { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
