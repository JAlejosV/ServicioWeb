using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoEnvio.Response
{
    [DataContract]
    public class ResponseConsultaTipoEnvioDTO : ResponseBaseDTO
    {
        public ResponseConsultaTipoEnvioDTO()
        {
            this.ListaTipoEnvio = new List<TipoEnvioDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<TipoEnvioDTO> ListaTipoEnvio { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
