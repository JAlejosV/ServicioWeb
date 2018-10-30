using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Nave.Request
{
    [DataContract]
    public class RequestRegistraNaveDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoNave { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoPais { get; set; }
        [DataMember(Order = 2)]
        public Int64? CodigoTipoNave { get; set; }
        [DataMember(Order = 3)]
        public Int64? CodigoLineaNaviera { get; set; }
        [DataMember(Order = 4)]
        public string NombreNave { get; set; }
        [DataMember(Order = 5)]
        public string MatriculaNave { get; set; }
        [DataMember(Order = 6)]
        public Decimal? TrbNave { get; set; }
        [DataMember(Order = 7)]
        public Decimal? TrnNave { get; set; }
        [DataMember(Order = 8)]
        public Decimal? EsloraNave { get; set; }
        [DataMember(Order = 9)]
        public Decimal? MangaNave { get; set; }
        [DataMember(Order = 10)]
        public Decimal? CaladoNave { get; set; }
        [DataMember(Order = 11)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 12)]
        public string Accion { get; set; }
    }
}
