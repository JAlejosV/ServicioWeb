using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoBL.Request
{
    [DataContract]
    public class RequestRegistraTipoBLDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTipoBL { get; set; }
        [DataMember(Order = 1)]
        public string CodigoTipoBLSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreTipoBL { get; set; }
        [DataMember(Order = 3)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 4)]
        public string Accion { get; set; }
    }
}
