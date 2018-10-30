using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.ModosPago;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.ModosPago.Response
{
    [DataContract]
    public class ConsultaModosPagoResponseDTO : ResponseBaseDTO
        {
        public ConsultaModosPagoResponseDTO()
            {
                this.Result = new Result();
                this.ListaModosPago = new List<ModosPagoDTO>();
            }

            [DataMember(Order = 0)]
            public List<ModosPagoDTO> ListaModosPago { get; set; }
        }
}
