using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Temperatura.Response
{
    [DataContract]
    public class ResponseConsultaTemperaturaDTO : ResponseBaseDTO
    {
        public ResponseConsultaTemperaturaDTO()
        {
            this.ListaTemperatura = new List<TemperaturaDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<TemperaturaDTO> ListaTemperatura { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
