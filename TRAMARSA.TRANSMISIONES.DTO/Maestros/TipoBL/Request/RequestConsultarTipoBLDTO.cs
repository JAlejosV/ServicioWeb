using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoBL.Request
{
    [DataContract]
    public class RequestConsultarTipoBLDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTipoBL { get; set; }
        [DataMember(Order = 1)]
        public string CodigoTipoBLSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreTipoBL { get; set; }
    }
}
