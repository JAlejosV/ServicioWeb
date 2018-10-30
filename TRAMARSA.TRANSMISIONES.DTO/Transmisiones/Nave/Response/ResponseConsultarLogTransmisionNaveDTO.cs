using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave.Response
{
    public class ResponseConsultarLogTransmisionNaveDTO : ResponseBaseDTO
    {
        public ResponseConsultarLogTransmisionNaveDTO()
        {
            this.ListaLogTransmisionNave = new List<LogTransmisionNaveDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<LogTransmisionNaveDTO> ListaLogTransmisionNave { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
