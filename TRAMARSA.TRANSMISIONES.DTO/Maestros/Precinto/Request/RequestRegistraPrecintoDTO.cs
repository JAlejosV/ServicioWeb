using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Precinto.Request
{
    [DataContract]
    public class RequestRegistraPrecintoDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoPrecinto { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoCondicionPrecinto { get; set; }
        [DataMember(Order = 2)]
        public Int64? CodigoEntidadPrecinto { get; set; }
        [DataMember(Order = 3)]
        public string NumeroPrecinto { get; set; }
        [DataMember(Order = 4)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 5)]
        public string Accion { get; set; }
    }
}
