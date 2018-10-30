using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Maestros.CondicionesCarga.Response
{
    [DataContract]
    public class ConsultaCondicionesCargaResponseDTO : ResponseBaseDTO
        {
            public ConsultaCondicionesCargaResponseDTO()
            {
                this.Result = new Result();
                this.ListaCondicionesCarga = new List<CondicionesCargaDTO>();
            }

            [DataMember(Order = 0)]
            public List<CondicionesCargaDTO> ListaCondicionesCarga { get; set; }
    }
}
