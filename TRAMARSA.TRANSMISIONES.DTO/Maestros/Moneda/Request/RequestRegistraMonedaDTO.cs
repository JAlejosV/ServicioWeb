using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Moneda.Request
{
    [DataContract]
    public class RequestRegistraMonedaDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoMoneda { get; set; }
        [DataMember(Order = 1)]
        public string CodigoMonedaSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreMoneda { get; set; }
        [DataMember(Order = 3)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 4)]
        public string Accion { get; set; }
    }
}
