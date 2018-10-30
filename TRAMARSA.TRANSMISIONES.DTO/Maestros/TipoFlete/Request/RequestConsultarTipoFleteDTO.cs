using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoFlete.Request
{
    [DataContract]
    public class RequestConsultarTipoFleteDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTipoFlete { get; set; }
        [DataMember(Order = 1)]
        public string NombreTipoFlete { get; set; }
        [DataMember(Order = 2)]
        public string CodigoAduanaTipoFlete { get; set; }
        [DataMember(Order = 3)]
        public string CodigoEquivalencia { get; set; }
    }
}
