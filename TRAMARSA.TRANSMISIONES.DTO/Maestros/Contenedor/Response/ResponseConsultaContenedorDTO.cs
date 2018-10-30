using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Contenedor.Response
{
    [DataContract]
    public class ResponseConsultaContenedorDTO : ResponseBaseDTO
    {
        public ResponseConsultaContenedorDTO()
        {
            this.ListaContenedor = new List<ContenedorDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<ContenedorDTO> ListaContenedor { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
