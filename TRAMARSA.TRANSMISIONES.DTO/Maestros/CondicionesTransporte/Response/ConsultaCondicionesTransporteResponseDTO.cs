using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.CondicionesTransporte.Response
{
    [DataContract]
    public class ConsultaCondicionesTransporteResponseDTO : ResponseBaseDTO
    {
        public ConsultaCondicionesTransporteResponseDTO()
        {
            this.Result = new Result();
            this.ListaCondicionesTransporte = new List<CondicionesTransporteDTO>();
        }

        [DataMember(Order = 0)]
        public List<CondicionesTransporteDTO> ListaCondicionesTransporte { get; set; }
    }
}
