using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TRAMARSA.TRANSMISIONES.DTO;
using TRAMARSA.TRANSMISIONES.DTO.Aduana.Request;
using TRAMARSA.TRANSMISIONES.DTO.Aduana.Response;
using TRAMARSA.TRANSMISIONES.DTO.ClaseIMO.Request;
using TRAMARSA.TRANSMISIONES.DTO.ClaseIMO.Response;
using TRAMARSA.TRANSMISIONES.DTO.CondicionCarga.Request;
using TRAMARSA.TRANSMISIONES.DTO.CondicionCarga.Response;
using TRAMARSA.TRANSMISIONES.DTO.CondicionContrato.Request;
using TRAMARSA.TRANSMISIONES.DTO.CondicionContrato.Response;
using TRAMARSA.TRANSMISIONES.DTO.CondicionPrecinto.Request;
using TRAMARSA.TRANSMISIONES.DTO.CondicionPrecinto.Response;
using TRAMARSA.TRANSMISIONES.DTO.CondicionTransporte.Request;
using TRAMARSA.TRANSMISIONES.DTO.CondicionTransporte.Response;
using TRAMARSA.TRANSMISIONES.DTO.Contenedor.Request;
using TRAMARSA.TRANSMISIONES.DTO.Contenedor.Response;
using TRAMARSA.TRANSMISIONES.DTO.EntidadPrecinto.Request;
using TRAMARSA.TRANSMISIONES.DTO.EntidadPrecinto.Response;
using TRAMARSA.TRANSMISIONES.DTO.Itinerario.Request;
using TRAMARSA.TRANSMISIONES.DTO.Itinerario.Response;
using TRAMARSA.TRANSMISIONES.DTO.LineaNaviera.Request;
using TRAMARSA.TRANSMISIONES.DTO.LineaNaviera.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.CondicionesCarga.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.CondicionesContrato.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.CondicionesTransporte.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.ModosPago.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.PersonaxRol.Request;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.PersonaxRol.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.Roles.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.Temperaturas.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposBL.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposEnvio.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposOperacion.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposTransmision.Response;
using TRAMARSA.TRANSMISIONES.DTO.MedioTransporte.Request;
using TRAMARSA.TRANSMISIONES.DTO.MedioTransporte.Response;
using TRAMARSA.TRANSMISIONES.DTO.ModoPago.Request;
using TRAMARSA.TRANSMISIONES.DTO.ModoPago.Response;
using TRAMARSA.TRANSMISIONES.DTO.Moneda.Request;
using TRAMARSA.TRANSMISIONES.DTO.Moneda.Response;
using TRAMARSA.TRANSMISIONES.DTO.NaturalezaCarga.Request;
using TRAMARSA.TRANSMISIONES.DTO.NaturalezaCarga.Response;
using TRAMARSA.TRANSMISIONES.DTO.Nave.Request;
using TRAMARSA.TRANSMISIONES.DTO.Nave.Response;
using TRAMARSA.TRANSMISIONES.DTO.NumeroIMO.Request;
using TRAMARSA.TRANSMISIONES.DTO.NumeroIMO.Response;
using TRAMARSA.TRANSMISIONES.DTO.Pais.Request;
using TRAMARSA.TRANSMISIONES.DTO.Pais.Response;
using TRAMARSA.TRANSMISIONES.DTO.Precinto.Request;
using TRAMARSA.TRANSMISIONES.DTO.Precinto.Response;
using TRAMARSA.TRANSMISIONES.DTO.Puerto.Request;
using TRAMARSA.TRANSMISIONES.DTO.Puerto.Response;
using TRAMARSA.TRANSMISIONES.DTO.RequerimientoServicio.Request;
using TRAMARSA.TRANSMISIONES.DTO.RequerimientoServicio.Response;
using TRAMARSA.TRANSMISIONES.DTO.Rol.Request;
using TRAMARSA.TRANSMISIONES.DTO.Rol.Response;
using TRAMARSA.TRANSMISIONES.DTO.Temperatura.Request;
using TRAMARSA.TRANSMISIONES.DTO.Temperatura.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoBL.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoBL.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoContenedor.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoContenedor.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoDocumento.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoDocumento.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoEnvio.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoEnvio.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoFlete.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoFlete.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoLugarCarga.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoLugarCarga.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoMovimiento.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoMovimiento.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoNave.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoNave.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoOperacion.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoOperacion.Response;
using TRAMARSA.TRANSMISIONES.DTO.UnidadMercancia.Request;
using TRAMARSA.TRANSMISIONES.DTO.UnidadMercancia.Response;
using TRAMARSA.TRANSMISIONES.DTO.ViaTransporte.Request;
using TRAMARSA.TRANSMISIONES.DTO.ViaTransporte.Response;
using TRAMARSA.TRANSMISIONES.Framework;
using TRAMARSA.TRANSMISIONES.LogicaNegocio;

namespace TRAMARSA.TRANSMISIONES.ServicioWCF.Maestros
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "MaestroServicio" en el código y en el archivo de configuración a la vez.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class MaestroServicio : IMaestroServicio
    {
        [Log]
        public ConsultaRolesResponseDTO ConsultaRoles()
        {
            ConsultaRolesResponseDTO response = new ConsultaRolesResponseDTO();
            try
            {
                MaestrosBL maestrosBL = new MaestrosBL();
                response = maestrosBL.ConsultaRoles();
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }

            return response;
        }

        [Log]
        public ConsultaTiposBLResponseDTO ConsultaTiposBL()
        {
            ConsultaTiposBLResponseDTO response = new ConsultaTiposBLResponseDTO();
            try
            {
                MaestrosBL maestrosBL = new MaestrosBL();
                response = maestrosBL.ConsultaTiposBL();
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }

            return response;
        }

        [Log]
        public ConsultaCondicionesCargaResponseDTO ConsultaCondicionesCarga()
        {
            ConsultaCondicionesCargaResponseDTO response = new ConsultaCondicionesCargaResponseDTO();
            try
            {
                MaestrosBL maestrosBL = new MaestrosBL();
                response = maestrosBL.ConsultaCondicionesCarga();
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }

            return response;
        }

        [Log]
        public ConsultaTemperaturasResponseDTO ConsultaTemperaturas()
        {
            ConsultaTemperaturasResponseDTO response = new ConsultaTemperaturasResponseDTO();
            try
            {
                MaestrosBL maestrosBL = new MaestrosBL();
                response = maestrosBL.ConsultaTemperaturas();
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }

            return response;
        }

        [Log]
        public ConsultaCondicionesTransporteResponseDTO ConsultaCondicionesTransporte()
        {
            ConsultaCondicionesTransporteResponseDTO response = new ConsultaCondicionesTransporteResponseDTO();
            try
            {
                MaestrosBL maestrosBL = new MaestrosBL();
                response = maestrosBL.ConsultaCondicionesTransporte();
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }

            return response;
        }

        [Log]
        public ConsultaModosPagoResponseDTO ConsultaModosPago()
        {
            ConsultaModosPagoResponseDTO response = new ConsultaModosPagoResponseDTO();
            try
            {
                MaestrosBL maestrosBL = new MaestrosBL();
                response = maestrosBL.ConsultaModosPago();
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }

            return response;
        }

        [Log]
        public ConsultaTiposTransmisionNaveResponseDTO ConsultaTiposTransmisionNave()
        {
            ConsultaTiposTransmisionNaveResponseDTO response = new ConsultaTiposTransmisionNaveResponseDTO();
            try
            {
                MaestrosBL maestrosBL = new MaestrosBL();
                response = maestrosBL.ConsultaTiposTransmisionNave();
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }

            return response;
        }

        [Log]
        public ConsultaTiposTransmisionDocumentoResponseDTO ConsultaTiposTransmisionDocumento()
        {
            ConsultaTiposTransmisionDocumentoResponseDTO response = new ConsultaTiposTransmisionDocumentoResponseDTO();
            try
            {
                MaestrosBL maestrosBL = new MaestrosBL();
                response = maestrosBL.ConsultaTiposTransmisionDocumento();
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }

            return response;
        }

        [Log]
        public ConsultaCondicionesContratoResponseDTO ConsultaCondicionesContrato()
        {
            ConsultaCondicionesContratoResponseDTO response = new ConsultaCondicionesContratoResponseDTO();
            try
            {
                MaestrosBL maestrosBL = new MaestrosBL();
                response = maestrosBL.ConsultaCondicionesContrato();
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }

            return response;
        }

        [Log]
        public ConsultaTiposEnvioResponseDTO ConsultaTiposEnvio()
        {
            ConsultaTiposEnvioResponseDTO response = new ConsultaTiposEnvioResponseDTO();
            try
            {
                MaestrosBL maestrosBL = new MaestrosBL();
                response = maestrosBL.ConsultaTiposEnvio();
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }

            return response;
        }

        [Log]
        public ConsultaTiposOperacionResponseDTO ConsultaTiposOperacion()
        {
            ConsultaTiposOperacionResponseDTO response = new ConsultaTiposOperacionResponseDTO();
            try
            {
                MaestrosBL maestrosBL = new MaestrosBL();
                response = maestrosBL.ConsultaTiposOperacion();
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }

            return response;
        }

        [Log]
        public ResponseRegistraPaisDTO RegistrarPais(RequestRegistraPaisDTO request)
        {
            var response = new ResponseRegistraPaisDTO();
            try
            {
                response = (new MaestrosBL()).RegistroPais(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaPaisDTO ConsultarPais(RequestConsultarPaisDTO request)
        {
            var response = new ResponseConsultaPaisDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarPais(request);
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
        public ResponseConsultaPuertoDTO ConsultarPuerto(RequestConsultarPuertoDTO request)
        {
            var response = new ResponseConsultaPuertoDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarPuerto(request);
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
        public ResponseRegistraPuertoDTO RegistrarPuerto(RequestRegistraPuertoDTO request)
        {
            var response = new ResponseRegistraPuertoDTO();
            try
            {
                response = (new MaestrosBL()).RegistroPuerto(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseRegistraTipoNaveDTO RegistrarTipoNave(RequestRegistraTipoNaveDTO request)
        {
            var response = new ResponseRegistraTipoNaveDTO();
            try
            {
                response = (new MaestrosBL()).RegistroTipoNave(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaTipoNaveDTO ConsultarTipoNave(RequestConsultarTipoNaveDTO request)
        {
            var response = new ResponseConsultaTipoNaveDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarTipoNave(request);
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
        public ResponseRegistraViaTransporteDTO RegistrarViaTransporte(RequestRegistraViaTransporteDTO request)
        {
            var response = new ResponseRegistraViaTransporteDTO();
            try
            {
                response = (new MaestrosBL()).RegistroViaTransporte(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaViaTransporteDTO ConsultarViaTransporte(RequestConsultarViaTransporteDTO request)
        {
            var response = new ResponseConsultaViaTransporteDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarViaTransporte(request);
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
        public ResponseRegistraAduanaDTO RegistrarAduana(RequestRegistraAduanaDTO request)
        {
            var response = new ResponseRegistraAduanaDTO();
            try
            {
                response = (new MaestrosBL()).RegistroAduana(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaAduanaDTO ConsultarAduana(RequestConsultarAduanaDTO request)
        {
            var response = new ResponseConsultaAduanaDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarAduana(request);
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
        public ResponseRegistraTipoLugarCargaDTO RegistrarTipoLugarCarga(RequestRegistraTipoLugarCargaDTO request)
        {
            var response = new ResponseRegistraTipoLugarCargaDTO();
            try
            {
                response = (new MaestrosBL()).RegistroTipoLugarCarga(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaTipoLugarCargaDTO ConsultarTipoLugarCarga(RequestConsultarTipoLugarCargaDTO request)
        {
            var response = new ResponseConsultaTipoLugarCargaDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarTipoLugarCarga(request);
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
        public ResponseRegistraMedioTransporteDTO RegistrarMedioTransporte(RequestRegistraMedioTransporteDTO request)
        {
            var response = new ResponseRegistraMedioTransporteDTO();
            try
            {
                response = (new MaestrosBL()).RegistroMedioTransporte(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaMedioTransporteDTO ConsultarMedioTransporte(RequestConsultarMedioTransporteDTO request)
        {
            var response = new ResponseConsultaMedioTransporteDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarMedioTransporte(request);
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
        public ResponseRegistraLineaNavieraDTO RegistrarLineaNaviera(RequestRegistraLineaNavieraDTO request)
        {
            var response = new ResponseRegistraLineaNavieraDTO();
            try
            {
                response = (new MaestrosBL()).RegistroLineaNaviera(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaLineaNavieraDTO ConsultarLineaNaviera(RequestConsultarLineaNavieraDTO request)
        {
            var response = new ResponseConsultaLineaNavieraDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarLineaNaviera(request);
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
        public ResponseRegistraNaveDTO RegistrarNave(RequestRegistraNaveDTO request)
        {
            var response = new ResponseRegistraNaveDTO();
            try
            {
                response = (new MaestrosBL()).RegistroNave(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaNaveDTO ConsultarNave(RequestConsultarNaveDTO request)
        {
            var response = new ResponseConsultaNaveDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarNave(request);
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
        public ResponseRegistraRolDTO RegistrarRol(RequestRegistraRolDTO request)
        {
            var response = new ResponseRegistraRolDTO();
            try
            {
                response = (new MaestrosBL()).RegistroRol(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaRolDTO ConsultarRol(RequestConsultarRolDTO request)
        {
            var response = new ResponseConsultaRolDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarRol(request);
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
        public ResponseRegistraTipoDocumentoDTO RegistrarTipoDocumento(RequestRegistraTipoDocumentoDTO request)
        {
            var response = new ResponseRegistraTipoDocumentoDTO();
            try
            {
                response = (new MaestrosBL()).RegistroTipoDocumento(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaTipoDocumentoDTO ConsultarTipoDocumento(RequestConsultarTipoDocumentoDTO request)
        {
            var response = new ResponseConsultaTipoDocumentoDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarTipoDocumento(request);
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
        public ResponseRegistraTipoOperacionDTO RegistrarTipoOperacion(RequestRegistraTipoOperacionDTO request)
        {
            var response = new ResponseRegistraTipoOperacionDTO();
            try
            {
                response = (new MaestrosBL()).RegistroTipoOperacion(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaTipoOperacionDTO ConsultarTipoOperacion(RequestConsultarTipoOperacionDTO request)
        {
            var response = new ResponseConsultaTipoOperacionDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarTipoOperacion(request);
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
        public ResponseRegistraItinerarioDTO RegistrarItinerario(RequestRegistraItinerarioDTO request)
        {
            var response = new ResponseRegistraItinerarioDTO();
            try
            {
                response = (new MaestrosBL()).RegistroItinerario(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaItinerarioDTO ConsultarItinerario(RequestConsultarItinerarioDTO request)
        {
            var response = new ResponseConsultaItinerarioDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarItinerario(request);
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
        public ResponseRegistraCondicionPrecintoDTO RegistrarCondicionPrecinto(RequestRegistraCondicionPrecintoDTO request)
        {
            var response = new ResponseRegistraCondicionPrecintoDTO();
            try
            {
                response = (new MaestrosBL()).RegistroCondicionPrecinto(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaCondicionPrecintoDTO ConsultarCondicionPrecinto(RequestConsultarCondicionPrecintoDTO request)
        {
            var response = new ResponseConsultaCondicionPrecintoDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarCondicionPrecinto(request);
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
        public ResponseRegistraEntidadPrecintoDTO RegistrarEntidadPrecinto(RequestRegistraEntidadPrecintoDTO request)
        {
            var response = new ResponseRegistraEntidadPrecintoDTO();
            try
            {
                response = (new MaestrosBL()).RegistroEntidadPrecinto(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaEntidadPrecintoDTO ConsultarEntidadPrecinto(RequestConsultarEntidadPrecintoDTO request)
        {
            var response = new ResponseConsultaEntidadPrecintoDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarEntidadPrecinto(request);
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
        public ResponseRegistraPrecintoDTO RegistrarPrecinto(RequestRegistraPrecintoDTO request)
        {
            var response = new ResponseRegistraPrecintoDTO();
            try
            {
                response = (new MaestrosBL()).RegistroPrecinto(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaPrecintoDTO ConsultarPrecinto(RequestConsultarPrecintoDTO request)
        {
            var response = new ResponseConsultaPrecintoDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarPrecinto(request);
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
        public ResponseRegistraMonedaDTO RegistrarMoneda(RequestRegistraMonedaDTO request)
        {
            var response = new ResponseRegistraMonedaDTO();
            try
            {
                response = (new MaestrosBL()).RegistroMoneda(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaMonedaDTO ConsultarMoneda(RequestConsultarMonedaDTO request)
        {
            var response = new ResponseConsultaMonedaDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarMoneda(request);
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
        public ResponseRegistraTipoEnvioDTO RegistrarTipoEnvio(RequestRegistraTipoEnvioDTO request)
        {
            var response = new ResponseRegistraTipoEnvioDTO();
            try
            {
                response = (new MaestrosBL()).RegistroTipoEnvio(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaTipoEnvioDTO ConsultarTipoEnvio(RequestConsultarTipoEnvioDTO request)
        {
            var response = new ResponseConsultaTipoEnvioDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarTipoEnvio(request);
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
        public ResponseRegistraCondicionContratoDTO RegistrarCondicionContrato(RequestRegistraCondicionContratoDTO request)
        {
            var response = new ResponseRegistraCondicionContratoDTO();
            try
            {
                response = (new MaestrosBL()).RegistroCondicionContrato(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaCondicionContratoDTO ConsultarCondicionContrato(RequestConsultarCondicionContratoDTO request)
        {
            var response = new ResponseConsultaCondicionContratoDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarCondicionContrato(request);
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
        public ResponseRegistraRequerimientoServicioDTO RegistrarRequerimientoServicio(RequestRegistraRequerimientoServicioDTO request)
        {
            var response = new ResponseRegistraRequerimientoServicioDTO();
            try
            {
                response = (new MaestrosBL()).RegistroRequerimientoServicio(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaRequerimientoServicioDTO ConsultarRequerimientoServicio(RequestConsultarRequerimientoServicioDTO request)
        {
            var response = new ResponseConsultaRequerimientoServicioDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarRequerimientoServicio(request);
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
        public ResponseRegistraTipoBLDTO RegistrarTipoBL(RequestRegistraTipoBLDTO request)
        {
            var response = new ResponseRegistraTipoBLDTO();
            try
            {
                response = (new MaestrosBL()).RegistroTipoBL(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaTipoBLDTO ConsultarTipoBL(RequestConsultarTipoBLDTO request)
        {
            var response = new ResponseConsultaTipoBLDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarTipoBL(request);
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
        public ResponseRegistraTipoFleteDTO RegistrarTipoFlete(RequestRegistraTipoFleteDTO request)
        {
            var response = new ResponseRegistraTipoFleteDTO();
            try
            {
                response = (new MaestrosBL()).RegistroTipoFlete(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaTipoFleteDTO ConsultarTipoFlete(RequestConsultarTipoFleteDTO request)
        {
            var response = new ResponseConsultaTipoFleteDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarTipoFlete(request);
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
        public ResponseRegistraModoPagoDTO RegistrarModoPago(RequestRegistraModoPagoDTO request)
        {
            var response = new ResponseRegistraModoPagoDTO();
            try
            {
                response = (new MaestrosBL()).RegistroModoPago(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaModoPagoDTO ConsultarModoPago(RequestConsultarModoPagoDTO request)
        {
            var response = new ResponseConsultaModoPagoDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarModoPago(request);
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
            };
        }

        [Log]
        public ResponseRegistraTipoContenedorDTO RegistrarTipoContenedor(RequestRegistraTipoContenedorDTO request)
        {
            var response = new ResponseRegistraTipoContenedorDTO();
            try
            {
                response = (new MaestrosBL()).RegistroTipoContenedor(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaTipoContenedorDTO ConsultarTipoContenedor(RequestConsultarTipoContenedorDTO request)
        {
            var response = new ResponseConsultaTipoContenedorDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarTipoContenedor(request);
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
        public ResponseRegistraTemperaturaDTO RegistrarTemperatura(RequestRegistraTemperaturaDTO request)
        {
            var response = new ResponseRegistraTemperaturaDTO();
            try
            {
                response = (new MaestrosBL()).RegistroTemperatura(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaTemperaturaDTO ConsultarTemperatura(RequestConsultarTemperaturaDTO request)
        {
            var response = new ResponseConsultaTemperaturaDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarTemperatura(request);
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
        public ResponseRegistraCondicionTransporteDTO RegistrarCondicionTransporte(RequestRegistraCondicionTransporteDTO request)
        {
            var response = new ResponseRegistraCondicionTransporteDTO();
            try
            {
                response = (new MaestrosBL()).RegistroCondicionTransporte(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaCondicionTransporteDTO ConsultarCondicionTransporte(RequestConsultarCondicionTransporteDTO request)
        {
            var response = new ResponseConsultaCondicionTransporteDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarCondicionTransporte(request);
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
        public ResponseRegistraTipoMovimientoDTO RegistrarTipoMovimiento(RequestRegistraTipoMovimientoDTO request)
        {
            var response = new ResponseRegistraTipoMovimientoDTO();
            try
            {
                response = (new MaestrosBL()).RegistroTipoMovimiento(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaTipoMovimientoDTO ConsultarTipoMovimiento(RequestConsultarTipoMovimientoDTO request)
        {
            var response = new ResponseConsultaTipoMovimientoDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarTipoMovimiento(request);
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
        public ResponseRegistraUnidadMercanciaDTO RegistrarUnidadMercancia(RequestRegistraUnidadMercanciaDTO request)
        {
            var response = new ResponseRegistraUnidadMercanciaDTO();
            try
            {
                response = (new MaestrosBL()).RegistroUnidadMercancia(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaUnidadMercanciaDTO ConsultarUnidadMercancia(RequestConsultarUnidadMercanciaDTO request)
        {
            var response = new ResponseConsultaUnidadMercanciaDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarUnidadMercancia(request);
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
        public ResponseRegistraCondicionCargaDTO RegistrarCondicionCarga(RequestRegistraCondicionCargaDTO request)
        {
            var response = new ResponseRegistraCondicionCargaDTO();
            try
            {
                response = (new MaestrosBL()).RegistroCondicionCarga(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaCondicionCargaDTO ConsultarCondicionCarga(RequestConsultarCondicionCargaDTO request)
        {
            var response = new ResponseConsultaCondicionCargaDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarCondicionCarga(request);
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
            };
        }

        [Log]
        public ResponseRegistraNaturalezaCargaDTO RegistrarNaturalezaCarga(RequestRegistraNaturalezaCargaDTO request)
        {
            var response = new ResponseRegistraNaturalezaCargaDTO();
            try
            {
                response = (new MaestrosBL()).RegistroNaturalezaCarga(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaNaturalezaCargaDTO ConsultarNaturalezaCarga(RequestConsultarNaturalezaCargaDTO request)
        {
            var response = new ResponseConsultaNaturalezaCargaDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarNaturalezaCarga(request);
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
        public ResponseRegistraClaseIMODTO RegistrarClaseIMO(RequestRegistraClaseIMODTO request)
        {
            var response = new ResponseRegistraClaseIMODTO();
            try
            {
                response = (new MaestrosBL()).RegistroClaseIMO(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaClaseIMODTO ConsultarClaseIMO(RequestConsultarClaseIMODTO request)
        {
            var response = new ResponseConsultaClaseIMODTO();
            try
            {
                response = (new MaestrosBL()).ConsultarClaseIMO(request);
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
        public ResponseRegistraNumeroIMODTO RegistrarNumeroIMO(RequestRegistraNumeroIMODTO request)
        {
            var response = new ResponseRegistraNumeroIMODTO();
            try
            {
                response = (new MaestrosBL()).RegistroNumeroIMO(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaNumeroIMODTO ConsultarNumeroIMO(RequestConsultarNumeroIMODTO request)
        {
            var response = new ResponseConsultaNumeroIMODTO();
            try
            {
                response = (new MaestrosBL()).ConsultarNumeroIMO(request);
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
        public ResponseRegistraContenedorDTO RegistrarContenedor(RequestRegistraContenedorDTO request)
        {
            var response = new ResponseRegistraContenedorDTO();
            try
            {
                response = (new MaestrosBL()).RegistroContenedor(request);
            }
            catch (Exception ex)
            {
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.ServicioWCF);
            }
            return response;
        }

        [Log]
        public ResponseConsultaContenedorDTO ConsultarContenedor(RequestConsultarContenedorDTO request)
        {
            var response = new ResponseConsultaContenedorDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarContenedor(request);
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
        public ResponseConsultaPersonaxRolDTO ConsultarPersonaxRol(RequestConsultarPersonaxRolDTO request)
        {
            var response = new ResponseConsultaPersonaxRolDTO();
            try
            {
                response = (new MaestrosBL()).ConsultarPersonaxRol(request);
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
