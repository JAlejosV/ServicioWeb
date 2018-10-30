using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Precinto
{
    [DataContract]
    public class PrecintoDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoPrecinto { get; set; }
        [DataMember(Order = 1)]
        public string NumeroPrecinto { get; set; }
        [DataMember(Order = 2)]
        public Int64? CodigoCondicionPrecinto { get; set; }
        [DataMember(Order = 3)]
        public string NombreCondicionPrecinto { get; set; }
        [DataMember(Order = 4)]
        public Int64? CodigoEntidadPrecinto { get; set; }
        [DataMember(Order = 5)]
        public string NombreEntidadPrecinto { get; set; }
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
