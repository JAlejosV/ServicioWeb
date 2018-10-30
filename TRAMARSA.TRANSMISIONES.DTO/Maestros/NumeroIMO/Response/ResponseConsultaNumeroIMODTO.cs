using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.NumeroIMO.Response
{
    [DataContract]
    public class ResponseConsultaNumeroIMODTO : ResponseBaseDTO
    {
        public ResponseConsultaNumeroIMODTO()
        {
            this.ListaNumeroIMO = new List<NumeroIMODTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<NumeroIMODTO> ListaNumeroIMO { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
