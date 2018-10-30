using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using TRAMARSA.TRANSMISIONES.DTO;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave.Request;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave.Response;
using TRAMARSA.TRANSMISIONES.DTO.Persona.Request;
using TRAMARSA.TRANSMISIONES.DTO.Persona.Response;
using TRAMARSA.TRANSMISIONES.Framework;
using TRAMARSA.TRANSMISIONES.LogicaNegocio.Transmisiones;
using TRAMARSA.TRANSMISIONES.LogicaNegocio.Persona;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento.Request;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento.Response;

namespace TRAMARSA.TRANSMISIONES.ServicioWCF.Transmisiones
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class Transmisiones : ITransmisiones
    {
        [Log]
        public ResponseConsultarTransmisionNaveDTO ConsultarTransmisionNave(RequestConsultarTransmisionNaveDTO request)
        {
            var response = new ResponseConsultarTransmisionNaveDTO();
            try
            {
                response = (new TransmisionesBL()).ConsultarTransmisionNave(request);
                return response;
            }
            catch (ResultException ex)
            {
                ManejadorExcepciones.PublicarExcepcion(string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Result.Mensaje));
                ex.Result.Satisfactorio = false;
                response.Result = ex.Result;

                return response;
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
                response.Result = new Result { Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio", IdError = Guid.NewGuid() };

                return response;
            }
        }

        [Log]
        public ResponseConsultarTransmisionDocumentoDTO ConsultarTransmisionDocumento(RequestConsultarTransmisionDocumentoDTO request)
        {
            var response = new ResponseConsultarTransmisionDocumentoDTO();
            try
            {
                response = (new TransmisionesBL()).ConsultarTransmisionDocumento(request);
                return response;
            }
            catch (ResultException ex)
            {
                ManejadorExcepciones.PublicarExcepcion(string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Result.Mensaje));
                ex.Result.Satisfactorio = false;
                response.Result = ex.Result;

                return response;
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
                response.Result = new Result { Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio", IdError = Guid.NewGuid() };

                return response;
            }
        }

        [Log]
        public ResponseConsultarLogTransmisionNaveDTO ConsultarLogTransmisionNave(RequestConsultarLogTransmisionNaveDTO request)
        {
            var response = new ResponseConsultarLogTransmisionNaveDTO();
            try
            {
                response = (new TransmisionesBL()).ConsultarLogTransmisionNave(request);
                return response;
            }
            catch (ResultException ex)
            {
                ManejadorExcepciones.PublicarExcepcion(string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Result.Mensaje));
                ex.Result.Satisfactorio = false;
                response.Result = ex.Result;

                return response;
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
                response.Result = new Result { Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio", IdError = Guid.NewGuid() };

                return response;
            }
        }

        [Log]
        public ResponseConsultarLogTransmisionDocumentoDTO ConsultarLogTransmisionDocumento(RequestConsultarLogTransmisionDocumentoDTO request)
        {
            var response = new ResponseConsultarLogTransmisionDocumentoDTO();
            try
            {
                response = (new TransmisionesBL()).ConsultarLogTransmisionDocumento(request);
                return response;
            }
            catch (ResultException ex)
            {
                ManejadorExcepciones.PublicarExcepcion(string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Result.Mensaje));
                ex.Result.Satisfactorio = false;
                response.Result = ex.Result;

                return response;
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
                response.Result = new Result { Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio", IdError = Guid.NewGuid() };

                return response;
            }
        }

        [Log]
        public ResponseRegistrarTransmisionNaveDTO RegistrarTransmisionNave(RegistraTransmisionNaveDTO request)
        {
            var response = new ResponseRegistrarTransmisionNaveDTO();
            try
            {
                response = (new TransmisionesBL()).RegistraTransmisionNave(request);
                return response;
            }
            catch (ResultException ex)
            {
                ManejadorExcepciones.PublicarExcepcion(string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Result.Mensaje));
                ex.Result.Satisfactorio = false;
                response.Result = ex.Result;

                return response;
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
                response.Result = new Result { Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio", IdError = Guid.NewGuid() };

                return response;
            }
        }

        [Log]
        public ResponseRegistrarTransmisionDocumentoDTO RegistrarTransmisionDocumento(RegistraTransmisionDocumentoDTO request)
        {
            var response = new ResponseRegistrarTransmisionDocumentoDTO();
            try
            {
                response = (new TransmisionesBL()).RegistraTransmisionDocumento(request);
                return response;
            }
            catch (ResultException ex)
            {
                ManejadorExcepciones.PublicarExcepcion(string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Result.Mensaje));
                ex.Result.Satisfactorio = false;
                response.Result = ex.Result;

                return response;
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
                response.Result = new Result { Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio", IdError = Guid.NewGuid() };

                return response;
            }
        }
    }
}
