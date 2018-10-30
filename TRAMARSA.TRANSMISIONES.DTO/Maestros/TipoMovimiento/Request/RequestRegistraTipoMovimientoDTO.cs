using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoMovimiento.Request
{
    [DataContract]
    public class RequestRegistraTipoMovimientoDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTipoMovimiento { get; set; }
        [DataMember(Order = 1)]
        public string CodigoTipoMovimientoSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreTipoMovimiento { get; set; }
        [DataMember(Order = 3)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 4)]
        public string Accion { get; set; }
    }
}
