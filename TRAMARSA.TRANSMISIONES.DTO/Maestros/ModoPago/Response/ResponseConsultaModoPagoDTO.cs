using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.ModoPago.Response
{
    [DataContract]
    public class ResponseConsultaModoPagoDTO : ResponseBaseDTO
    {
        public ResponseConsultaModoPagoDTO()
        {
            this.ListaModoPago = new List<ModoPagoDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<ModoPagoDTO> ListaModoPago { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
