using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.CondicionCarga.Response
{
    [DataContract]
    public class ResponseConsultaCondicionCargaDTO : ResponseBaseDTO
    {
        public ResponseConsultaCondicionCargaDTO()
        {
            this.ListaCondicionCarga = new List<CondicionCargaDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<CondicionCargaDTO> ListaCondicionCarga { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
