using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
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

namespace TRAMARSA.TRANSMISIONES.ServicioWCF.Maestros
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMaestroServicio" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMaestroServicio
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultaRoles", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ConsultaRolesResponseDTO ConsultaRoles();

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultaCondicionesContrato", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ConsultaCondicionesContratoResponseDTO ConsultaCondicionesContrato();

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultaTiposBL", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ConsultaTiposBLResponseDTO ConsultaTiposBL();

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultaCondicionesCarga", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ConsultaCondicionesCargaResponseDTO ConsultaCondicionesCarga();

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultaTemperaturas", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ConsultaTemperaturasResponseDTO ConsultaTemperaturas();

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultaCondicionesTransporte", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ConsultaCondicionesTransporteResponseDTO ConsultaCondicionesTransporte();

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultaModosPago", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ConsultaModosPagoResponseDTO ConsultaModosPago();

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultaTiposTransmisionNave", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ConsultaTiposTransmisionNaveResponseDTO ConsultaTiposTransmisionNave();

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultaTiposTransmisionDocumento", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ConsultaTiposTransmisionDocumentoResponseDTO ConsultaTiposTransmisionDocumento();

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultaTiposEnvio", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ConsultaTiposEnvioResponseDTO ConsultaTiposEnvio();

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultaTiposOperacion", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ConsultaTiposOperacionResponseDTO ConsultaTiposOperacion();

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarPais", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraPaisDTO RegistrarPais(RequestRegistraPaisDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarPais", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaPaisDTO ConsultarPais(RequestConsultarPaisDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarPuerto", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraPuertoDTO RegistrarPuerto(RequestRegistraPuertoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarPuerto", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaPuertoDTO ConsultarPuerto(RequestConsultarPuertoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarTipoNave", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraTipoNaveDTO RegistrarTipoNave(RequestRegistraTipoNaveDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarTipoNave", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaTipoNaveDTO ConsultarTipoNave(RequestConsultarTipoNaveDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarViaTransporte", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraViaTransporteDTO RegistrarViaTransporte(RequestRegistraViaTransporteDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarViaTransporte", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaViaTransporteDTO ConsultarViaTransporte(RequestConsultarViaTransporteDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarAduana", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraAduanaDTO RegistrarAduana(RequestRegistraAduanaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarAduana", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaAduanaDTO ConsultarAduana(RequestConsultarAduanaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarTipoLugarCarga", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraTipoLugarCargaDTO RegistrarTipoLugarCarga(RequestRegistraTipoLugarCargaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarTipoLugarCarga", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaTipoLugarCargaDTO ConsultarTipoLugarCarga(RequestConsultarTipoLugarCargaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarMedioTransporte", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraMedioTransporteDTO RegistrarMedioTransporte(RequestRegistraMedioTransporteDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarMedioTransporte", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaMedioTransporteDTO ConsultarMedioTransporte(RequestConsultarMedioTransporteDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarLineaNaviera", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraLineaNavieraDTO RegistrarLineaNaviera(RequestRegistraLineaNavieraDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarLineaNaviera", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaLineaNavieraDTO ConsultarLineaNaviera(RequestConsultarLineaNavieraDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarNave", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraNaveDTO RegistrarNave(RequestRegistraNaveDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarNave", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaNaveDTO ConsultarNave(RequestConsultarNaveDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarRol", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraRolDTO RegistrarRol(RequestRegistraRolDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarRol", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaRolDTO ConsultarRol(RequestConsultarRolDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarTipoDocumento", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraTipoDocumentoDTO RegistrarTipoDocumento(RequestRegistraTipoDocumentoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarTipoDocumento", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaTipoDocumentoDTO ConsultarTipoDocumento(RequestConsultarTipoDocumentoDTO request);

        //[OperationContract]
        //[WebInvoke(UriTemplate = "/RegistrarPersona", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //ResponseRegistraPersonaDTO RegistrarPersona(RequestRegistraPersonaDTO request);

        //[OperationContract]
        //[WebInvoke(UriTemplate = "/ConsultarPersona", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //ResponseConsultaPersonaDTO ConsultarPersona(RequestConsultarPersonaDTO request);

        //[OperationContract]
        //[WebInvoke(UriTemplate = "/RegistrarRolPersona", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //ResponseRegistraRolPersonaDTO RegistrarRolPersona(RequestRegistraRolPersonaDTO request);

        //[OperationContract]
        //[WebInvoke(UriTemplate = "/ConsultarRolPersona", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //ResponseConsultaRolPersonaDTO ConsultarRolPersona(RequestConsultarRolPersonaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarTipoOperacion", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraTipoOperacionDTO RegistrarTipoOperacion(RequestRegistraTipoOperacionDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarTipoOperacion", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaTipoOperacionDTO ConsultarTipoOperacion(RequestConsultarTipoOperacionDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarItinerario", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraItinerarioDTO RegistrarItinerario(RequestRegistraItinerarioDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarItinerario", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaItinerarioDTO ConsultarItinerario(RequestConsultarItinerarioDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarCondicionPrecinto", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraCondicionPrecintoDTO RegistrarCondicionPrecinto(RequestRegistraCondicionPrecintoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarCondicionPrecinto", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaCondicionPrecintoDTO ConsultarCondicionPrecinto(RequestConsultarCondicionPrecintoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarEntidadPrecinto", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraEntidadPrecintoDTO RegistrarEntidadPrecinto(RequestRegistraEntidadPrecintoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarEntidadPrecinto", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaEntidadPrecintoDTO ConsultarEntidadPrecinto(RequestConsultarEntidadPrecintoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarPrecinto", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraPrecintoDTO RegistrarPrecinto(RequestRegistraPrecintoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarPrecinto", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaPrecintoDTO ConsultarPrecinto(RequestConsultarPrecintoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarMoneda", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraMonedaDTO RegistrarMoneda(RequestRegistraMonedaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarMoneda", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaMonedaDTO ConsultarMoneda(RequestConsultarMonedaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarTipoEnvio", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraTipoEnvioDTO RegistrarTipoEnvio(RequestRegistraTipoEnvioDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarTipoEnvio", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaTipoEnvioDTO ConsultarTipoEnvio(RequestConsultarTipoEnvioDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarCondicionContrato", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraCondicionContratoDTO RegistrarCondicionContrato(RequestRegistraCondicionContratoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarCondicionContrato", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaCondicionContratoDTO ConsultarCondicionContrato(RequestConsultarCondicionContratoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarRequerimientoServicio", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraRequerimientoServicioDTO RegistrarRequerimientoServicio(RequestRegistraRequerimientoServicioDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarRequerimientoServicio", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaRequerimientoServicioDTO ConsultarRequerimientoServicio(RequestConsultarRequerimientoServicioDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarTipoBL", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraTipoBLDTO RegistrarTipoBL(RequestRegistraTipoBLDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarTipoBL", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaTipoBLDTO ConsultarTipoBL(RequestConsultarTipoBLDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarTipoFlete", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraTipoFleteDTO RegistrarTipoFlete(RequestRegistraTipoFleteDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarTipoFlete", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaTipoFleteDTO ConsultarTipoFlete(RequestConsultarTipoFleteDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarModoPago", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraModoPagoDTO RegistrarModoPago(RequestRegistraModoPagoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarModoPago", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaModoPagoDTO ConsultarModoPago(RequestConsultarModoPagoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarTipoContenedor", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraTipoContenedorDTO RegistrarTipoContenedor(RequestRegistraTipoContenedorDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarTipoContenedor", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaTipoContenedorDTO ConsultarTipoContenedor(RequestConsultarTipoContenedorDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarTemperatura", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraTemperaturaDTO RegistrarTemperatura(RequestRegistraTemperaturaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarTemperatura", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaTemperaturaDTO ConsultarTemperatura(RequestConsultarTemperaturaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarCondicionTransporte", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraCondicionTransporteDTO RegistrarCondicionTransporte(RequestRegistraCondicionTransporteDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarCondicionTransporte", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaCondicionTransporteDTO ConsultarCondicionTransporte(RequestConsultarCondicionTransporteDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarTipoMovimiento", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraTipoMovimientoDTO RegistrarTipoMovimiento(RequestRegistraTipoMovimientoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarTipoMovimiento", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaTipoMovimientoDTO ConsultarTipoMovimiento(RequestConsultarTipoMovimientoDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarUnidadMercancia", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraUnidadMercanciaDTO RegistrarUnidadMercancia(RequestRegistraUnidadMercanciaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarUnidadMercancia", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaUnidadMercanciaDTO ConsultarUnidadMercancia(RequestConsultarUnidadMercanciaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarCondicionCarga", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraCondicionCargaDTO RegistrarCondicionCarga(RequestRegistraCondicionCargaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarCondicionCarga", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaCondicionCargaDTO ConsultarCondicionCarga(RequestConsultarCondicionCargaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarNaturalezaCarga", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraNaturalezaCargaDTO RegistrarNaturalezaCarga(RequestRegistraNaturalezaCargaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarNaturalezaCarga", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaNaturalezaCargaDTO ConsultarNaturalezaCarga(RequestConsultarNaturalezaCargaDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarClaseIMO", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraClaseIMODTO RegistrarClaseIMO(RequestRegistraClaseIMODTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarClaseIMO", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaClaseIMODTO ConsultarClaseIMO(RequestConsultarClaseIMODTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarNumeroIMO", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraNumeroIMODTO RegistrarNumeroIMO(RequestRegistraNumeroIMODTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarNumeroIMO", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaNumeroIMODTO ConsultarNumeroIMO(RequestConsultarNumeroIMODTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RegistrarContenedor", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseRegistraContenedorDTO RegistrarContenedor(RequestRegistraContenedorDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarContenedor", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaContenedorDTO ConsultarContenedor(RequestConsultarContenedorDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarPersonaxRol", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseConsultaPersonaxRolDTO ConsultarPersonaxRol(RequestConsultarPersonaxRolDTO request);

    }
}
