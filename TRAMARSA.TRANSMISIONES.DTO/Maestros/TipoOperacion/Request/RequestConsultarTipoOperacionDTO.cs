using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoOperacion.Request
{
    [DataContract]
    public class RequestConsultarTipoOperacionDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTipoOperacion { get; set; }
        [DataMember(Order = 1)]
        public Byte? CodigoTipoOperacionSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreTipoOperacion { get; set; }
    }
}
