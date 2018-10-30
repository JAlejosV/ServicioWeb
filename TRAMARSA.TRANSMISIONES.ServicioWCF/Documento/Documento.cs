using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using TRAMARSA.TRANSMISIONES.DTO;
using TRAMARSA.TRANSMISIONES.DTO.Documento.Request;
using TRAMARSA.TRANSMISIONES.DTO.Documento.Response;
using TRAMARSA.TRANSMISIONES.DTO.Persona.Request;
using TRAMARSA.TRANSMISIONES.DTO.Persona.Response;
using TRAMARSA.TRANSMISIONES.Framework;
using TRAMARSA.TRANSMISIONES.LogicaNegocio.Documento;
using TRAMARSA.TRANSMISIONES.LogicaNegocio.Persona;

namespace TRAMARSA.TRANSMISIONES.ServicioWCF.Documento
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class Documento : IDocumento
    {
        [Log]
        public RegistraDocumentoResponseDTO RegistrarDocumento(RegistraDocumentoRequestDTO request)
        {
            var response = new RegistraDocumentoResponseDTO();
            try
            {
                response = (new DocumentoBL()).RegistraDocumento(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaDocumentoDTO ConsultarDocumento(RequestConsultarDocumentoDTO request)
        {
            var response = new ResponseConsultaDocumentoDTO();
            try
            {
                response = (new DocumentoBL()).ConsultarDocumento(request);
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
        public RegistraPersonaResponseDTO RegistrarPersona(RegistraPersonaRequestDTO request)
        {
            var response = new RegistraPersonaResponseDTO();
            try
            {
                response = (new PersonaBL()).RegistraPersona(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaPersonaDTO ConsultarPersona(RequestConsultarPersonaDTO request)
        {
            var response = new ResponseConsultaPersonaDTO();
            try
            {
                response = (new PersonaBL()).ConsultarPersona(request);
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
        public ConsultaDetallePersonaResponseDTO ConsultarDetallePersona(ConsultaDetallePersonaRequestDTO request)
        {
            var response = new ConsultaDetallePersonaResponseDTO();
            try
            {
                response = (new PersonaBL()).ConsultarDetallePersona(request);
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
        public ConsultaDetalleDocumentoResponseDTO ConsultarDetalleDocumento(ConsultaDetalleDocumentoRequestDTO request)
        {
            var response = new ConsultaDetalleDocumentoResponseDTO();
            try
            {
                response = (new DocumentoBL()).ConsultarDetalleDocumento(request);
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
