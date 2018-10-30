using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.Temperaturas.Response
{
    [DataContract]
    public class ConsultaTemperaturasResponseDTO : ResponseBaseDTO
        {
            public ConsultaTemperaturasResponseDTO()
            {
                this.Result = new Result();
                this.ListaTemperaturas = new List<TemperaturasDTO>();
            }

            [DataMember(Order = 0)]
            public List<TemperaturasDTO> ListaTemperaturas { get; set; }
        }
}
