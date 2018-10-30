using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoNave.Request
{
    [DataContract]
    public class RequestConsultarTipoNaveDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTipoNave { get; set; }
        [DataMember(Order = 1)]
        public string CodigoTipoNaveSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreTipoNave { get; set; }
    }
}
