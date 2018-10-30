using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.LineaNaviera
{
    [DataContract]
    public class LineaNavieraDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoLineaNaviera { get; set; }
        [DataMember(Order = 1)]
        public string NombreLineaNaviera { get; set; }
        [DataMember(Order = 2)]
        public string DireccionLineaNaviera { get; set; }
        [DataMember(Order = 3)]
        public string RucLineaNaviera { get; set; }
        [DataMember(Order = 4)]
        public string CodigoEquivalencia { get; set; }
        [DataMember(Order = 5)]
        public string UsuarioCreacion { get; set; }
        [DataMember(Order = 6)]
        public DateTime? FechaHoraCreacion { get; set; }
        [DataMember(Order = 7)]
        public string UsuarioActualizacion { get; set; }
        [DataMember(Order = 8)]
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
