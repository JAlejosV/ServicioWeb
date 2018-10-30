using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.NaturalezaCarga.Request
{
    [DataContract]
    public class RequestRegistraNaturalezaCargaDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoNaturalezaCarga { get; set; }
        [DataMember(Order = 1)]
        public string CodigoNaturalezaCargaSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreNaturalezaCarga { get; set; }
        [DataMember(Order = 3)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 4)]
        public string Accion { get; set; }
    }
}
