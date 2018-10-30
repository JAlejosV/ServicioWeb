using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Rol.Response
{
    [DataContract]
    public class ResponseConsultaRolDTO : ResponseBaseDTO
    {
        public ResponseConsultaRolDTO()
        {
            this.ListaRol = new List<RolDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<RolDTO> ListaRol { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
