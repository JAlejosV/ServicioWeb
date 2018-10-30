//using System;
//using System.Reflection;
//using System.ServiceModel;
//using System.ServiceModel.Activation;
//using TRAMARSA.TRANSMISIONES.DTO;
//using TRAMARSA.TRANSMISIONES.Framework;
//using TRAMARSA.TRANSMISIONES.LogicaNegocio;
//using TRAMARSA.TRANSMISIONES.DTO.Reclamos.Reclamo.Request;
//using TRAMARSA.TRANSMISIONES.DTO.Reclamos.Reclamo.Response;
//using TRAMARSA.TRANSMISIONES.DTO.Adjunto;
//using TRAMARSA.TRANSMISIONES.DTO.Flujo.Request;
//using TRAMARSA.TRANSMISIONES.DTO.Flujo.Response;
//using TRAMARSA.TRANSMISIONES.DTO.Reclamos.Area.Response;
//using TRAMARSA.TRANSMISIONES.DTO.Reclamos.Area.Request;

//namespace TRAMARSA.TRANSMISIONES.ServicioWCF.RECLAMOS
//{
//    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
//    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
//    public class ReclamoServicio : IReclamoServicio
//    {
//        [Log]
//        public ConsultaReclamoResponseDTO ConsultarReclamo(ConsultaReclamoRequestDTO request)
//        {
//            ConsultaReclamoResponseDTO result = new ConsultaReclamoResponseDTO();
//            try
//            {
//                ReclamoBL reclamo = new ReclamoBL();
//                result = reclamo.ConsultarReclamo(request);
//            }
//            catch (ResultException ex)
//            {
//                ManejadorExcepciones.PublicarExcepcion(string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name,
//                    ex.Result.Mensaje));
//                ex.Result.Satisfactorio = false;
//                result.Result = ex.Result;

//            }
//            catch (Exception ex)
//            {
//                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
//                result.Result = new Result
//                {
//                    Satisfactorio = false,
//                    Mensaje = "Ocurrio un problema interno en el servicio",
//                    IdError = Guid.NewGuid()
//                };

//            }
//            return result;
//        }

//        [Log]
//        public RegistrarReclamoResponseDTO RegistrarReclamo(RegistrarReclamoRequestDTO request)
//        {

//            RegistrarReclamoResponseDTO response = new RegistrarReclamoResponseDTO();
//            try
//            {
//                //Newtonsoft.Json.JsonConvert.SerializeObject(request);
//                var reclamoBL = new ReclamoBL();
//                response = reclamoBL.RegistraReclamo(request);
//            }
//            catch (Exception ex)
//            {
//                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
//                response.Result = new Result
//                {
//                    Satisfactorio = false,
//                    Mensaje = "Ocurrio un problema interno en el servicio",
//                    IdError = Guid.NewGuid()
//                };
//            }
//            return response;
//        }
//        [Log]
//        public IniciarFlujoResponseDTO IniciarFlujo(IniciarFlujoRequestDTO request)
//        {
//            IniciarFlujoResponseDTO response = new IniciarFlujoResponseDTO();
//            try
//            {
//                response = (new ReclamoBL()).IniciarFlujo(request);
//            }
//            catch (Exception ex)
//            {
//                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
//                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
//            }

//            return response;
//        }
//        [Log]
//        public AprobarFlujoResponseDTO AprobarTarea(AprobarFlujoRequestDTO request)
//        {
//            AprobarFlujoResponseDTO response = new AprobarFlujoResponseDTO();
//            try
//            {
//                response = (new ReclamoBL()).AprobarFlujo(request);
//            }
//            catch (Exception ex)
//            {
//                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
//                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
//            }

//            return response;
//        }

//        [Log]
//        public RechazarFlujoResponseDTO RechazarTarea(RechazarFlujoRequestDTO request)
//        {
//            RechazarFlujoResponseDTO response = new RechazarFlujoResponseDTO();
//            try
//            {
//                response = (new ReclamoBL()).RechazarFlujo(request);
//            }
//            catch (Exception ex)
//            {
//                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
//                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
//            }

//            return response;
//        }
//        [Log]
//        public ObtenerReclamoResponseDTO ObtenerReclamo(ObtenerReclamoRequestDTO request)
//        {
//            var response = new ObtenerReclamoResponseDTO();
//            try
//            {
//                var reclamoBL = new ReclamoBL();
//                response = reclamoBL.ObtenerReclamo(request);


//                return response;
//            }
//            catch (ResultException ex)
//            {
//                ManejadorExcepciones.PublicarExcepcion(string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Result.Mensaje));
//                ex.Result.Satisfactorio = false;
//                response.Result = ex.Result;

//                return response;
//            }
//            catch (Exception ex)
//            {
//                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
//                response.Result = new Result { Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio", IdError = Guid.NewGuid() };

//                return response;
//            }

//        }

//        [Log]
//        public ResponseDescargarArchivoDTO DescargarArchivo(RequestDescargarArchivoDTO request)
//        {
//            try
//            {
//                var BL = new AdjuntarArchivosBL();
//                ResponseDescargarArchivoDTO resultado = BL.DescargarArchivo(request);
//                return resultado;
//            }
//            catch (Exception ex)
//            {
//                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
//                return null;
//            }
//        }

//        [Log]
//        public ConsultaReclamoResponseDTO ConsultarEvaluacionFinanzas(ConsultaReclamoRequestDTO request)
//        {
//            ConsultaReclamoResponseDTO result = new ConsultaReclamoResponseDTO();
//            try
//            {
//                ReclamoBL reclamo = new ReclamoBL();
//                result = reclamo.ConsultarEvaluacionFinanzas(request);
//            }
//            catch (ResultException ex)
//            {
//                ManejadorExcepciones.PublicarExcepcion(string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name,
//                    ex.Result.Mensaje));
//                ex.Result.Satisfactorio = false;
//                result.Result = ex.Result;

//            }
//            catch (Exception ex)
//            {
//                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
//                result.Result = new Result
//                {
//                    Satisfactorio = false,
//                    Mensaje = "Ocurrio un problema interno en el servicio",
//                    IdError = Guid.NewGuid()
//                };

//            }
//            return result;
//        }

//        //BEGIN: JDT 12122016
//        [Log]
//        public ConsultaReclamoHistorialResponseDTO ConsultarReclamoHistorial(ConsultaReclamoHistorialRequestDTO request)
//        {
//            ConsultaReclamoHistorialResponseDTO response = new ConsultaReclamoHistorialResponseDTO();
//            try
//            {
//                ReclamoBL reclamoBl = new ReclamoBL();
//                response = reclamoBl.ConsultarReclamoHistorial(request);
//            }
//            catch (Exception ex)
//            {
//                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
//            }

//            return response;
//        }

//        [Log]
//        public AreaResponsableResponseDTO ObtenerAreaResponsable()
//        {
//            AreaResponsableResponseDTO response = new AreaResponsableResponseDTO();
//            try
//            {
//                ReclamoBL reclamobl = new ReclamoBL();
//                response = reclamobl.ObtenerAreaResponsable();
//            }
//            catch (Exception ex)
//            {
//                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
//            }
//            return response;
//        }

//        [Log]
//        public TrabajadorResponseDTO ObtenerJefeTrabajadorArea(AreaRequestDTO request)
//        {
//            TrabajadorResponseDTO response = new TrabajadorResponseDTO();
//            try
//            {
//                ReclamoBL reclamobl = new ReclamoBL();
//                response = reclamobl.ObtenerJefeTrabajadorArea(request);
//            }
//            catch (Exception ex)
//            {
//                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
//            }

//            return response;
//        }
//        //END: JDT 12122016
//    }
//}