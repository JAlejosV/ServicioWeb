using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoEnvio.Request
{
    [DataContract]
    public class RequestConsultarTipoEnvioDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTipoEnvio { get; set; }
        [DataMember(Order = 1)]
        public Int16? CodigoTipoEnvioSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreTipoEnvio { get; set; }
    }
}
