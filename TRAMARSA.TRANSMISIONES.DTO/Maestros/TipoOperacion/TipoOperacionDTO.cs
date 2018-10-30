using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoOperacion
{
    [DataContract]
    public class TipoOperacionDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTipoOperacion { get; set; }
        [DataMember(Order = 1)]
        public Byte CodigoTipoOperacionSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreTipoOperacion { get; set; }
        [DataMember(Order = 3)]
        public string UsuarioCreacion { get; set; }
        [DataMember(Order = 4)]
        public DateTime? FechaHoraCreacion { get; set; }
        [DataMember(Order = 5)]
        public string UsuarioActualizacion { get; set; }
        [DataMember(Order = 6)]
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
