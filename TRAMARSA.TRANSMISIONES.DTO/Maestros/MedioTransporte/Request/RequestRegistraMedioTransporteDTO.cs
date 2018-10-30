using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.MedioTransporte.Request
{
    [DataContract]
    public class RequestRegistraMedioTransporteDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoMedioTransporte { get; set; }
        [DataMember(Order = 1)]
        public Byte? CodigoMedioTransporteSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreMedioTransporte { get; set; }
        [DataMember(Order = 3)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 4)]
        public string Accion { get; set; }
    }
}
