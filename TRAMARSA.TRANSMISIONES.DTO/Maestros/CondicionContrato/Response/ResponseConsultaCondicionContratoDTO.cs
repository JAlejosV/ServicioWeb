using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.CondicionContrato.Response
{
    [DataContract]
    public class ResponseConsultaCondicionContratoDTO : ResponseBaseDTO
    {
        public ResponseConsultaCondicionContratoDTO()
        {
            this.ListaCondicionContrato = new List<CondicionContratoDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<CondicionContratoDTO> ListaCondicionContrato { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
