using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoLugarCarga.Request
{
    [DataContract]
    public class RequestConsultarTipoLugarCargaDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoTipoLugarCarga { get; set; }
        [DataMember(Order = 1)]
        public Int16? CodigoTipoLugarCargaSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreTipoLugarCarga { get; set; }
    }
}
