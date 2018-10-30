using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Documento
{
    [DataContract]
    public class DocumentoDetalleClienteDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoDocumentoDetalleCliente { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoDocumento { get; set; }
        [DataMember(Order = 2)]
        public Int64? CodigoRol { get; set; }
        [DataMember(Order = 3)]
        public string NombreRol { get; set; }
        [DataMember(Order = 4)]
        public Int64? CodigoPersona { get; set; }
        [DataMember(Order = 5)]
        public string RazonSocialPersona { get; set; }
        [DataMember(Order = 6)]
        public string Accion { get; set; }
    }
}
