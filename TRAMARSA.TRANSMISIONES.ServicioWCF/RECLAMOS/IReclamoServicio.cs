//using System.ServiceModel;
//using System.ServiceModel.Web;
//using TRAMARSA.TRANSMISIONES.DTO.Reclamos.Reclamo.Request;
//using TRAMARSA.TRANSMISIONES.DTO.Reclamos.Reclamo.Response;
//using TRAMARSA.TRANSMISIONES.DTO.Adjunto;
//using TRAMARSA.TRANSMISIONES.DTO.Flujo.Request;
//using TRAMARSA.TRANSMISIONES.DTO.Flujo.Response;
//using TRAMARSA.TRANSMISIONES.DTO.Reclamos.Area.Response;
//using TRAMARSA.TRANSMISIONES.DTO.Reclamos.Area.Request;

//namespace TRAMARSA.TRANSMISIONES.ServicioWCF.RECLAMOS
//{
//    [ServiceContract]
//    public interface IReclamoServicio
//    {

//        /// <summary>
//        /// Consulta los Reclamos
//        /// </summary>
//        /// <param name="request"></param>
//        /// <returns></returns>
//        [OperationContract]
//        [WebInvoke(UriTemplate = "/ConsultarReclamo", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
//        ConsultaReclamoResponseDTO ConsultarReclamo(ConsultaReclamoRequestDTO request);

//        /// <summary>
//        /// Consulta Evaluacion Finanzas
//        /// </summary>
//        /// <param name="request"></param>
//        /// <returns></returns>
//        [OperationContract]
//        [WebInvoke(UriTemplate = "/ConsultarEvaluacionFinanzas", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
//        ConsultaReclamoResponseDTO ConsultarEvaluacionFinanzas(ConsultaReclamoRequestDTO request);

//        /// <summary>
//        ///  Registra  la Solicitud del Reclamo
//        /// </summary>
//        /// <param name="request"></param>
//        /// <returns></returns>
//        [OperationContract]
//        [WebInvoke(UriTemplate = "/RegistrarReclamo", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
//        RegistrarReclamoResponseDTO RegistrarReclamo(RegistrarReclamoRequestDTO request);


//        /// <summary>
//        /// Obtener Reclamos
//        /// </summary>
//        /// <param name="request"></param>
//        /// <returns></returns>
//        [OperationContract]
//        [WebInvoke(UriTemplate = "/ObtenerReclamo", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
//        ObtenerReclamoResponseDTO ObtenerReclamo(ObtenerReclamoRequestDTO request);


//        /// </summary>
//        /// <param name="request">Entidad con los parámetros para descargar el archivo</param>
//        /// <returns>Entidad con el archivo solicitado en bytes</returns>
//        [OperationContract]
//        [WebInvoke(UriTemplate = "/DescargarArchivo", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
//        ResponseDescargarArchivoDTO DescargarArchivo(RequestDescargarArchivoDTO request);

//        /// <summary>
//        /// Iniciar Flujo
//        /// </summary>
//        /// <param name="request"></param>
//        /// <returns></returns>
//        [OperationContract]
//        [WebInvoke(UriTemplate = "/IniciarFlujo", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
//        IniciarFlujoResponseDTO IniciarFlujo(IniciarFlujoRequestDTO request);

//        /// <summary>
//        /// Aprobar Reclamo
//        /// </summary>
//        /// <param name="request"></param>
//        /// <returns></returns>
//        [OperationContract]
//        [WebInvoke(UriTemplate = "/AprobarTarea", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
//        AprobarFlujoResponseDTO AprobarTarea(AprobarFlujoRequestDTO request);

//        /// <summary>
//        /// Historial Reclamo
//        /// </summary>
//        /// <param name="request"></param>
//        /// <returns></returns>
//        [OperationContract]
//        [WebInvoke(UriTemplate = "/ConsultarReclamoHistorial", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
//        ConsultaReclamoHistorialResponseDTO ConsultarReclamoHistorial(ConsultaReclamoHistorialRequestDTO request);

//        /// <summary>
//        /// Rechazar Reclamo
//        /// </summary>
//        /// <param name="request"></param>
//        /// <returns></returns>
//        [OperationContract]
//        [WebInvoke(UriTemplate = "/RechazarTarea", Method = "POST", RequestFormat = WebMessageFormat.Json,
//            ResponseFormat = WebMessageFormat.Json)]
//        RechazarFlujoResponseDTO RechazarTarea(RechazarFlujoRequestDTO request);

//        /// <summary>
//        /// Area Responsable
//        /// </summary>
//        /// <param name="request"></param>
//        /// <returns></returns>
//        [OperationContract]
//        [WebInvoke(UriTemplate = "/ObtenerAreaResponsable", Method = "POST", RequestFormat = WebMessageFormat.Json,
//            ResponseFormat = WebMessageFormat.Json)]
//        AreaResponsableResponseDTO ObtenerAreaResponsable();

//        /// <summary>
//        /// Jefe Trabajador Responsable
//        /// </summary>
//        /// <param name="request"></param>
//        /// <returns></returns>
//        [OperationContract]
//        [WebInvoke(UriTemplate = "/ObtenerJefeTrabajadorArea", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
//        TrabajadorResponseDTO ObtenerJefeTrabajadorArea(AreaRequestDTO request);



//    }
//}
