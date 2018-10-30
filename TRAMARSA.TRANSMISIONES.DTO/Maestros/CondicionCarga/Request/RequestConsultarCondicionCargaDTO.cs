using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.CondicionCarga.Request
{
    [DataContract]
    public class RequestConsultarCondicionCargaDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoCondicionCarga { get; set; }
        [DataMember(Order = 1)]
        public string CodigoCondicionCargaSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreCondicionCarga { get; set; }
    }
}
