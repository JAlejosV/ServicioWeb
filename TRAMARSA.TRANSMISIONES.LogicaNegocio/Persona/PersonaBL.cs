using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TRAMARSA.TRANSMISIONES.AccesoDatos;
using TRAMARSA.TRANSMISIONES.DTO;
using TRAMARSA.TRANSMISIONES.DTO.Persona;
using TRAMARSA.TRANSMISIONES.DTO.Persona.Request;
using TRAMARSA.TRANSMISIONES.DTO.Persona.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Constantes;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.Rol;
using TRAMARSA.TRANSMISIONES.Entidades.Persona;
using TRAMARSA.TRANSMISIONES.Entidades.Persona.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Rol;
using TRAMARSA.TRANSMISIONES.Framework;

namespace TRAMARSA.TRANSMISIONES.LogicaNegocio.Persona
{
    public class PersonaBL
    {
        public RegistraPersonaResponseDTO RegistraPersona(RegistraPersonaRequestDTO request, bool esMasivo = false)
        {
            long result = 0;

            RegistraPersonaResponseDTO response = new RegistraPersonaResponseDTO();
            CoreBL coreBL = new CoreBL();

            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioPersona(contextoParaBaseDatos);

                Mapper.CreateMap<PersonaRolDTO, PersonaRol>();

                var requestBE = Helper.MiMapper<RegistraPersonaRequestDTO, RegistraPersona>(request);

                var request2 = new RequestConsultarPersona();
                #region Validacion

                request2.CodigoPersona = requestBE.CodigoPersona;
                request2.CodigoTipoDocumento = requestBE.CodigoTipoDocumento;
                request2.NumeroDocumentoPersona = requestBE.NumeroDocumentoPersona;

                var Validar = repo.ValidarPersona(request2);

                if (Validar.ListaPersona.FirstOrDefault() != null)
                {
                    response.Result.Satisfactorio = false;
                    response.Result.CodigoError = "1";
                    response.Result.Mensaje = "La persona con dicho Numero de Documento ya se encuentra registrado";
                    Validar.ListaPersona.ForEach(x =>
                    {
                        response.Result.Mensajes.Add(new Result { Mensaje = x.NumeroDocumentoPersona, Satisfactorio = false, CodigoError = "1" });
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
                        result = requestBE.CodigoPersona = repo.RegistrarPersona(requestBE);
                    }
                    else //APLICA PARA UPDATE Y DELETE
                    {
                        result = repo.ModificarPersona(requestBE);
                    }

                    #region DETALLE

                    if (!result.Equals(0))
                    {
                        requestBE.ListaPersonaRol.ForEach(x =>
                        {
                            x.CodigoPersona = requestBE.CodigoPersona;
                        });

                        if (repo.RegistrarPersonaRol(requestBE.ListaPersonaRol) && (request.Accion != Accion.Insertar.GetDescription()));
                    }

                    #endregion

                    Transaccion.Complete();

                    response.CodigoPersona = requestBE.CodigoPersona;
                }
            }
            catch (Exception ex)
            {
                response.Result = new Result { IdError = Guid.NewGuid(), Satisfactorio = false, Mensaje = "Ocurrio un problema interno en el servicio" };
                ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
            }
            return response;
        }

        public ResponseConsultaPersonaDTO ConsultarPersona(RequestConsultarPersonaDTO requesDTO)
        {
            var responseDTO = new ResponseConsultaPersonaDTO();
            try
            {
                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioPersona(contextoParaBaseDatos);
                var requestBE = Helper.MiMapper<RequestConsultarPersonaDTO, RequestConsultarPersona>(requesDTO);
                var resp = repo.ConsultarPersona(requestBE);

                resp.ListaPersona.ForEach(x =>
                {
                    responseDTO.ListaPersona.Add(new PersonaDTO
                    {
                        CodigoPersona = x.CodigoPersona,
                        RazonSocialPersona = x.RazonSocialPersona,
                        NumeroDocumentoPersona = x.NumeroDocumentoPersona,
                        NombreTipoDocumento = x.NombreTipoDocumento,
                        NombrePais = x.NombrePais,
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
                responseDTO.Result.Satisfactorio = false;
            }
            return responseDTO;
        }

        //DetalleJAV
        public ConsultaDetallePersonaResponseDTO ConsultarDetallePersona(ConsultaDetallePersonaRequestDTO request)
        {

            ConsultaDetallePersonaResponseDTO response = new ConsultaDetallePersonaResponseDTO();
            MaestrosBL maestrosBL = new MaestrosBL();
            //SeguridadBL seguridadBL = new SeguridadBL();
            //RolBL rolBL = new RolBL();
            //TarifaBL tarifaBL = new TarifaBL();

            try
            {
                var lstDetallePersona = new List<DetallePersona>();
                //List<DetalleCatalogoBE> lstDetalleCatalogo = new List<DetalleCatalogoBE>();
                //DetalleCatalogoBE detalleCatalogoCab = new DetalleCatalogoBE();

                //RequestInfoBasicaUsuarioDTO infoBasicaUsuario = new RequestInfoBasicaUsuarioDTO();
                //SucursalBE sucursal = new SucursalBE();
                Roles rol = new Roles();
                //ResponseRolesClientesSAP roles = new ResponseRolesClientesSAP();
                //TerminalPortuarioBE tportuario = new TerminalPortuarioBE();
                string estadoCaracter;

                var requestDTO = Helper.MiMapper<ConsultaDetallePersonaRequestDTO, ConsultaDetallePersona>(request);

                var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Transmisiones);
                var repo = new RepositorioPersona(contextoParaBaseDatos);

                lstDetallePersona = repo.ConsultarDetallePersona(requestDTO);
                //lstDetalleCatalogo = maestrosBL.ObtenerListaDetalleCatalogo();
                //var lstRolesClientesSAP = rolBL.ObtenerListaRolesCliente();


                lstDetallePersona.ForEach(x =>
                {
                    estadoCaracter = x.EstadoRegistro ? "1" : "0";

                    x.ListaPersonaRol.ForEach(s =>
                    {
                        rol = maestrosBL.ObtenerRolPorCodigo(s.CodigoRol);
                        s.NombreRol = rol != null ? rol.NombreRol : string.Empty;
                    });

                   

                });

                Mapper.CreateMap<PersonaRolConsulta, PersonaRolDTO>();
                response.ListaDetallePersona = (from Origen in lstDetallePersona
                                                                  select Helper.MiMapper<DetallePersona, DetallePersonaDTO>(Origen)).ToList();
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
