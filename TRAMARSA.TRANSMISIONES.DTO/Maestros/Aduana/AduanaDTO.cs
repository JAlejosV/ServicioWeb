using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Aduana
{
    [DataContract]
    public class AduanaDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoAduana { get; set; }
        [DataMember(Order = 1)]
        public Int32? CodigoAduanaSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreAduana { get; set; }
        [DataMember(Order = 3)]
        public Int64? CodigoPuerto { get; set; }
        [DataMember(Order = 4)]
        public string NombrePuerto { get; set; }
        [DataMember(Order = 5)]
        public Int64? CodigoViaTransporte { get; set; }
        [DataMember(Order = 6)]
        public string NombreViaTransporte { get; set; }
        [DataMember(Order = 7)]
        public string UsuarioCreacion { get; set; }
        [DataMember(Order = 8)]
        public DateTime? FechaHoraCreacion { get; set; }
        [DataMember(Order = 9)]
        public string UsuarioActualizacion { get; set; }
        [DataMember(Order = 10)]
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
