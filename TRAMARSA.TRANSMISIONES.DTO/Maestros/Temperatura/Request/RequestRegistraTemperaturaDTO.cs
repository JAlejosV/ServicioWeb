using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Temperatura.Request
{
    [DataContract]
    public class RequestRegistraTemperaturaDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTemperatura { get; set; }
        [DataMember(Order = 1)]
        public string CodigoTemperaturaSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreTemperatura { get; set; }
        [DataMember(Order = 3)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 4)]
        public string Accion { get; set; }
    }
}
