using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.ViaTransporte.Response
{
    [DataContract]
    public class ResponseConsultaViaTransporteDTO : ResponseBaseDTO
    {       
        public ResponseConsultaViaTransporteDTO()
        {
            this.ListaViaTransporte = new List<ViaTransporteDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<ViaTransporteDTO> ListaViaTransporte { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
