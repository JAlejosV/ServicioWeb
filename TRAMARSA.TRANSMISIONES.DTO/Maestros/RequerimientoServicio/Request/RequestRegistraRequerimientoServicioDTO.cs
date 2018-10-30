using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.RequerimientoServicio.Request
{
    [DataContract]
    public class RequestRegistraRequerimientoServicioDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoRequerimientoServicio { get; set; }
        [DataMember(Order = 1)]
        public string CodigoRequerimientoServicioSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreRequerimientoServicio { get; set; }
        [DataMember(Order = 3)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 4)]
        public string Accion { get; set; }
    }
}
