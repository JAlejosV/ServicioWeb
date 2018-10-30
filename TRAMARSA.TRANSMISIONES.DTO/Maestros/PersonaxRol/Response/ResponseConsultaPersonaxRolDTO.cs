using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.PersonaxRol.Response
{
    [DataContract]
    public class ResponseConsultaPersonaxRolDTO : ResponseBaseDTO
    {
        public ResponseConsultaPersonaxRolDTO()
        {
            this.ListaPersonaxRol = new List<PersonaxRolDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<PersonaxRolDTO> ListaPersonaxRol { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
