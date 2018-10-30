using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoLugarCarga.Response
{
    [DataContract]
    public class ResponseConsultaTipoLugarCargaDTO : ResponseBaseDTO
    {
        public ResponseConsultaTipoLugarCargaDTO()
        {
            this.ListaTipoLugarCarga = new List<TipoLugarCargaDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<TipoLugarCargaDTO> ListaTipoLugarCarga { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
