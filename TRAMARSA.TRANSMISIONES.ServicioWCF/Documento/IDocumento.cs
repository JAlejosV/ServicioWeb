using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TRAMARSA.TRANSMISIONES.DTO.Documento.Request;
using TRAMARSA.TRANSMISIONES.DTO.Documento.Response;
using TRAMARSA.TRANSMISIONES.DTO.Persona.Request;
using TRAMARSA.TRANSMISIONES.DTO.Persona.Response;

//namespace TRAMARSA.TRANSMISIONES.ServicioWCF.TRANSMISIONES
namespace TRAMARSA.TRANSMISIONES.ServicioWCF.Documento
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITRANSMISIONES" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    //public interface ITRANSMISIONES
    public interface IDocumento
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarDocumento", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        RegistraDocumentoResponseDTO RegistrarDocumento(RegistraDocumentoRequestDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarDocumento", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaDocumentoDTO ConsultarDocumento(RequestConsultarDocumentoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarPersona", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        RegistraPersonaResponseDTO RegistrarPersona(RegistraPersonaRequestDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarPersona", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaPersonaDTO ConsultarPersona(RequestConsultarPersonaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarDetallePersona", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ConsultaDetallePersonaResponseDTO ConsultarDetallePersona(ConsultaDetallePersonaRequestDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarDetalleDocumento", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ConsultaDetalleDocumentoResponseDTO ConsultarDetalleDocumento(ConsultaDetalleDocumentoRequestDTO request);
    }
}
