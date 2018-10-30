using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Aduana.Request
{
    [DataContract]
    public class RequestConsultarAduanaDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoAduana { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoPuerto { get; set; }
        [DataMember(Order = 2)]
        public Int64? CodigoViaTransporte { get; set; }
        [DataMember(Order = 3)]
        public Int32? CodigoAduanaSunat { get; set; }
        [DataMember(Order = 4)]
        public string NombreAduana { get; set; }
    }
}
