using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.UnidadMercancia.Response
{
    [DataContract]
    public class ResponseConsultaUnidadMercanciaDTO : ResponseBaseDTO
    {
        public ResponseConsultaUnidadMercanciaDTO()
        {
            this.ListaUnidadMercancia = new List<UnidadMercanciaDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<UnidadMercanciaDTO> ListaUnidadMercancia { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
