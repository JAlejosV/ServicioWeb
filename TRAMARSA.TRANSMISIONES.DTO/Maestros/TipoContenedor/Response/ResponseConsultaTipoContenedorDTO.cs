using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoContenedor.Response
{
    [DataContract]
    public class ResponseConsultaTipoContenedorDTO : ResponseBaseDTO
    {
        public ResponseConsultaTipoContenedorDTO()
        {
            this.ListaTipoContenedor = new List<TipoContenedorDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<TipoContenedorDTO> ListaTipoContenedor { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
