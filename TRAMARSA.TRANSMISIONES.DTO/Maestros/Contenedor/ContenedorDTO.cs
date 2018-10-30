using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Contenedor
{
    [DataContract]
    public class ContenedorDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoContenedor { get; set; }
        [DataMember(Order = 1)]
        public string NumeroContenedor { get; set; }
        [DataMember(Order = 2)]
        public Decimal? TaraContenedor { get; set; }
        [DataMember(Order = 4)]
        public Int64? CodigoTipoContenedor { get; set; }
        [DataMember(Order = 5)]
        public string NombreTipoContenedor { get; set; }
        [DataMember(Order = 6)]
        public string CodTipoContenedor { get; set; }
        [DataMember(Order = 7)]
        public string TamanioTipoContenedor { get; set; }
        [DataMember(Order = 8)]
        public string UsuarioCreacion { get; set; }
        [DataMember(Order = 9)]
        public DateTime? FechaHoraCreacion { get; set; }
        [DataMember(Order = 10)]
        public string UsuarioActualizacion { get; set; }
        [DataMember(Order = 11)]
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
