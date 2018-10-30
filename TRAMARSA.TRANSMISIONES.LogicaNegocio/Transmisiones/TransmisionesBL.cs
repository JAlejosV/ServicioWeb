using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TRAMARSA.TRANSMISIONES.AccesoDatos;
using TRAMARSA.TRANSMISIONES.DTO;
using TRAMARSA.TRANSMISIONES.DTO.Transmision.Nave;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento.Request;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento.Response;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave.Request;
using TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Constantes;
using TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Documento;
using TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Documento.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Nave;
using TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Nave.Request;
using TRAMARSA.TRANSMISIONES.Framework;

namespace TRAMARSA.TRANSMISIONES.LogicaNegocio.Transmisiones
{
    public class TransmisionesBL
    {
        public ResponseConsultarTransmisionNaveDTO ConsultarTransmisionNave(RequestConsultarTransmisionNaveDTO requesDTO)
        {
            var responseDTO = new ResponseConsultarTransmisionNaveDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioTransmisiones(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarTransmisionNaveDTO, RequestConsultarTransmisionNave>(requesDTO);
                var resp = repo.ConsultarTransmisionNave(requestBE);

                resp.ListaTransmisionNave.ForEach(x =>
                {
                    responseDTO.ListaTransmisionNave.Add(new TransmisionNaveDTO
                    {
                        CodigoItinerario = x.CodigoItinerario,
                        AnioManifiestoItinerario = x.AnioManifiestoItinerario,
                        NumeroManifiestoItinerario = x.NumeroManifiestoItinerario,
                        NombreNave = x.NombreNave,
                        NumeroViajeItinerario = x.NumeroViajeItinerario,
                        NombreAduana = x.NombreAduana,
                        NombreTipoOperacion = x.NombreTipoOperacion,
                        NombreOperadorDescargaItinerario = x.NombreOperadorDescargaItinerario,
                        FechaArriboItinerario = x.FechaArriboItinerario,
                        TotalPesoBrutoTransmision = x.TotalPesoBrutoTransmision,
                        TotalBultosTransmision = x.TotalBultosTransmision,
                        TotalContenedoresTransmision = x.TotalContenedoresTransmision,
                        EstadoEnvioAduanas = x.EstadoEnvioAduanas,
                        EstadoTransmision = x.EstadoTransmision,
                        FechaHoraCreacion = x.FechaHoraCreacion,
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

        public ResponseConsultarTransmisionDocumentoDTO ConsultarTransmisionDocumento(RequestConsultarTransmisionDocumentoDTO requesDTO)
        {
            var responseDTO = new ResponseConsultarTransmisionDocumentoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioTransmisiones(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarTransmisionDocumentoDTO, RequestConsultarTransmisionDocumento>(requesDTO);
                var resp = repo.ConsultarTransmisionDocumento(requestBE);

                resp.ListaTransmisionDocumento.ForEach(x =>
                {
                    responseDTO.ListaTransmisionDocumento.Add(new TransmisionDocumentoDTO
                    {
                        CodigoDocumento = x.CodigoDocumento,
                        NumeroDocumento = x.NumeroDocumento,
                        NombreNave = x.NombreNave,
                        NumeroViajeItinerario = x.NumeroViajeItinerario,
                        AnioManifiestoItinerario = x.AnioManifiestoItinerario,
                        NumeroManifiestoItinerario = x.NumeroManifiestoItinerario,
                        NombreAduana = x.NombreAduana,
                        NombreTipoEnvio = x.NombreTipoEnvio,
                        TotalPesoBrutoTransmision = x.TotalPesoBrutoTransmision,
                        TotalBultosTransmision = x.TotalBultosTransmision,
                        TotalContenedoresTransmision = x.TotalContenedoresTransmision,
                        Consignatario = x.Consignatario,
                        Embarcador = x.Embarcador,
                        PuertoEmbarque = x.PuertoEmbarque,
                        PuertoFinal = x.PuertoFinal,
                        EstadoEnvioAduanas = x.EstadoEnvioAduanas,
                        EstadoTransmision = x.EstadoTransmision,
                        FechaHoraCreacion = x.FechaHoraCreacion,
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

        public ResponseConsultarLogTransmisionNaveDTO ConsultarLogTransmisionNave(RequestConsultarLogTransmisionNaveDTO requesDTO)
        {
            var responseDTO = new ResponseConsultarLogTransmisionNaveDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioTransmisiones(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarLogTransmisionNaveDTO, RequestConsultarLogTransmisionNave>(requesDTO);
                var resp = repo.ConsultarLogTransmisionNave(requestBE);

                resp.ListaLogTransmisionNave.ForEach(x =>
                {
                    responseDTO.ListaLogTransmisionNave.Add(new LogTransmisionNaveDTO
                    {
                        CodigoItinerario = x.CodigoItinerario,
                        CampoLogTransmisionItinerario = x.CampoLogTransmisionItinerario,
                        ValorLogTransmisionItinerario = x.ValorLogTransmisionItinerario,
                        TextoLogTransmisionItinerario = x.TextoLogTransmisionItinerario,
                        FechaLogTransmisionItinerario = x.FechaLogTransmisionItinerario,
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

        public ResponseConsultarLogTransmisionDocumentoDTO ConsultarLogTransmisionDocumento(RequestConsultarLogTransmisionDocumentoDTO requesDTO)
        {
            var responseDTO = new ResponseConsultarLogTransmisionDocumentoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioTransmisiones(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarLogTransmisionDocumentoDTO, RequestConsultarLogTransmisionDocumento>(requesDTO);
                var resp = repo.ConsultarLogTransmisionDocumento(requestBE);

                resp.ListaLogTransmisionDocumento.ForEach(x =>
                {
                    responseDTO.ListaLogTransmisionDocumento.Add(new LogTransmisionDocumentoDTO
                    {
                        CodigoDocumento = x.CodigoDocumento,
                        CampoLogTransmisionDocumento = x.CampoLogTransmisionDocumento,
                        ValorLogTransmisionDocumento = x.ValorLogTransmisionDocumento,
                        TextoLogTransmisionDocumento = x.TextoLogTransmisionDocumento,
                        FechaLogTransmisionDocumento = x.FechaLogTransmisionDocumento,
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

        public ResponseRegistrarTransmisionNaveDTO RegistraTransmisionNave(RegistraTransmisionNaveDTO request)
        {
            long result = 0;

            ResponseRegistrarTransmisionNaveDTO response = new ResponseRegistrarTransmisionNaveDTO();
            CoreBL coreBL = new CoreBL();

            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioTransmisiones(contextoParaBaseDatos);

                Mapper.CreateMap<DetalleTransmisionNaveDTO, DetalleTransmisionNave>();

                var requestBE = Helper.MiMapper<RegistraTransmisionNaveDTO, RegistraTransmisionNave>(request);

                using (TransactionScope Transaccion = new TransactionScope())
                {
                    result = repo.RegistraTransmisionNave(requestBE);
                    Transaccion.Complete();
                }
                //}

            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }

        public ResponseRegistrarTransmisionDocumentoDTO RegistraTransmisionDocumento(RegistraTransmisionDocumentoDTO request)
        {
            long result = 0;

            ResponseRegistrarTransmisionDocumentoDTO response = new ResponseRegistrarTransmisionDocumentoDTO();
            CoreBL coreBL = new CoreBL();

            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioTransmisiones(contextoParaBaseDatos);

                Mapper.CreateMap<DetalleTransmisionDocumentoDTO, DetalleTransmisionDocumento>();

                var requestBE = Helper.MiMapper<RegistraTransmisionDocumentoDTO, RegistraTransmisionDocumento>(request);

                using (TransactionScope Transaccion = new TransactionScope())
                {
                    result = repo.RegistraTransmisionDocumento(requestBE);
                    Transaccion.Complete();
                }
                //}

            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }
    }
}
