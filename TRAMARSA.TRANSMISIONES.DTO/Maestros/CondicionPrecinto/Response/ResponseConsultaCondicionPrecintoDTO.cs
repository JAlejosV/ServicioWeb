using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.CondicionPrecinto.Response
{
    [DataContract]
    public class ResponseConsultaCondicionPrecintoDTO : ResponseBaseDTO
    {
        public ResponseConsultaCondicionPrecintoDTO()
        {
            this.ListaCondicionPrecinto = new List<CondicionPrecintoDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<CondicionPrecintoDTO> ListaCondicionPrecinto { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
