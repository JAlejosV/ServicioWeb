using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAMARSA.TRANSMISIONES.AccesoDatos;
using TRAMARSA.TRANSMISIONES.DTO;
using TRAMARSA.TRANSMISIONES.DTO.Aduana;
using TRAMARSA.TRANSMISIONES.DTO.Aduana.Request;
using TRAMARSA.TRANSMISIONES.DTO.Aduana.Response;
using TRAMARSA.TRANSMISIONES.DTO.ClaseIMO;
using TRAMARSA.TRANSMISIONES.DTO.ClaseIMO.Request;
using TRAMARSA.TRANSMISIONES.DTO.ClaseIMO.Response;
using TRAMARSA.TRANSMISIONES.DTO.CondicionCarga;
using TRAMARSA.TRANSMISIONES.DTO.CondicionCarga.Request;
using TRAMARSA.TRANSMISIONES.DTO.CondicionCarga.Response;
using TRAMARSA.TRANSMISIONES.DTO.CondicionContrato;
using TRAMARSA.TRANSMISIONES.DTO.CondicionContrato.Request;
using TRAMARSA.TRANSMISIONES.DTO.CondicionContrato.Response;
using TRAMARSA.TRANSMISIONES.DTO.CondicionPrecinto;
using TRAMARSA.TRANSMISIONES.DTO.CondicionPrecinto.Request;
using TRAMARSA.TRANSMISIONES.DTO.CondicionPrecinto.Response;
using TRAMARSA.TRANSMISIONES.DTO.CondicionTransporte;
using TRAMARSA.TRANSMISIONES.DTO.CondicionTransporte.Request;
using TRAMARSA.TRANSMISIONES.DTO.CondicionTransporte.Response;
using TRAMARSA.TRANSMISIONES.DTO.Contenedor;
using TRAMARSA.TRANSMISIONES.DTO.Contenedor.Request;
using TRAMARSA.TRANSMISIONES.DTO.Contenedor.Response;
using TRAMARSA.TRANSMISIONES.DTO.EntidadPrecinto;
using TRAMARSA.TRANSMISIONES.DTO.EntidadPrecinto.Request;
using TRAMARSA.TRANSMISIONES.DTO.EntidadPrecinto.Response;
using TRAMARSA.TRANSMISIONES.DTO.Itinerario;
using TRAMARSA.TRANSMISIONES.DTO.Itinerario.Request;
using TRAMARSA.TRANSMISIONES.DTO.Itinerario.Response;
using TRAMARSA.TRANSMISIONES.DTO.LineaNaviera;
using TRAMARSA.TRANSMISIONES.DTO.LineaNaviera.Request;
using TRAMARSA.TRANSMISIONES.DTO.LineaNaviera.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.CondicionesCarga;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.CondicionesCarga.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.CondicionesContrato;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.CondicionesContrato.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.CondicionesTransporte;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.CondicionesTransporte.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.ModosPago;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.ModosPago.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.PersonaxRol;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.PersonaxRol.Request;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.PersonaxRol.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.Roles.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.Temperaturas;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.Temperaturas.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposBL;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposBL.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposEnvio;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposEnvio.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposOperacion;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposOperacion.Response;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposTransmision;
using TRAMARSA.TRANSMISIONES.DTO.Maestros.TiposTransmision.Response;
using TRAMARSA.TRANSMISIONES.DTO.MedioTransporte;
using TRAMARSA.TRANSMISIONES.DTO.MedioTransporte.Request;
using TRAMARSA.TRANSMISIONES.DTO.MedioTransporte.Response;
using TRAMARSA.TRANSMISIONES.DTO.ModoPago;
using TRAMARSA.TRANSMISIONES.DTO.ModoPago.Request;
using TRAMARSA.TRANSMISIONES.DTO.ModoPago.Response;
using TRAMARSA.TRANSMISIONES.DTO.Moneda;
using TRAMARSA.TRANSMISIONES.DTO.Moneda.Request;
using TRAMARSA.TRANSMISIONES.DTO.Moneda.Response;
using TRAMARSA.TRANSMISIONES.DTO.NaturalezaCarga;
using TRAMARSA.TRANSMISIONES.DTO.NaturalezaCarga.Request;
using TRAMARSA.TRANSMISIONES.DTO.NaturalezaCarga.Response;
using TRAMARSA.TRANSMISIONES.DTO.Nave;
using TRAMARSA.TRANSMISIONES.DTO.Nave.Request;
using TRAMARSA.TRANSMISIONES.DTO.Nave.Response;
using TRAMARSA.TRANSMISIONES.DTO.NumeroIMO;
using TRAMARSA.TRANSMISIONES.DTO.NumeroIMO.Request;
using TRAMARSA.TRANSMISIONES.DTO.NumeroIMO.Response;
using TRAMARSA.TRANSMISIONES.DTO.Pais;
using TRAMARSA.TRANSMISIONES.DTO.Pais.Request;
using TRAMARSA.TRANSMISIONES.DTO.Pais.Response;
using TRAMARSA.TRANSMISIONES.DTO.Precinto;
using TRAMARSA.TRANSMISIONES.DTO.Precinto.Request;
using TRAMARSA.TRANSMISIONES.DTO.Precinto.Response;
using TRAMARSA.TRANSMISIONES.DTO.Puerto;
using TRAMARSA.TRANSMISIONES.DTO.Puerto.Request;
using TRAMARSA.TRANSMISIONES.DTO.Puerto.Response;
using TRAMARSA.TRANSMISIONES.DTO.RequerimientoServicio;
using TRAMARSA.TRANSMISIONES.DTO.RequerimientoServicio.Request;
using TRAMARSA.TRANSMISIONES.DTO.RequerimientoServicio.Response;
using TRAMARSA.TRANSMISIONES.DTO.Rol;
using TRAMARSA.TRANSMISIONES.DTO.Rol.Request;
using TRAMARSA.TRANSMISIONES.DTO.Rol.Response;
using TRAMARSA.TRANSMISIONES.DTO.Temperatura;
using TRAMARSA.TRANSMISIONES.DTO.Temperatura.Request;
using TRAMARSA.TRANSMISIONES.DTO.Temperatura.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoBL;
using TRAMARSA.TRANSMISIONES.DTO.TipoBL.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoBL.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoContenedor;
using TRAMARSA.TRANSMISIONES.DTO.TipoContenedor.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoContenedor.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoDocumento;
using TRAMARSA.TRANSMISIONES.DTO.TipoDocumento.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoDocumento.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoEnvio;
using TRAMARSA.TRANSMISIONES.DTO.TipoEnvio.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoEnvio.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoFlete;
using TRAMARSA.TRANSMISIONES.DTO.TipoFlete.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoFlete.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoLugarCarga;
using TRAMARSA.TRANSMISIONES.DTO.TipoLugarCarga.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoLugarCarga.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoMovimiento;
using TRAMARSA.TRANSMISIONES.DTO.TipoMovimiento.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoMovimiento.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoNave;
using TRAMARSA.TRANSMISIONES.DTO.TipoNave.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoNave.Response;
using TRAMARSA.TRANSMISIONES.DTO.TipoOperacion;
using TRAMARSA.TRANSMISIONES.DTO.TipoOperacion.Request;
using TRAMARSA.TRANSMISIONES.DTO.TipoOperacion.Response;
using TRAMARSA.TRANSMISIONES.DTO.UnidadMercancia;
using TRAMARSA.TRANSMISIONES.DTO.UnidadMercancia.Request;
using TRAMARSA.TRANSMISIONES.DTO.UnidadMercancia.Response;
using TRAMARSA.TRANSMISIONES.DTO.ViaTransporte;
using TRAMARSA.TRANSMISIONES.DTO.ViaTransporte.Request;
using TRAMARSA.TRANSMISIONES.DTO.ViaTransporte.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Aduana.Request;
using TRAMARSA.TRANSMISIONES.Entidades.ClaseIMO.Request;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionCarga.Request;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionContrato.Request;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionPrecinto.Request;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionTransporte.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Constantes;
using TRAMARSA.TRANSMISIONES.Entidades.Contenedor.Request;
using TRAMARSA.TRANSMISIONES.Entidades.EntidadPrecinto.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Itinerario.Request;
using TRAMARSA.TRANSMISIONES.Entidades.LineaNaviera.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.CondicionCarga;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.CondicionContrato;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.CondicionTransporte;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.ModoPago;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.PersonaxRol.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.Rol;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.Temperatura;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.TipoBL;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.TipoEnvio;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.TipoOperacion;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.TipoTransmision;
using TRAMARSA.TRANSMISIONES.Entidades.MedioTransporte.Request;
using TRAMARSA.TRANSMISIONES.Entidades.ModoPago.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Moneda;
using TRAMARSA.TRANSMISIONES.Entidades.Moneda.Request;
using TRAMARSA.TRANSMISIONES.Entidades.NaturalezaCarga.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Nave.Request;
using TRAMARSA.TRANSMISIONES.Entidades.NumeroIMO.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Pais.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Precinto.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Puerto.Request;
using TRAMARSA.TRANSMISIONES.Entidades.RequerimientoServicio.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Rol;
using TRAMARSA.TRANSMISIONES.Entidades.Rol.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Temperatura.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoBL;
using TRAMARSA.TRANSMISIONES.Entidades.TipoBL.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoContenedor.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoDocumento.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoEnvio.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoFlete.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoLugarCarga.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoMovimiento.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoNave.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoOperacion.Request;
using TRAMARSA.TRANSMISIONES.Entidades.UnidadMercancia.Request;
using TRAMARSA.TRANSMISIONES.Entidades.ViaTransporte.Request;
using TRAMARSA.TRANSMISIONES.Framework;

namespace TRAMARSA.TRANSMISIONES.LogicaNegocio
{
    public class MaestrosBL
    {
        public ResponseRegistraPaisDTO RegistroPais(RequestRegistraPaisDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraPaisDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraPaisDTO, RequestRegistroPais>(requesDTO);
                var response = repo.RegistroPais(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaPaisDTO ConsultarPais(RequestConsultarPaisDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaPaisDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarPaisDTO, RequestConsultarPais>(requesDTO);
                var response = repo.ConsultarPais(requestBE);

                response.ListaPais.ForEach(x =>
                {

                    responseDTO.ListaPais.Add(new PaisDTO
                    {
                        CodigoAlfaPais = x.CodigoAlfaPais,
                        CodigoPais = x.CodigoPais,
                        CodigoPaisSunat = x.CodigoPaisSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombrePais = x.NombrePais,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = response.TotalRegistros;
                responseDTO.CantidadPaginas = response.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraAduanaDTO RegistroAduana(RequestRegistraAduanaDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraAduanaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraAduanaDTO, RequestRegistroAduana>(requesDTO);
                var response = repo.RegistroAduana(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaAduanaDTO ConsultarAduana(RequestConsultarAduanaDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaAduanaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarAduanaDTO, RequestConsultarAduana>(requesDTO);
                var resp = repo.ConsultarAduana(requestBE);

                resp.ListaAduana.ForEach(x =>
                {

                    responseDTO.ListaAduana.Add(new AduanaDTO
                    {
                        CodigoAduana = x.CodigoAduana,
                        CodigoAduanaSunat = x.CodigoAduanaSunat,
                        NombreAduana = x.NombreAduana,
                        CodigoPuerto = x.CodigoPuerto,
                        NombrePuerto = x.NombrePuerto,
                        CodigoViaTransporte = x.CodigoViaTransporte,
                        NombreViaTransporte = x.NombreViaTransporte,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraClaseIMODTO RegistroClaseIMO(RequestRegistraClaseIMODTO requesDTO)
        {
            var responseDTO = new ResponseRegistraClaseIMODTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraClaseIMODTO, RequestRegistroClaseIMO>(requesDTO);
                var response = repo.RegistroClaseIMO(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaClaseIMODTO ConsultarClaseIMO(RequestConsultarClaseIMODTO requesDTO)
        {
            var responseDTO = new ResponseConsultaClaseIMODTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarClaseIMODTO, RequestConsultarClaseIMO>(requesDTO);
                var resp = repo.ConsultarClaseIMO(requestBE);

                resp.ListaClaseIMO.ForEach(x =>
                {
                    responseDTO.ListaClaseIMO.Add(new ClaseIMODTO
                    {
                        CodigoClaseIMO = x.CodigoClaseIMO,
                        CodigoClaseIMOSunat = x.CodigoClaseIMOSunat,
                        NombreClaseIMO = x.NombreClaseIMO,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraCondicionCargaDTO RegistroCondicionCarga(RequestRegistraCondicionCargaDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraCondicionCargaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraCondicionCargaDTO, RequestRegistroCondicionCarga>(requesDTO);
                var response = repo.RegistroCondicionCarga(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaCondicionCargaDTO ConsultarCondicionCarga(RequestConsultarCondicionCargaDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaCondicionCargaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarCondicionCargaDTO, RequestConsultarCondicionCarga>(requesDTO);
                var resp = repo.ConsultarCondicionCarga(requestBE);

                resp.ListaCondicionCarga.ForEach(x =>
                {
                    responseDTO.ListaCondicionCarga.Add(new CondicionCargaDTO
                    {
                        CodigoCondicionCarga = x.CodigoCondicionCarga,
                        CodigoCondicionCargaSunat = x.CodigoCondicionCargaSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreCondicionCarga = x.NombreCondicionCarga,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });
                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraCondicionContratoDTO RegistroCondicionContrato(RequestRegistraCondicionContratoDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraCondicionContratoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraCondicionContratoDTO, RequestRegistroCondicionContrato>(requesDTO);
                var response = repo.RegistroCondicionContrato(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaCondicionContratoDTO ConsultarCondicionContrato(RequestConsultarCondicionContratoDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaCondicionContratoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarCondicionContratoDTO, RequestConsultarCondicionContrato>(requesDTO);
                var resp = repo.ConsultarCondicionContrato(requestBE);

                resp.ListaCondicionContrato.ForEach(x =>
                {
                    responseDTO.ListaCondicionContrato.Add(new CondicionContratoDTO
                    {
                        CodigoCondicionContrato = x.CodigoCondicionContrato,
                        CodigoCondicionContratoSunat = x.CodigoCondicionContratoSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreCondicionContrato = x.NombreCondicionContrato,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraCondicionPrecintoDTO RegistroCondicionPrecinto(RequestRegistraCondicionPrecintoDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraCondicionPrecintoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraCondicionPrecintoDTO, RequestRegistroCondicionPrecinto>(requesDTO);
                var response = repo.RegistroCondicionPrecinto(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaCondicionPrecintoDTO ConsultarCondicionPrecinto(RequestConsultarCondicionPrecintoDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaCondicionPrecintoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarCondicionPrecintoDTO, RequestConsultarCondicionPrecinto>(requesDTO);
                var resp = repo.ConsultarCondicionPrecinto(requestBE);

                resp.ListaCondicionPrecinto.ForEach(x =>
                {
                    responseDTO.ListaCondicionPrecinto.Add(new CondicionPrecintoDTO
                    {
                        CodigoCondicionPrecinto = x.CodigoCondicionPrecinto,
                        CodigoCondicionPrecintoSunat = x.CodigoCondicionPrecintoSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreCondicionPrecinto = x.NombreCondicionPrecinto,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraCondicionTransporteDTO RegistroCondicionTransporte(RequestRegistraCondicionTransporteDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraCondicionTransporteDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraCondicionTransporteDTO, RequestRegistroCondicionTransporte>(requesDTO);
                var response = repo.RegistroCondicionTransporte(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaCondicionTransporteDTO ConsultarCondicionTransporte(RequestConsultarCondicionTransporteDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaCondicionTransporteDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarCondicionTransporteDTO, RequestConsultarCondicionTransporte>(requesDTO);
                var resp = repo.ConsultarCondicionTransporte(requestBE);

                resp.ListaCondicionTransporte.ForEach(x =>
                {
                    responseDTO.ListaCondicionTransporte.Add(new CondicionTransporteDTO
                    {
                        CodigoCondicionTransporte = x.CodigoCondicionTransporte,
                        CodigoCondicionTransporteSunat = x.CodigoCondicionTransporteSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreCondicionTransporte = x.NombreCondicionTransporte,
                        CodigoAduanaCondicionTransporte = x.CodigoAduanaCondicionTransporte,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraContenedorDTO RegistroContenedor(RequestRegistraContenedorDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraContenedorDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraContenedorDTO, RequestRegistroContenedor>(requesDTO);
                var response = repo.RegistroContenedor(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaContenedorDTO ConsultarContenedor(RequestConsultarContenedorDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaContenedorDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarContenedorDTO, RequestConsultarContenedor>(requesDTO);
                var resp = repo.ConsultarContenedor(requestBE);

                resp.ListaContenedor.ForEach(x =>
                {

                    responseDTO.ListaContenedor.Add(new ContenedorDTO
                    {
                        CodigoContenedor = x.CodigoContenedor,
                        CodTipoContenedor = x.CodTipoContenedor,
                        TaraContenedor = x.TaraContenedor,
                        NumeroContenedor = x.NumeroContenedor,
                        NombreTipoContenedor = x.NombreTipoContenedor,
                        TamanioTipoContenedor = x.TamanioTipoContenedor,
                        CodigoTipoContenedor = x.CodigoTipoContenedor,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraEntidadPrecintoDTO RegistroEntidadPrecinto(RequestRegistraEntidadPrecintoDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraEntidadPrecintoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraEntidadPrecintoDTO, RequestRegistroEntidadPrecinto>(requesDTO);
                var response = repo.RegistroEntidadPrecinto(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaEntidadPrecintoDTO ConsultarEntidadPrecinto(RequestConsultarEntidadPrecintoDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaEntidadPrecintoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarEntidadPrecintoDTO, RequestConsultarEntidadPrecinto>(requesDTO);
                var resp = repo.ConsultarEntidadPrecinto(requestBE);

                resp.ListaEntidadPrecinto.ForEach(x =>
                {
                    responseDTO.ListaEntidadPrecinto.Add(new EntidadPrecintoDTO
                    {
                        CodigoEntidadPrecinto = x.CodigoEntidadPrecinto,
                        CodigoEntidadPrecintoSunat = x.CodigoEntidadPrecintoSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreEntidadPrecinto = x.NombreEntidadPrecinto,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraItinerarioDTO RegistroItinerario(RequestRegistraItinerarioDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraItinerarioDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraItinerarioDTO, RequestRegistroItinerario>(requesDTO);
                var response = repo.RegistroItinerario(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaItinerarioDTO ConsultarItinerario(RequestConsultarItinerarioDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaItinerarioDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarItinerarioDTO, RequestConsultarItinerario>(requesDTO);
                var resp = repo.ConsultarItinerario(requestBE);

                resp.ListaItinerario.ForEach(x =>
                {
                    responseDTO.ListaItinerario.Add(new ItinerarioDTO
                    {
                        CodigoItinerario = x.CodigoItinerario,
                        CodigoNave = x.CodigoNave,
                        NombreNave = x.NombreNave,
                        NumeroViajeItinerario = x.NumeroViajeItinerario,
                        CodigoAduana = x.CodigoAduana,
                        NombreAduana = x.NombreAduana,
                        CodigoTipoOperacion = x.CodigoTipoOperacion,
                        NombreTipoOperacion = x.NombreTipoOperacion,
                        CodigoTipoLugarCarga = x.CodigoTipoLugarCarga,
                        NombreTipoLugarCarga = x.NombreTipoLugarCarga,
                        CodigoOperadorEmbarqueItinerario = x.CodigoOperadorEmbarqueItinerario,
                        NombreOperadorEmbarqueItinerario = x.NombreOperadorEmbarqueItinerario,
                        CodigoOperadorDescargaItinerario = x.CodigoOperadorDescargaItinerario,
                        NombreOperadorDescargaItinerario = x.NombreOperadorDescargaItinerario,
                        CodigoAgenteMaritimoItinerario = x.CodigoAgenteMaritimoItinerario,
                        NombreAgenteMaritimoItinerario = x.NombreAgenteMaritimoItinerario,
                        CodigoTipoLugarCargaPuertoIntermedio = x.CodigoTipoLugarCargaPuertoIntermedio,
                        NombreTipoLugarCargaPuertoIntermedio = x.NombreTipoLugarCargaPuertoIntermedio,
                        CodigoPuertoIntermedio = x.CodigoPuertoIntermedio,
                        NombrePuertoIntermedio = x.NombrePuertoIntermedio,
                        NumeroManifiestoItinerario = x.NumeroManifiestoItinerario,
                        AnioManifiestoItinerario = x.AnioManifiestoItinerario,
                        FechaArriboItinerario = x.FechaArriboItinerario,
                        FechaZarpeItinerario = x.FechaZarpeItinerario,
                        FechaAtraqueItinerario = x.FechaAtraqueItinerario,
                        FechaTerminoDescargaItinerario = x.FechaTerminoDescargaItinerario,
                        DUEItinerario = x.DUEItinerario,
                        CapitanNaveItinerario = x.CapitanNaveItinerario,
                        FechaZarpePuertoIntermedio = x.FechaZarpePuertoIntermedio,
                        Voyage = x.Voyage,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraLineaNavieraDTO RegistroLineaNaviera(RequestRegistraLineaNavieraDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraLineaNavieraDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraLineaNavieraDTO, RequestRegistroLineaNaviera>(requesDTO);
                var response = repo.RegistroLineaNaviera(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaLineaNavieraDTO ConsultarLineaNaviera(RequestConsultarLineaNavieraDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaLineaNavieraDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarLineaNavieraDTO, RequestConsultarLineaNaviera>(requesDTO);
                var resp = repo.ConsultarLineaNaviera(requestBE);

                resp.ListaLineaNaviera.ForEach(x =>
                {
                    responseDTO.ListaLineaNaviera.Add(new LineaNavieraDTO
                    {
                        CodigoLineaNaviera = x.CodigoLineaNaviera,
                        NombreLineaNaviera = x.NombreLineaNaviera,
                        DireccionLineaNaviera = x.DireccionLineaNaviera,
                        RucLineaNaviera = x.RucLineaNaviera,
                        CodigoEquivalencia = x.CodigoEquivalencia,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });
                });
                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraMedioTransporteDTO RegistroMedioTransporte(RequestRegistraMedioTransporteDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraMedioTransporteDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraMedioTransporteDTO, RequestRegistroMedioTransporte>(requesDTO);
                var response = repo.RegistroMedioTransporte(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaMedioTransporteDTO ConsultarMedioTransporte(RequestConsultarMedioTransporteDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaMedioTransporteDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarMedioTransporteDTO, RequestConsultarMedioTransporte>(requesDTO);
                var resp = repo.ConsultarMedioTransporte(requestBE);

                resp.ListaMedioTransporte.ForEach(x =>
                {
                    responseDTO.ListaMedioTransporte.Add(new MedioTransporteDTO
                    {
                        CodigoMedioTransporte = x.CodigoMedioTransporte,
                        CodigoMedioTransporteSunat = x.CodigoMedioTransporteSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreMedioTransporte = x.NombreMedioTransporte,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraModoPagoDTO RegistroModoPago(RequestRegistraModoPagoDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraModoPagoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraModoPagoDTO, RequestRegistroModoPago>(requesDTO);
                var response = repo.RegistroModoPago(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaModoPagoDTO ConsultarModoPago(RequestConsultarModoPagoDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaModoPagoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarModoPagoDTO, RequestConsultarModoPago>(requesDTO);
                var resp = repo.ConsultarModoPago(requestBE);

                resp.ListaModoPago.ForEach(x =>
                {
                    responseDTO.ListaModoPago.Add(new ModoPagoDTO
                    {
                        CodigoModoPago = x.CodigoModoPago,
                        CodigoModoPagoSunat = x.CodigoModoPagoSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreModoPago = x.NombreModoPago,
                        CodigoEquivalencia = x.CodigoEquivalencia,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });
                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraMonedaDTO RegistroMoneda(RequestRegistraMonedaDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraMonedaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraMonedaDTO, RequestRegistroMoneda>(requesDTO);
                var response = repo.RegistroMoneda(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaMonedaDTO ConsultarMoneda(RequestConsultarMonedaDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaMonedaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarMonedaDTO, RequestConsultarMoneda>(requesDTO);
                var resp = repo.ConsultarMoneda(requestBE);

                resp.ListaMoneda.ForEach(x =>
                {
                    responseDTO.ListaMoneda.Add(new MonedaDTO
                    {
                        CodigoMoneda = x.CodigoMoneda,
                        CodigoMonedaSunat = x.CodigoMonedaSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreMoneda = x.NombreMoneda,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraNaturalezaCargaDTO RegistroNaturalezaCarga(RequestRegistraNaturalezaCargaDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraNaturalezaCargaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraNaturalezaCargaDTO, RequestRegistroNaturalezaCarga>(requesDTO);
                var response = repo.RegistroNaturalezaCarga(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaNaturalezaCargaDTO ConsultarNaturalezaCarga(RequestConsultarNaturalezaCargaDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaNaturalezaCargaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarNaturalezaCargaDTO, RequestConsultarNaturalezaCarga>(requesDTO);
                var resp = repo.ConsultarNaturalezaCarga(requestBE);

                resp.ListaNaturalezaCarga.ForEach(x =>
                {
                    responseDTO.ListaNaturalezaCarga.Add(new NaturalezaCargaDTO
                    {
                        CodigoNaturalezaCarga = x.CodigoNaturalezaCarga,
                        CodigoNaturalezaCargaSunat = x.CodigoNaturalezaCargaSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreNaturalezaCarga = x.NombreNaturalezaCarga,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraNaveDTO RegistroNave(RequestRegistraNaveDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraNaveDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraNaveDTO, RequestRegistroNave>(requesDTO);
                var response = repo.RegistroNave(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaNaveDTO ConsultarNave(RequestConsultarNaveDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaNaveDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarNaveDTO, RequestConsultarNave>(requesDTO);
                var resp = repo.ConsultarNave(requestBE);

                resp.ListaNave.ForEach(x =>
                {

                    responseDTO.ListaNave.Add(new NaveDTO
                    {
                        CodigoNave = x.CodigoNave,
                        NombreNave = x.NombreNave,
                        CodigoPais = x.CodigoPais,
                        NombrePais = x.NombrePais,
                        CodigoTipoNave = x.CodigoTipoNave,
                        NombreTipoNave = x.NombreTipoNave,
                        CodigoLineaNaviera = x.CodigoLineaNaviera,
                        NombreLineaNaviera = x.NombreLineaNaviera,
                        MatriculaNave = x.MatriculaNave,
                        TrbNave = x.TrbNave,
                        TrnNave = x.TrnNave,
                        EsloraNave = x.EsloraNave,
                        MangaNave = x.MangaNave,
                        CaladoNave = x.CaladoNave,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraNumeroIMODTO RegistroNumeroIMO(RequestRegistraNumeroIMODTO requesDTO)
        {
            var responseDTO = new ResponseRegistraNumeroIMODTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraNumeroIMODTO, RequestRegistroNumeroIMO>(requesDTO);
                var response = repo.RegistroNumeroIMO(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaNumeroIMODTO ConsultarNumeroIMO(RequestConsultarNumeroIMODTO requesDTO)
        {
            var responseDTO = new ResponseConsultaNumeroIMODTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarNumeroIMODTO, RequestConsultarNumeroIMO>(requesDTO);
                var resp = repo.ConsultarNumeroIMO(requestBE);

                resp.ListaNumeroIMO.ForEach(x =>
                {

                    responseDTO.ListaNumeroIMO.Add(new NumeroIMODTO
                    {
                        CodigoNumeroIMO = x.CodigoNumeroIMO,
                        NumberIMO = x.NumberIMO,
                        NombreNumeroIMO = x.NombreNumeroIMO,
                        PaginaNumeroIMO = x.PaginaNumeroIMO,
                        CodigoClaseIMO = x.CodigoClaseIMO,
                        NombreClaseIMO = x.NombreClaseIMO,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraPrecintoDTO RegistroPrecinto(RequestRegistraPrecintoDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraPrecintoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraPrecintoDTO, RequestRegistroPrecinto>(requesDTO);
                var response = repo.RegistroPrecinto(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaPrecintoDTO ConsultarPrecinto(RequestConsultarPrecintoDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaPrecintoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarPrecintoDTO, RequestConsultarPrecinto>(requesDTO);
                var resp = repo.ConsultarPrecinto(requestBE);

                resp.ListaPrecinto.ForEach(x =>
                {

                    responseDTO.ListaPrecinto.Add(new PrecintoDTO
                    {
                        CodigoPrecinto = x.CodigoPrecinto,
                        NumeroPrecinto = x.NumeroPrecinto,
                        CodigoCondicionPrecinto = x.CodigoCondicionPrecinto,
                        NombreCondicionPrecinto = x.NombreCondicionPrecinto,
                        CodigoEntidadPrecinto = x.CodigoEntidadPrecinto,
                        NombreEntidadPrecinto = x.NombreEntidadPrecinto,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraPuertoDTO RegistroPuerto(RequestRegistraPuertoDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraPuertoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraPuertoDTO, RequestRegistroPuerto>(requesDTO);
                var response = repo.RegistroPuerto(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaPuertoDTO ConsultarPuerto(RequestConsultarPuertoDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaPuertoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarPuertoDTO, RequestConsultarPuerto>(requesDTO);
                var resp = repo.ConsultarPuerto(requestBE);

                resp.ListaPuerto.ForEach(x =>
                {

                    responseDTO.ListaPuerto.Add(new PuertoDTO
                    {
                        CodigoPuerto = x.CodigoPuerto,
                        CodigoPais = x.CodigoPais,
                        CodigoPuertoSunat = x.CodigoPuertoSunat,
                        NombrePuerto = x.NombrePuerto,
                        NombrePais = x.NombrePais,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraRequerimientoServicioDTO RegistroRequerimientoServicio(RequestRegistraRequerimientoServicioDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraRequerimientoServicioDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraRequerimientoServicioDTO, RequestRegistroRequerimientoServicio>(requesDTO);
                var response = repo.RegistroRequerimientoServicio(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaRequerimientoServicioDTO ConsultarRequerimientoServicio(RequestConsultarRequerimientoServicioDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaRequerimientoServicioDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarRequerimientoServicioDTO, RequestConsultarRequerimientoServicio>(requesDTO);
                var resp = repo.ConsultarRequerimientoServicio(requestBE);

                resp.ListaRequerimientoServicio.ForEach(x =>
                {

                    responseDTO.ListaRequerimientoServicio.Add(new RequerimientoServicioDTO
                    {
                        CodigoRequerimientoServicio = x.CodigoRequerimientoServicio,
                        CodigoRequerimientoServicioSunat = x.CodigoRequerimientoServicioSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreRequerimientoServicio = x.NombreRequerimientoServicio,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraRolDTO RegistroRol(RequestRegistraRolDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraRolDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraRolDTO, RequestRegistroRol>(requesDTO);
                var response = repo.RegistroRol(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaRolDTO ConsultarRol(RequestConsultarRolDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaRolDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarRolDTO, RequestConsultarRol>(requesDTO);
                var resp = repo.ConsultarRol(requestBE);

                resp.ListaRol.ForEach(x =>
                {

                    responseDTO.ListaRol.Add(new RolDTO
                    {
                        CodigoRol = x.CodigoRol,
                        CodigoRolSunat = x.CodigoRolSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreRol = x.NombreRol,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });
                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ConsultaTiposBLResponseDTO ConsultaTiposBL()
        {
            ConsultaTiposBLResponseDTO response = new ConsultaTiposBLResponseDTO();

            try
            {
                string keyCache = Convert.ToString(KeyCache.TipoBL);
                var TiposBL = new List<TiposBL>();

                ManejadorCache manejadorCache = new ManejadorCache();

                TiposBL = manejadorCache.ObtenerValorCache<List<TiposBL>>(keyCache);

                if (TiposBL == null || TiposBL.Count == 0)
                {
                    var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                    var repo = new RepositorioMaestros(contextoParaBaseDatos);
                    TiposBL = repo.ConsultaTiposBL();
                    manejadorCache.InsertarValorCache(keyCache, TiposBL);
                }

                response.ListaTiposBL = (from Origen in TiposBL
                                       select Helper.MiMapper<TiposBL, TiposBLDTO>(Origen)).ToList();
            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }

        public ConsultaTemperaturasResponseDTO ConsultaTemperaturas()
        {
            ConsultaTemperaturasResponseDTO response = new ConsultaTemperaturasResponseDTO();

            try
            {
                string keyCache = Convert.ToString(KeyCache.Temperatura);
                var Temperaturas = new List<Temperaturas>();

                ManejadorCache manejadorCache = new ManejadorCache();

                Temperaturas = manejadorCache.ObtenerValorCache<List<Temperaturas>>(keyCache);

                if (Temperaturas == null || Temperaturas.Count == 0)
                {
                    var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                    var repo = new RepositorioMaestros(contextoParaBaseDatos);
                    Temperaturas = repo.ConsultaTemperaturas();
                    manejadorCache.InsertarValorCache(keyCache, Temperaturas);
                }

                response.ListaTemperaturas = (from Origen in Temperaturas
                                         select Helper.MiMapper<Temperaturas, TemperaturasDTO>(Origen)).ToList();
            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }

        public ConsultaCondicionesCargaResponseDTO ConsultaCondicionesCarga()
        {
            ConsultaCondicionesCargaResponseDTO response = new ConsultaCondicionesCargaResponseDTO();

            try
            {
                string keyCache = Convert.ToString(KeyCache.CondicionCarga);
                var CondicionesCarga = new List<CondicionesCarga>();

                ManejadorCache manejadorCache = new ManejadorCache();

                CondicionesCarga = manejadorCache.ObtenerValorCache<List<CondicionesCarga>>(keyCache);

                if (CondicionesCarga == null || CondicionesCarga.Count == 0)
                {
                    var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                    var repo = new RepositorioMaestros(contextoParaBaseDatos);
                    CondicionesCarga = repo.ConsultaCondicionesCarga();
                    manejadorCache.InsertarValorCache(keyCache, CondicionesCarga);
                }

                response.ListaCondicionesCarga = (from Origen in CondicionesCarga
                                         select Helper.MiMapper<CondicionesCarga, CondicionesCargaDTO>(Origen)).ToList();
            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }

        public ConsultaCondicionesTransporteResponseDTO ConsultaCondicionesTransporte()
        {
            ConsultaCondicionesTransporteResponseDTO response = new ConsultaCondicionesTransporteResponseDTO();

            try
            {
                string keyCache = Convert.ToString(KeyCache.CondicionTransporte);
                var CondicionesTransporte = new List<CondicionesTransporte>();

                ManejadorCache manejadorCache = new ManejadorCache();

                CondicionesTransporte = manejadorCache.ObtenerValorCache<List<CondicionesTransporte>>(keyCache);

                if (CondicionesTransporte == null || CondicionesTransporte.Count == 0)
                {
                    var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                    var repo = new RepositorioMaestros(contextoParaBaseDatos);
                    CondicionesTransporte = repo.ConsultaCondicionesTransporte();
                    manejadorCache.InsertarValorCache(keyCache, CondicionesTransporte);
                }

                response.ListaCondicionesTransporte = (from Origen in CondicionesTransporte
                                         select Helper.MiMapper<CondicionesTransporte, CondicionesTransporteDTO>(Origen)).ToList();
            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }

        public ConsultaModosPagoResponseDTO ConsultaModosPago()
        {
            ConsultaModosPagoResponseDTO response = new ConsultaModosPagoResponseDTO();

            try
            {
                string keyCache = Convert.ToString(KeyCache.ModoPago);
                var ModosPago = new List<ModosPago>();

                ManejadorCache manejadorCache = new ManejadorCache();

                ModosPago = manejadorCache.ObtenerValorCache<List<ModosPago>>(keyCache);

                if (ModosPago == null || ModosPago.Count == 0)
                {
                    var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                    var repo = new RepositorioMaestros(contextoParaBaseDatos);
                    ModosPago = repo.ConsultaModosPago();
                    manejadorCache.InsertarValorCache(keyCache, ModosPago);
                }

                response.ListaModosPago = (from Origen in ModosPago
                                         select Helper.MiMapper<ModosPago, ModosPagoDTO>(Origen)).ToList();
            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }

        public ConsultaTiposTransmisionNaveResponseDTO ConsultaTiposTransmisionNave()
        {
            ConsultaTiposTransmisionNaveResponseDTO response = new ConsultaTiposTransmisionNaveResponseDTO();

            try
            {
                string keyCache = Convert.ToString(KeyCache.TipoTransmisionNave);
                var TiposTransmisionNave = new List<TiposTransmisionNave>();

                ManejadorCache manejadorCache = new ManejadorCache();

                TiposTransmisionNave = manejadorCache.ObtenerValorCache<List<TiposTransmisionNave>>(keyCache);

                if (TiposTransmisionNave == null || TiposTransmisionNave.Count == 0)
                {
                    var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                    var repo = new RepositorioMaestros(contextoParaBaseDatos);
                    TiposTransmisionNave = repo.ConsultaTiposTransmisionNave();
                    manejadorCache.InsertarValorCache(keyCache, TiposTransmisionNave);
                }

                response.ListaTiposTransmisionNave = (from Origen in TiposTransmisionNave
                                           select Helper.MiMapper<TiposTransmisionNave, TiposTransmisionNaveDTO>(Origen)).ToList();
            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }

        public ConsultaTiposTransmisionDocumentoResponseDTO ConsultaTiposTransmisionDocumento()
        {
            ConsultaTiposTransmisionDocumentoResponseDTO response = new ConsultaTiposTransmisionDocumentoResponseDTO();

            try
            {
                string keyCache = Convert.ToString(KeyCache.TipoTransmisionDocumento);
                var TiposTransmisionDocumento = new List<TiposTransmisionDocumento>();

                ManejadorCache manejadorCache = new ManejadorCache();

                TiposTransmisionDocumento = manejadorCache.ObtenerValorCache<List<TiposTransmisionDocumento>>(keyCache);

                if (TiposTransmisionDocumento == null || TiposTransmisionDocumento.Count == 0)
                {
                    var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                    var repo = new RepositorioMaestros(contextoParaBaseDatos);
                    TiposTransmisionDocumento = repo.ConsultaTiposTransmisionDocumento();
                    manejadorCache.InsertarValorCache(keyCache, TiposTransmisionDocumento);
                }

                response.ListaTiposTransmisionDocumento = (from Origen in TiposTransmisionDocumento
                                                      select Helper.MiMapper<TiposTransmisionDocumento, TiposTransmisionDocumentoDTO>(Origen)).ToList();
            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }

        public ConsultaCondicionesContratoResponseDTO ConsultaCondicionesContrato()
        {
            ConsultaCondicionesContratoResponseDTO response = new ConsultaCondicionesContratoResponseDTO();

            try
            {
                string keyCache = Convert.ToString(KeyCache.CondicionContrato);
                var CondicionesContrato = new List<CondicionesContrato>();

                ManejadorCache manejadorCache = new ManejadorCache();

                CondicionesContrato = manejadorCache.ObtenerValorCache<List<CondicionesContrato>>(keyCache);

                if (CondicionesContrato == null || CondicionesContrato.Count == 0)
                {
                    var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                    var repo = new RepositorioMaestros(contextoParaBaseDatos);
                    CondicionesContrato = repo.ConsultaCondicionesContrato();
                    manejadorCache.InsertarValorCache(keyCache, CondicionesContrato);
                }

                response.ListaCondicionesContrato = (from Origen in CondicionesContrato
                                         select Helper.MiMapper<CondicionesContrato, CondicionesContratoDTO>(Origen)).ToList();
            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }

        public ConsultaTiposEnvioResponseDTO ConsultaTiposEnvio()
        {
            ConsultaTiposEnvioResponseDTO response = new ConsultaTiposEnvioResponseDTO();

            try
            {
                string keyCache = Convert.ToString(KeyCache.TipoEnvio);
                var TiposEnvio = new List<TiposEnvio>();

                ManejadorCache manejadorCache = new ManejadorCache();

                TiposEnvio = manejadorCache.ObtenerValorCache<List<TiposEnvio>>(keyCache);

                if (TiposEnvio == null || TiposEnvio.Count == 0)
                {
                    var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                    var repo = new RepositorioMaestros(contextoParaBaseDatos);
                    TiposEnvio = repo.ConsultaTiposEnvio();
                    manejadorCache.InsertarValorCache(keyCache, TiposEnvio);
                }

                response.ListaTiposEnvio = (from Origen in TiposEnvio
                                         select Helper.MiMapper<TiposEnvio, TiposEnvioDTO>(Origen)).ToList();
            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }

        public ConsultaTiposOperacionResponseDTO ConsultaTiposOperacion()
        {
            ConsultaTiposOperacionResponseDTO response = new ConsultaTiposOperacionResponseDTO();

            try
            {
                string keyCache = Convert.ToString(KeyCache.TipoOperacion);
                var TiposOperacion = new List<TiposOperacion>();

                ManejadorCache manejadorCache = new ManejadorCache();

                TiposOperacion = manejadorCache.ObtenerValorCache<List<TiposOperacion>>(keyCache);

                if (TiposOperacion == null || TiposOperacion.Count == 0)
                {
                    var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                    var repo = new RepositorioMaestros(contextoParaBaseDatos);
                    TiposOperacion = repo.ConsultaTiposOperacion();
                    manejadorCache.InsertarValorCache(keyCache, TiposOperacion);
                }

                response.ListaTiposOperacion = (from Origen in TiposOperacion
                                            select Helper.MiMapper<TiposOperacion, TiposOperacionDTO>(Origen)).ToList();
            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }

        public ConsultaRolesResponseDTO ConsultaRoles()
        {
            ConsultaRolesResponseDTO response = new ConsultaRolesResponseDTO();

            try
            {
                string keyCache = Convert.ToString(KeyCache.Rol);
                var Roles = new List<Roles>();

                ManejadorCache manejadorCache = new ManejadorCache();

                Roles = manejadorCache.ObtenerValorCache<List<Roles>>(keyCache);

                if (Roles == null || Roles.Count == 0)
                {
                    var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                    var repo = new RepositorioMaestros(contextoParaBaseDatos);
                    Roles = repo.ConsultaRoles();
                    manejadorCache.InsertarValorCache(keyCache, Roles);
                }

                response.ListaRoles = (from Origen in Roles
                                       select Helper.MiMapper<Roles, RolesDTO>(Origen)).ToList();
            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }

        public Roles ObtenerRolPorCodigo(long codigo)
        {
            string keyCache = Convert.ToString(KeyCache.Sucursal);
            var roles = new List<Roles>();
            var rol = new Roles();

            ManejadorCache manejadorCache = new ManejadorCache();

            roles = manejadorCache.ObtenerValorCache<List<Roles>>(keyCache);

            if (roles == null || roles.Count == 0)
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                roles = repo.ConsultaRoles();
                manejadorCache.InsertarValorCache(keyCache, roles);
            }

            if (roles.Count > 0)
            {
                rol = roles.Where(x => x.CodigoRol.Equals(codigo)).FirstOrDefault();
            }

            return rol;
        }

        public ResponseRegistraTemperaturaDTO RegistroTemperatura(RequestRegistraTemperaturaDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraTemperaturaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraTemperaturaDTO, RequestRegistroTemperatura>(requesDTO);
                var response = repo.RegistroTemperatura(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaTemperaturaDTO ConsultarTemperatura(RequestConsultarTemperaturaDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaTemperaturaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarTemperaturaDTO, RequestConsultarTemperatura>(requesDTO);
                var resp = repo.ConsultarTemperatura(requestBE);

                resp.ListaTemperatura.ForEach(x =>
                {

                    responseDTO.ListaTemperatura.Add(new TemperaturaDTO
                    {
                        CodigoTemperatura = x.CodigoTemperatura,
                        CodigoTemperaturaSunat = x.CodigoTemperaturaSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreTemperatura = x.NombreTemperatura,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraTipoBLDTO RegistroTipoBL(RequestRegistraTipoBLDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraTipoBLDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraTipoBLDTO, RequestRegistroTipoBL>(requesDTO);
                var response = repo.RegistroTipoBL(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaTipoBLDTO ConsultarTipoBL(RequestConsultarTipoBLDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaTipoBLDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarTipoBLDTO, RequestConsultarTipoBL>(requesDTO);
                var resp = repo.ConsultarTipoBL(requestBE);

                resp.ListaTipoBL.ForEach(x =>
                {

                    responseDTO.ListaTipoBL.Add(new TipoBLDTO
                    {
                        CodigoTipoBL = x.CodigoTipoBL,
                        CodigoTipoBLSunat = x.CodigoTipoBLSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreTipoBL = x.NombreTipoBL,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraTipoContenedorDTO RegistroTipoContenedor(RequestRegistraTipoContenedorDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraTipoContenedorDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraTipoContenedorDTO, RequestRegistroTipoContenedor>(requesDTO);
                var response = repo.RegistroTipoContenedor(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaTipoContenedorDTO ConsultarTipoContenedor(RequestConsultarTipoContenedorDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaTipoContenedorDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarTipoContenedorDTO, RequestConsultarTipoContenedor>(requesDTO);
                var resp = repo.ConsultarTipoContenedor(requestBE);

                resp.ListaTipoContenedor.ForEach(x =>
                {

                    responseDTO.ListaTipoContenedor.Add(new TipoContenedorDTO
                    {
                        CodigoTipoContenedor = x.CodigoTipoContenedor,
                        CodigoIsoTipoContenedor = x.CodigoIsoTipoContenedor,
                        CodigoIsoGrupoTipoContenedor = x.CodigoIsoGrupoTipoContenedor,
                        NombreTipoContenedor = x.NombreTipoContenedor,
                        CodigoAduanaTipoContenedor = x.CodigoAduanaTipoContenedor,
                        CodTipoContenedor = x.CodTipoContenedor,
                        TamanioTipoContenedor = x.TamanioTipoContenedor,
                        IsoTipoContenedor = x.IsoTipoContenedor,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraTipoDocumentoDTO RegistroTipoDocumento(RequestRegistraTipoDocumentoDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraTipoDocumentoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraTipoDocumentoDTO, RequestRegistroTipoDocumento>(requesDTO);
                var response = repo.RegistroTipoDocumento(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaTipoDocumentoDTO ConsultarTipoDocumento(RequestConsultarTipoDocumentoDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaTipoDocumentoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarTipoDocumentoDTO, RequestConsultarTipoDocumento>(requesDTO);
                var resp = repo.ConsultarTipoDocumento(requestBE);

                resp.ListaTipoDocumento.ForEach(x =>
                {

                    responseDTO.ListaTipoDocumento.Add(new TipoDocumentoDTO
                    {
                        CodigoTipoDocumento = x.CodigoTipoDocumento,
                        CodigoTipoDocumentoSunat = x.CodigoTipoDocumentoSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreTipoDocumento = x.NombreTipoDocumento,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraTipoEnvioDTO RegistroTipoEnvio(RequestRegistraTipoEnvioDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraTipoEnvioDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraTipoEnvioDTO, RequestRegistroTipoEnvio>(requesDTO);
                var response = repo.RegistroTipoEnvio(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaTipoEnvioDTO ConsultarTipoEnvio(RequestConsultarTipoEnvioDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaTipoEnvioDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarTipoEnvioDTO, RequestConsultarTipoEnvio>(requesDTO);
                var resp = repo.ConsultarTipoEnvio(requestBE);

                resp.ListaTipoEnvio.ForEach(x =>
                {

                    responseDTO.ListaTipoEnvio.Add(new TipoEnvioDTO
                    {
                        CodigoTipoEnvio = x.CodigoTipoEnvio,
                        CodigoTipoEnvioSunat = x.CodigoTipoEnvioSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreTipoEnvio = x.NombreTipoEnvio,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraTipoFleteDTO RegistroTipoFlete(RequestRegistraTipoFleteDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraTipoFleteDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraTipoFleteDTO, RequestRegistroTipoFlete>(requesDTO);
                var response = repo.RegistroTipoFlete(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaTipoFleteDTO ConsultarTipoFlete(RequestConsultarTipoFleteDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaTipoFleteDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarTipoFleteDTO, RequestConsultarTipoFlete>(requesDTO);
                var resp = repo.ConsultarTipoFlete(requestBE);

                resp.ListaTipoFlete.ForEach(x =>
                {

                    responseDTO.ListaTipoFlete.Add(new TipoFleteDTO
                    {
                        CodigoTipoFlete = x.CodigoTipoFlete,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreTipoFlete = x.NombreTipoFlete,
                        CodigoAduanaTipoFlete = x.CodigoAduanaTipoFlete,
                        CodigoEquivalencia = x.CodigoEquivalencia,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraTipoLugarCargaDTO RegistroTipoLugarCarga(RequestRegistraTipoLugarCargaDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraTipoLugarCargaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraTipoLugarCargaDTO, RequestRegistroTipoLugarCarga>(requesDTO);
                var response = repo.RegistroTipoLugarCarga(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaTipoLugarCargaDTO ConsultarTipoLugarCarga(RequestConsultarTipoLugarCargaDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaTipoLugarCargaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarTipoLugarCargaDTO, RequestConsultarTipoLugarCarga>(requesDTO);
                var resp = repo.ConsultarTipoLugarCarga(requestBE);

                resp.ListaTipoLugarCarga.ForEach(x =>
                {
                    responseDTO.ListaTipoLugarCarga.Add(new TipoLugarCargaDTO
                    {
                        CodigoTipoLugarCarga = x.CodigoTipoLugarCarga,
                        CodigoTipoLugarCargaSunat = x.CodigoTipoLugarCargaSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreTipoLugarCarga = x.NombreTipoLugarCarga,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraTipoMovimientoDTO RegistroTipoMovimiento(RequestRegistraTipoMovimientoDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraTipoMovimientoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraTipoMovimientoDTO, RequestRegistroTipoMovimiento>(requesDTO);
                var response = repo.RegistroTipoMovimiento(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaTipoMovimientoDTO ConsultarTipoMovimiento(RequestConsultarTipoMovimientoDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaTipoMovimientoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarTipoMovimientoDTO, RequestConsultarTipoMovimiento>(requesDTO);
                var resp = repo.ConsultarTipoMovimiento(requestBE);

                resp.ListaTipoMovimiento.ForEach(x =>
                {
                    responseDTO.ListaTipoMovimiento.Add(new TipoMovimientoDTO
                    {
                        CodigoTipoMovimiento = x.CodigoTipoMovimiento,
                        CodigoTipoMovimientoSunat = x.CodigoTipoMovimientoSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreTipoMovimiento = x.NombreTipoMovimiento,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraTipoNaveDTO RegistroTipoNave(RequestRegistraTipoNaveDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraTipoNaveDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraTipoNaveDTO, RequestRegistroTipoNave>(requesDTO);
                var response = repo.RegistroTipoNave(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaTipoNaveDTO ConsultarTipoNave(RequestConsultarTipoNaveDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaTipoNaveDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarTipoNaveDTO, RequestConsultarTipoNave>(requesDTO);
                var resp = repo.ConsultarTipoNave(requestBE);

                resp.ListaTipoNave.ForEach(x =>
                {
                    responseDTO.ListaTipoNave.Add(new TipoNaveDTO
                    {
                        CodigoTipoNave = x.CodigoTipoNave,
                        CodigoTipoNaveSunat = x.CodigoTipoNaveSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreTipoNave = x.NombreTipoNave,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraTipoOperacionDTO RegistroTipoOperacion(RequestRegistraTipoOperacionDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraTipoOperacionDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraTipoOperacionDTO, RequestRegistroTipoOperacion>(requesDTO);
                var response = repo.RegistroTipoOperacion(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaTipoOperacionDTO ConsultarTipoOperacion(RequestConsultarTipoOperacionDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaTipoOperacionDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarTipoOperacionDTO, RequestConsultarTipoOperacion>(requesDTO);
                var resp = repo.ConsultarTipoOperacion(requestBE);

                resp.ListaTipoOperacion.ForEach(x =>
                {
                    responseDTO.ListaTipoOperacion.Add(new TipoOperacionDTO
                    {
                        CodigoTipoOperacion = x.CodigoTipoOperacion,
                        CodigoTipoOperacionSunat = x.CodigoTipoOperacionSunat,
                        NombreTipoOperacion = x.NombreTipoOperacion,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraUnidadMercanciaDTO RegistroUnidadMercancia(RequestRegistraUnidadMercanciaDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraUnidadMercanciaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraUnidadMercanciaDTO, RequestRegistroUnidadMercancia>(requesDTO);
                var response = repo.RegistroUnidadMercancia(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaUnidadMercanciaDTO ConsultarUnidadMercancia(RequestConsultarUnidadMercanciaDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaUnidadMercanciaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarUnidadMercanciaDTO, RequestConsultarUnidadMercancia>(requesDTO);
                var resp = repo.ConsultarUnidadMercancia(requestBE);

                resp.ListaUnidadMercancia.ForEach(x =>
                {

                    responseDTO.ListaUnidadMercancia.Add(new UnidadMercanciaDTO
                    {
                        CodigoUnidadMercancia = x.CodigoUnidadMercancia,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreUnidadMercancia = x.NombreUnidadMercancia,
                        CodigoAduanaUnidadMercancia = x.CodigoAduanaUnidadMercancia,
                        CodigoUnidadMercanciaSunat = x.CodigoUnidadMercanciaSunat,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseRegistraViaTransporteDTO RegistroViaTransporte(RequestRegistraViaTransporteDTO requesDTO)
        {
            var responseDTO = new ResponseRegistraViaTransporteDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestRegistraViaTransporteDTO, RequestRegistroViaTransporte>(requesDTO);
                var response = repo.RegistroViaTransporte(requestBE);
                responseDTO.CodigoMensaje = response.CodigoMensaje;
                responseDTO.Mensaje = response.Mensaje;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaViaTransporteDTO ConsultarViaTransporte(RequestConsultarViaTransporteDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaViaTransporteDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarViaTransporteDTO, RequestConsultarViaTransporte>(requesDTO);
                var resp = repo.ConsultarViaTransporte(requestBE);

                resp.ListaViaTransporte.ForEach(x =>
                {
                    responseDTO.ListaViaTransporte.Add(new ViaTransporteDTO
                    {
                        CodigoViaTransporte = x.CodigoViaTransporte,
                        CodigoViaTransporteSunat = x.CodigoViaTransporteSunat,
                        UsuarioCreacion = x.UsuarioCreacion,
                        FechaHoraCreacion = x.FechaHoraCreacion,
                        NombreViaTransporte = x.NombreViaTransporte,
                        FechaHoraActualizacion = x.FechaHoraActualizacion,
                        UsuarioActualizacion = x.UsuarioActualizacion,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return responseDTO;
        }

        public ResponseConsultaPersonaxRolDTO ConsultarPersonaxRol(RequestConsultarPersonaxRolDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaPersonaxRolDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioMaestros(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarPersonaxRolDTO, RequestConsultarPersonaxRol>(requesDTO);
                var resp = repo.ConsultarPersonaxRol(requestBE);

                resp.ListaPersonaxRol.ForEach(x =>
                {
                    responseDTO.ListaPersonaxRol.Add(new PersonaxRolDTO
                    {
                        CodigoPersona = x.CodigoPersona,
                        RazonSocialPersona = x.RazonSocialPersona,
                        NumeroDocumentoPersona = x.NumeroDocumentoPersona,
                        NombreTipoDocumento = x.NombreTipoDocumento,
                        NombrePais = x.NombrePais,
                    });

                });

                responseDTO.TotalRegistros = resp.TotalRegistros;
                responseDTO.CantidadPaginas = resp.CantidadPaginas;
                responseDTO.Result.Satisfactorio = true;
            }
            catch (Exception ex)
            {
                responseDTO.Result.Satisfactorio = false;
            }
            return responseDTO;
        }
    }
}
