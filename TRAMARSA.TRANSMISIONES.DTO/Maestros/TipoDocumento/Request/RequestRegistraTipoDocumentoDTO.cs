using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoDocumento.Request
{
    [DataContract]
    public class RequestRegistraTipoDocumentoDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTipoDocumento { get; set; }
        [DataMember(Order = 1)]
        public Int16? CodigoTipoDocumentoSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreTipoDocumento { get; set; }
        [DataMember(Order = 3)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 4)]
        public string Accion { get; set; }
    }
}
