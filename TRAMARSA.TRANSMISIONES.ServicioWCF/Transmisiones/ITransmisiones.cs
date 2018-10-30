using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave.Response;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave.Request;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento.Request;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento.Response;

namespace TRAMARSA.TRANSMISIONES.ServicioWCF.Transmisiones
{
    [ServiceContract]
    public interface ITransmisiones
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarTransmisionNave", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultarTransmisionNaveDTO ConsultarTransmisionNave(RequestConsultarTransmisionNaveDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarTransmisionDocumento", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultarTransmisionDocumentoDTO ConsultarTransmisionDocumento(RequestConsultarTransmisionDocumentoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarLogTransmisionNave", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultarLogTransmisionNaveDTO ConsultarLogTransmisionNave(RequestConsultarLogTransmisionNaveDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarTransmisionNave", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistrarTransmisionNaveDTO RegistrarTransmisionNave(RegistraTransmisionNaveDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarLogTransmisionDocumento", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultarLogTransmisionDocumentoDTO ConsultarLogTransmisionDocumento(RequestConsultarLogTransmisionDocumentoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarTransmisionDocumento", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistrarTransmisionDocumentoDTO RegistrarTransmisionDocumento(RegistraTransmisionDocumentoDTO request);
    }
}
