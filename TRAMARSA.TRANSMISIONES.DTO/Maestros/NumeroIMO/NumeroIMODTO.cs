using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.NumeroIMO
{
    [DataContract]
    public class NumeroIMODTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoNumeroIMO { get; set; }
        [DataMember(Order = 1)]
        public string NumberIMO { get; set; }
        [DataMember(Order = 2)]
        public string NombreNumeroIMO { get; set; }
        [DataMember(Order = 3)]
        public Int32? PaginaNumeroIMO { get; set; }
        [DataMember(Order = 4)]
        public Int64? CodigoClaseIMO { get; set; }
        [DataMember(Order = 5)]
        public string NombreClaseIMO { get; set; }
        [DataMember(Order = 6)]
        public string UsuarioCreacion { get; set; }
        [DataMember(Order = 7)]
        public DateTime? FechaHoraCreacion { get; set; }
        [DataMember(Order = 8)]
        public string UsuarioActualizacion { get; set; }
        [DataMember(Order = 9)]
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
