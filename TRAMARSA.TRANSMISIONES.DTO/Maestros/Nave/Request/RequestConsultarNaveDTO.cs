using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Nave.Request
{
    [DataContract]
    public class RequestConsultarNaveDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoNave { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoPais { get; set; }
        [DataMember(Order = 2)]
        public Int64? CodigoTipoNave { get; set; }
        [DataMember(Order = 3)]
        public Int64? CodigoLineaNaviera { get; set; }
        [DataMember(Order = 4)]
        public string NombreNave { get; set; }
    }
}
