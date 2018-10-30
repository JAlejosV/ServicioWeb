using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoFlete
{
    [DataContract]
    public class TipoFleteDTO
    {
        [DataMember(Order = 0)]
        public Int64 CodigoTipoFlete { get; set; }
        [DataMember(Order = 1)]
        public string NombreTipoFlete { get; set; }
        [DataMember(Order = 2)]
        public string CodigoAduanaTipoFlete { get; set; }
        [DataMember(Order = 3)]
        public string CodigoEquivalencia { get; set; }
        [DataMember(Order = 4)]
        public string UsuarioCreacion { get; set; }
        [DataMember(Order = 5)]
        public DateTime? FechaHoraCreacion { get; set; }
        [DataMember(Order = 6)]
        public string UsuarioActualizacion { get; set; }
        [DataMember(Order = 7)]
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
