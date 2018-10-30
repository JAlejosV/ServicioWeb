using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoMovimiento.Response
{
    [DataContract]
    public class ResponseConsultaTipoMovimientoDTO : ResponseBaseDTO
    {
        public ResponseConsultaTipoMovimientoDTO()
        {
            this.ListaTipoMovimiento = new List<TipoMovimientoDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<TipoMovimientoDTO> ListaTipoMovimiento { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
