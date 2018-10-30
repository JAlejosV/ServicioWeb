using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TRAMARSA.TRANSMISIONES.AccesoDatos;
using TRAMARSA.TRANSMISIONES.DTO;
using TRAMARSA.TRANSMISIONES.DTO.Documento;
using TRAMARSA.TRANSMISIONES.DTO.Documento.Request;
using TRAMARSA.TRANSMISIONES.DTO.Documento.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Constantes;
using TRAMARSA.TRANSMISIONES.Entidades.Documento;
using TRAMARSA.TRANSMISIONES.Entidades.Documento.Request;
using TRAMARSA.TRANSMISIONES.Framework;

namespace TRAMARSA.TRANSMISIONES.LogicaNegocio.Documento
{
    public class DocumentoBL
    {
        public RegistraDocumentoResponseDTO RegistraDocumento(RegistraDocumentoRequestDTO request, bool esMasivo = false)
        {
            long result = 0;

            RegistraDocumentoResponseDTO response = new RegistraDocumentoResponseDTO();
            CoreBL coreBL = new CoreBL();

            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioDocumento(contextoParaBaseDatos);

                Mapper.CreateMap<DocumentoDetalleCargaDTO, DocumentoDetalleCarga>();
                Mapper.CreateMap<DocumentoDetalleClienteDTO, DocumentoDetalleCliente>();
                Mapper.CreateMap<DocumentoDetalleFleteDTO, DocumentoDetalleFlete>();

                var requestBE = Helper.MiMapper<RegistraDocumentoRequestDTO, RegistraDocumento>(request);



                var request2 = new RequestConsultarDocumento();
                #region Validacion

                request2.CodigoItinerario = requestBE.CodigoItinerario;
                request2.CodigoPuertoOrigenDocumento = requestBE.CodigoPuertoOrigenDocumento;
                request2.CodigoPuertoEmbarqueDocumento = requestBE.CodigoPuertoEmbarqueDocumento;
                request2.CodigoPuertoDescargaDocumento = requestBE.CodigoPuertoDescargaDocumento;
                request2.CodigoPuertoFinalDocumento = requestBE.CodigoPuertoFinalDocumento;
                request2.CodigoLineaNaviera = requestBE.CodigoLineaNaviera;
                request2.CodigoAduana = requestBE.CodigoAduana;
                request2.NumeroDocumento = requestBE.NumeroDocumento;

                var Validar = repo.ValidarDocumento(request2);

                if (Validar.ListaDocumento.FirstOrDefault() != null)
                {
                    response.Result.Satisfactorio = false;
                    response.Result.CodigoError = "1";
                    response.Result.Mensaje = "El BL ya se encuentra registrado";
                    Validar.ListaDocumento.ForEach(x =>
                    {
                        response.Result.Mensajes.Add(new Result { Mensaje = x.NumeroDocumento, Satisfactorio = false, CodigoError = "1" });
                    });

                    return response;
                }


                #endregion

                if (request.Accion.Equals(Accion.Insertar.GetDescription()))
                {
                    requestBE.EstadoRegistro = true;
                }

                using (TransactionScope Transaccion = new TransactionScope())
                {
                    if (request.Accion.Equals(Accion.Insertar.GetDescription()))
                    {
                        result = requestBE.CodigoDocumento = repo.RegistrarDocumento(requestBE);
                    }
                    else //APLICA PARA UPDATE Y DELETE
                    {
                        result = repo.ModificarDocumento(requestBE);
                    }

                    #region DETALLE

                    if (!result.Equals(0))
                    {
                        requestBE.ListaDocumentoDetalleCarga.ForEach(x =>
                        {
                            x.CodigoDocumento = requestBE.CodigoDocumento;
                        });

                        requestBE.ListaDocumentoDetalleCliente.ForEach(x =>
                        {
                            x.CodigoDocumento = requestBE.CodigoDocumento;
                        });

                        requestBE.ListaDocumentoDetalleFlete.ForEach(x =>
                        {
                            x.CodigoDocumento = requestBE.CodigoDocumento;
                        });

                        if (repo.RegistrarDocumentoDetalleCarga(requestBE.ListaDocumentoDetalleCarga) && (request.Accion != Accion.Insertar.GetDescription())) ;
                        if (repo.RegistrarDocumentoDetalleCliente(requestBE.ListaDocumentoDetalleCliente) && (request.Accion != Accion.Insertar.GetDescription())) ;
                        if (repo.RegistrarDocumentoDetalleFlete(requestBE.ListaDocumentoDetalleFlete) && (request.Accion != Accion.Insertar.GetDescription())) ;
                    }

                    #endregion

                    Transaccion.Complete();

                    response.CodigoDocumento = requestBE.CodigoDocumento;
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

        public ResponseConsultaDocumentoDTO ConsultarDocumento(RequestConsultarDocumentoDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaDocumentoDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioDocumento(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarDocumentoDTO, RequestConsultarDocumento>(requesDTO);
                var resp = repo.ConsultarDocumento(requestBE);

                resp.ListaDocumento.ForEach(x =>
                {
                    responseDTO.ListaDocumento.Add(new DocumentoDTO
                    {
                        CodigoDocumento = x.CodigoDocumento,
                        NombreNave = x.NombreNave,
                        NumeroViajeItinerario = x.NumeroViajeItinerario,
                        NombrePuertoOrigenDocumento = x.NombrePuertoOrigenDocumento,
                        NombrePuertoEmbarqueDocumento = x.NombrePuertoEmbarqueDocumento,
                        NombrePuertoDescargaDocumento = x.NombrePuertoDescargaDocumento,
                        NombrePuertoFinalDocumento = x.NombrePuertoFinalDocumento,
                        NombreLineaNaviera = x.NombreLineaNaviera,
                        NumeroDocumento = x.NumeroDocumento,
                        NombreAduana = x.NombreAduana,
                        NombreTipoBL = x.NombreTipoBL,
                        NombreTipoEnvio = x.NombreTipoEnvio,
                        FechaEmisionDocumento = x.FechaEmisionDocumento,
                        FechaEmbarqueDocumento = x.FechaEmbarqueDocumento,
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
            catch (Exception)
            {
                responseDTO.Result.Satisfactorio = false;
            }
            return responseDTO;
        }

        //DetalleJAV
        public ConsultaDetalleDocumentoResponseDTO ConsultarDetalleDocumento(ConsultaDetalleDocumentoRequestDTO request)
        {

            ConsultaDetalleDocumentoResponseDTO response = new ConsultaDetalleDocumentoResponseDTO();
            MaestrosBL maestrosBL = new MaestrosBL();
            //SeguridadBL seguridadBL = new SeguridadBL();
            //RolBL rolBL = new RolBL();
            //TarifaBL tarifaBL = new TarifaBL();

            try
            {
                var lstDetalleDocumento = new List<DetalleDocumento>();
                //List<DetalleCatalogoBE> lstDetalleCatalogo = new List<DetalleCatalogoBE>();
                //DetalleCatalogoBE detalleCatalogoCab = new DetalleCatalogoBE();

                //RequestInfoBasicaUsuarioDTO infoBasicaUsuario = new RequestInfoBasicaUsuarioDTO();
                //SucursalBE sucursal = new SucursalBE();
                //Roles rol = new Roles();
                //ResponseRolesClientesSAP roles = new ResponseRolesClientesSAP();
                //TerminalPortuarioBE tportuario = new TerminalPortuarioBE();
                //string estadoCaracter;

                var requestDTO = Helper.MiMapper<ConsultaDetalleDocumentoRequestDTO, ConsultaDetalleDocumento>(request);

                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioDocumento(contextoParaBaseDatos);

                lstDetalleDocumento = repo.ConsultarDetalleDocumento(requestDTO);
                //lstDetalleCatalogo = maestrosBL.ObtenerListaDetalleCatalogo();
                //var lstRolesClientesSAP = rolBL.ObtenerListaRolesCliente();


                //lstDetalleDocumento.ForEach(x =>
                //{
                //    estadoCaracter = x.EstadoRegistro ? "1" : "0";

                //    x.ListaDocumentoDetalleFlete.ForEach(s =>
                //    {
                //        rol = maestrosBL.ObtenerRolPorCodigo(s.CodigoRol);
                //        s.NombreRol = rol != null ? rol.NombreRol : string.Empty;
                //    });



                //});

                Mapper.CreateMap<DocumentoDetalleCargaConsulta, DocumentoDetalleCargaDTO>();
                Mapper.CreateMap<DocumentoDetalleClienteConsulta, DocumentoDetalleClienteDTO>();
                Mapper.CreateMap<DocumentoDetalleFleteConsulta, DocumentoDetalleFleteDTO>();
                response.ListaDetalleDocumento = (from Origen in lstDetalleDocumento
                                                select Helper.MiMapper<DetalleDocumento, DetalleDocumentoDTO>(Origen)).ToList();
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
