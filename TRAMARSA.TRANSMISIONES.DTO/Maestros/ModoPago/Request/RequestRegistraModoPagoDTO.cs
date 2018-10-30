using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.ModoPago.Request
{
    [DataContract]
    public class RequestRegistraModoPagoDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoModoPago { get; set; }
        [DataMember(Order = 1)]
        public string CodigoModoPagoSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreModoPago { get; set; }
        [DataMember(Order = 3)]
        public string CodigoEquivalencia { get; set; }
        [DataMember(Order = 3)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 4)]
        public string Accion { get; set; }
    }
}
