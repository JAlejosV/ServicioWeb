using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Rol.Request
{
    [DataContract]
    public class RequestConsultarRolDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoRol { get; set; }
        [DataMember(Order = 1)]
        public string CodigoRolSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreRol { get; set; }
    }
}
