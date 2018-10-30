using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Puerto
{
    [DataContract]
    public class PuertoDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoPuerto { get; set; }
        [DataMember(Order = 1)]
        public string CodigoPuertoSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombrePuerto { get; set; }
        [DataMember(Order = 3)]
        public Int64? CodigoPais { get; set; }
        [DataMember(Order = 4)]
        public string NombrePais { get; set; }
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
