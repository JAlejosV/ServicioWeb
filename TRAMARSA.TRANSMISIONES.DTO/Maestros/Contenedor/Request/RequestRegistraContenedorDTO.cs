using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Contenedor.Request
{
    [DataContract]
    public class RequestRegistraContenedorDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoContenedor { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoTipoContenedor { get; set; }
        [DataMember(Order = 2)]
        public string NumeroContenedor { get; set; }
        [DataMember(Order = 3)]
        public Decimal? TaraContenedor { get; set; }
        [DataMember(Order = 4)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 5)]
        public string Accion { get; set; }
    }
}
