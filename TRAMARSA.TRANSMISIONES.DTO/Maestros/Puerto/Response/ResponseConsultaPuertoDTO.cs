using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Puerto.Response
{
    [DataContract]
    public class ResponseConsultaPuertoDTO : ResponseBaseDTO
    {
        public ResponseConsultaPuertoDTO()
        {
            this.ListaPuerto = new List<PuertoDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<PuertoDTO> ListaPuerto { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
