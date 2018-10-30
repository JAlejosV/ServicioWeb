using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoMovimiento.Request
{
    [DataContract]
    public class RequestConsultarTipoMovimientoDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTipoMovimiento { get; set; }
        [DataMember(Order = 1)]
        public string CodigoTipoMovimientoSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreTipoMovimiento { get; set; }
    }
}
