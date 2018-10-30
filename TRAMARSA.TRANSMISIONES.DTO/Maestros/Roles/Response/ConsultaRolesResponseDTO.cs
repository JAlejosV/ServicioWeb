using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.Roles.Response
{
    [DataContract]
    public class ConsultaRolesResponseDTO : ResponseBaseDTO
    {
        public ConsultaRolesResponseDTO()
        {
            this.Result = new Result();
            this.ListaRoles = new List<RolesDTO>();
        }

        [DataMember(Order = 0)]
        public List<RolesDTO> ListaRoles { get; set; }
    }
}
