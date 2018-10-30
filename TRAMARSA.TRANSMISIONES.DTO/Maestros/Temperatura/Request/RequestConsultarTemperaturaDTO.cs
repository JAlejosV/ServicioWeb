using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Temperatura.Request
{
    [DataContract]
    public class RequestConsultarTemperaturaDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTemperatura { get; set; }
        [DataMember(Order = 1)]
        public string CodigoTemperaturaSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreTemperatura { get; set; }
    }
}
