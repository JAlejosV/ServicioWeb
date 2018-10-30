using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TRAMARSA.TRANSMISIONES.DTO.Transmision.Nave;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave.Response
{
    [DataContract]
    public class ResponseConsultarTransmisionNaveDTO : ResponseBaseDTO
    {
        public ResponseConsultarTransmisionNaveDTO()
        {
            this.ListaTransmisionNave = new List<TransmisionNaveDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<TransmisionNaveDTO> ListaTransmisionNave { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
