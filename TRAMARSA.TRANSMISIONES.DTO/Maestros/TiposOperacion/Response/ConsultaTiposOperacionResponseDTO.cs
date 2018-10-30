using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposOperacion.Response
{
    [DataContract]
    public class ConsultaTiposOperacionResponseDTO : ResponseBaseDTO
    {
        public ConsultaTiposOperacionResponseDTO()
        {
            this.Result = new Result();
            this.ListaTiposOperacion = new List<TiposOperacionDTO>();
        }

        [DataMember(Order = 0)]
        public List<TiposOperacionDTO> ListaTiposOperacion { get; set; }
    }
}
