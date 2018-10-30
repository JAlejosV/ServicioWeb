using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoEnvio.Request
{
    [DataContract]
    public class RequestRegistraTipoEnvioDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTipoEnvio { get; set; }
        [DataMember(Order = 1)]
        public Int16? CodigoTipoEnvioSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreTipoEnvio { get; set; }
        [DataMember(Order = 3)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 4)]
        public string Accion { get; set; }
    }
}
