using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Moneda.Response
{
    [DataContract]
    public class ResponseConsultaMonedaDTO : ResponseBaseDTO
    {
        public ResponseConsultaMonedaDTO()
        {
            this.ListaMoneda = new List<MonedaDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<MonedaDTO> ListaMoneda { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
