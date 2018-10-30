using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.ClaseIMO
{
    [DataContract]
    public class ClaseIMODTO
    {
        [DataMember(Order = 0)]
        public Int64 CodigoClaseIMO { get; set; }
        [DataMember(Order = 1)]
        public string CodigoClaseIMOSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreClaseIMO { get; set; }
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
