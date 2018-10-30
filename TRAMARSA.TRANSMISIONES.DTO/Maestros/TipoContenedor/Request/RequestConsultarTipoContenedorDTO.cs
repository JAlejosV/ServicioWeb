using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoContenedor.Request
{
    [DataContract]
    public class RequestConsultarTipoContenedorDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTipoContenedor { get; set; }
        [DataMember(Order = 1)]
        public string CodigoIsoTipoContenedor { get; set; }
        [DataMember(Order = 2)]
        public string CodigoIsoGrupoTipoContenedor { get; set; }
        [DataMember(Order = 3)]
        public string NombreTipoContenedor { get; set; }
        [DataMember(Order = 4)]
        public string CodTipoContenedor { get; set; }
        [DataMember(Order = 5)]
        public string TamanioTipoContenedor { get; set; }
    }
}
