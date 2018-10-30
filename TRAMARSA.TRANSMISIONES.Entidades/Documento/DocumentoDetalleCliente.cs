using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Documento
{
    public class DocumentoDetalleCliente
    {
        public Int64? CodigoDocumentoDetalleCliente { get; set; }
        public Int64? CodigoDocumento { get; set; }
        public Int64? CodigoRol { get; set; }
        //public string NombreRol { get; set; }
        public Int64? CodigoPersona { get; set; }
        //public string RazonSocialPersona { get; set; }
        //public bool EstadoRegistro { get; set; }
        //public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }

    public class DocumentoDetalleClienteConsulta
    {
        public Int64? CodigoDocumentoDetalleCliente { get; set; }
        public Int64? CodigoDocumento { get; set; }
        public Int64? CodigoRol { get; set; }
        public string NombreRol { get; set; }
        public Int64? CodigoPersona { get; set; }
        public string RazonSocialPersona { get; set; }
        //public bool EstadoRegistro { get; set; }
        //public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
