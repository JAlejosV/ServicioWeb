using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoContenedor.Request
{
    [DataContract]
    public class RequestRegistraTipoContenedorDTO
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
        public string CodigoAduanaTipoContenedor { get; set; }
        [DataMember(Order = 5)]
        public string CodTipoContenedor { get; set; }
        [DataMember(Order = 6)]
        public string TamanioTipoContenedor { get; set; }
        [DataMember(Order = 7)]
        public string IsoTipoContenedor { get; set; }
        [DataMember(Order = 8)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 9)]
        public string Accion { get; set; }
    }
}
