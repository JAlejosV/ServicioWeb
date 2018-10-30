using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAMARSA.TRANSMISIONES.Entidades.Documento;
using TRAMARSA.TRANSMISIONES.Entidades.Documento.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Documento.Response;
using TRAMARSA.TRANSMISIONES.Framework;

namespace TRAMARSA.TRANSMISIONES.AccesoDatos
{
    public class RepositorioDocumento : RepositorioBase<RepositorioDocumento>
    {
        public RepositorioDocumento(ContextoParaBaseDatos contexto) : base(contexto) { }

        public long RegistrarDocumento(RegistraDocumento request)
        {
            long CodigoDocumento = 0;
            int result;
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int CodDocumento = 0;

                parametrosIn.Add("@CodigoItinerario", request.CodigoItinerario);
                parametrosIn.Add("@CodigoPuertoOrigenDocumento", request.CodigoPuertoOrigenDocumento);
                parametrosIn.Add("@CodigoPuertoEmbarqueDocumento", request.CodigoPuertoEmbarqueDocumento);
                parametrosIn.Add("@CodigoPuertoDescargaDocumento", request.CodigoPuertoDescargaDocumento);
                parametrosIn.Add("@CodigoPuertoFinalDocumento", request.CodigoPuertoFinalDocumento);
                parametrosIn.Add("@CodigoLineaNaviera", request.CodigoLineaNaviera);
                parametrosIn.Add("@CodigoAduana", request.CodigoAduana);
                parametrosIn.Add("@CodigoTipoBL", request.CodigoTipoBL);
                parametrosIn.Add("@CodigoTipoEnvio", request.CodigoTipoEnvio);
                parametrosIn.Add("@CodigoCondicionContrato", request.CodigoCondicionContrato);
                parametrosIn.Add("@CodigoRequerimientoServicio", request.CodigoRequerimientoServicio);
                parametrosIn.Add("@NumeroDocumento", request.NumeroDocumento);
                parametrosIn.Add("@FechaEmisionDocumento", request.FechaEmisionDocumento);
                parametrosIn.Add("@FechaEmbarqueDocumento", request.FechaEmbarqueDocumento);
                parametrosIn.Add("@UsuarioRegistro", request.UsuarioCreacion);

                parametrosOut.Add("@CodigoDocumento", CodDocumento);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_INSERTAR_DOCUMENTO", conexion, parametrosIn, true, parametrosOut))
                {
                    result = cmd.ExecuteNonQuery();
                    CodigoDocumento = long.Parse(cmd.Parameters["@CodigoDocumento"].Value.ToString());
                    SqlHelper.CloseConnection(conexion);
                }

            }
            return CodigoDocumento;
        }

        public long ModificarDocumento(RegistraDocumento request)
        {
            long result;
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();

                parametrosIn.Add("@CodigoDocumento", request.CodigoDocumento);
                parametrosIn.Add("@CodigoItinerario", request.CodigoItinerario);
                parametrosIn.Add("@CodigoPuertoOrigenDocumento", request.CodigoPuertoOrigenDocumento);
                parametrosIn.Add("@CodigoPuertoEmbarqueDocumento", request.CodigoPuertoEmbarqueDocumento);
                parametrosIn.Add("@CodigoPuertoDescargaDocumento", request.CodigoPuertoDescargaDocumento);
                parametrosIn.Add("@CodigoPuertoFinalDocumento", request.CodigoPuertoFinalDocumento);
                parametrosIn.Add("@CodigoLineaNaviera", request.CodigoLineaNaviera);
                parametrosIn.Add("@CodigoAduana", request.CodigoAduana);
                parametrosIn.Add("@CodigoTipoBL", request.CodigoTipoBL);
                parametrosIn.Add("@CodigoTipoEnvio", request.CodigoTipoEnvio);
                parametrosIn.Add("@CodigoCondicionContrato", request.CodigoCondicionContrato);
                parametrosIn.Add("@CodigoRequerimientoServicio", request.CodigoRequerimientoServicio);
                parametrosIn.Add("@NumeroDocumento", request.NumeroDocumento);
                parametrosIn.Add("@FechaEmisionDocumento", request.FechaEmisionDocumento);
                parametrosIn.Add("@FechaEmbarqueDocumento", request.FechaEmbarqueDocumento);
                parametrosIn.Add("@EstadoRegistro", request.EstadoRegistro);
                parametrosIn.Add("@UsuarioRegistro", request.UsuarioActualizacion);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_MODIFICAR_DOCUMENTO", conexion, parametrosIn, true))
                {
                    result = cmd.ExecuteNonQuery();
                    SqlHelper.CloseConnection(conexion);
                }

            }
            return result;
        }

        public bool RegistrarDocumentoDetalleCarga(List<DocumentoDetalleCarga> request)
        {
            int rows = 0;

            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB"));

            Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
            var DocumentoDetalleCargaDataTable = request.ToDataTable();
            parametrosIn.Add("@dtDocumentoDetalleCarga", DocumentoDetalleCargaDataTable);

            using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_REGISTRAR_DOCUMENTODETALLECARGA", conexion, parametrosIn, true))
            {
                rows = cmd.ExecuteNonQuery();
                SqlHelper.CloseConnection(conexion);
            }

            return rows > 0;
        }

        public bool RegistrarDocumentoDetalleCliente(List<DocumentoDetalleCliente> request)
        {
            int rows = 0;

            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB"));

            Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
            var DocumentoDetalleClienteDataTable = request.ToDataTable();
            parametrosIn.Add("@dtDocumentoDetalleCliente", DocumentoDetalleClienteDataTable);

            using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_REGISTRAR_DOCUMENTODETALLECLIENTE", conexion, parametrosIn, true))
            {
                rows = cmd.ExecuteNonQuery();
                SqlHelper.CloseConnection(conexion);
            }

            return rows > 0;
        }

        public bool RegistrarDocumentoDetalleFlete(List<DocumentoDetalleFlete> request)
        {
            int rows = 0;

            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB"));

            Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
            var DocumentoDetalleFleteDataTable = request.ToDataTable();
            parametrosIn.Add("@dtDocumentoDetalleFlete", DocumentoDetalleFleteDataTable);

            using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_REGISTRAR_DOCUMENTODETALLEFLETE", conexion, parametrosIn, true))
            {
                rows = cmd.ExecuteNonQuery();
                SqlHelper.CloseConnection(conexion);
            }

            return rows > 0;
        }

        public ResponseConsultarDocumento ConsultarDocumento(RequestConsultarDocumento request)
        {
            var response = new ResponseConsultarDocumento();
            var listaDocumento = new List<Documento>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoDocumento", request.CodigoDocumento);
                parametrosIn.Add("@CodigoItinerario", request.CodigoItinerario);
                parametrosIn.Add("@CodigoPuertoOrigenDocumento", request.CodigoPuertoOrigenDocumento);
                parametrosIn.Add("@CodigoPuertoEmbarqueDocumento", request.CodigoPuertoEmbarqueDocumento);
                parametrosIn.Add("@CodigoPuertoDescargaDocumento", request.CodigoPuertoDescargaDocumento);
                parametrosIn.Add("@CodigoPuertoFinalDocumento", request.CodigoPuertoFinalDocumento);
                parametrosIn.Add("@CodigoLineaNaviera", request.CodigoLineaNaviera);
                parametrosIn.Add("@CodigoAduana", request.CodigoAduana);
                parametrosIn.Add("@CodigoTipoBL", request.CodigoTipoBL);
                parametrosIn.Add("@CodigoTipoEnvio", request.CodigoTipoEnvio);
                parametrosIn.Add("@NumeroDocumento", request.NumeroDocumento);
                parametrosIn.Add("@FechaEmisionDocumentoInicio", request.FechaEmisionDocumentoInicio);
                parametrosIn.Add("@FechaEmisionDocumentoFin", request.FechaEmisionDocumentoFin);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_DOCUMENTO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Documento Documento = new Documento();
                            Documento.CodigoDocumento = dr.GetInt64(dr.GetOrdinal("CodigoDocumento"));
                            Documento.NombreNave = dr.GetString(dr.GetOrdinal("NombreNave")).Trim();
                            Documento.NumeroViajeItinerario = dr.GetString(dr.GetOrdinal("NumeroViajeItinerario")).Trim();
                            Documento.NombrePuertoOrigenDocumento = dr.GetString(dr.GetOrdinal("NombrePuertoOrigenDocumento")).Trim();
                            Documento.NombrePuertoEmbarqueDocumento = dr.GetString(dr.GetOrdinal("NombrePuertoEmbarqueDocumento")).Trim();
                            Documento.NombrePuertoDescargaDocumento = dr.GetString(dr.GetOrdinal("NombrePuertoDescargaDocumento")).Trim();
                            Documento.NombrePuertoFinalDocumento = dr.GetString(dr.GetOrdinal("NombrePuertoFinalDocumento")).Trim();
                            Documento.NombreLineaNaviera = dr.GetString(dr.GetOrdinal("NombreLineaNaviera")).Trim();
                            Documento.NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento")).Trim();
                            Documento.NombreAduana = dr.GetString(dr.GetOrdinal("NombreAduana")).Trim();
                            Documento.NombreTipoBL = dr.GetString(dr.GetOrdinal("NombreTipoBL")).Trim();
                            Documento.NombreTipoEnvio = dr.GetString(dr.GetOrdinal("NombreTipoEnvio")).Trim();
                            Documento.FechaEmisionDocumento = dr.IsDBNull(dr.GetOrdinal("FechaEmisionDocumento")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaEmisionDocumento"));
                            Documento.FechaEmbarqueDocumento = dr.IsDBNull(dr.GetOrdinal("FechaEmbarqueDocumento")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaEmbarqueDocumento"));
                            Documento.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            Documento.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            Documento.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            Documento.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaDocumento.Add(Documento);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaDocumento = listaDocumento;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());

                }

            }
            return response;
        }

        public ResponseConsultarDocumento ValidarDocumento(RequestConsultarDocumento request)
        {
            var response = new ResponseConsultarDocumento();
            var listaDocumento = new List<Documento>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();

                parametrosIn.Add("@CodigoDocumento", request.CodigoDocumento);
                parametrosIn.Add("@CodigoItinerario", request.CodigoItinerario);
                parametrosIn.Add("@CodigoPuertoOrigenDocumento", request.CodigoPuertoOrigenDocumento);
                parametrosIn.Add("@CodigoPuertoEmbarqueDocumento", request.CodigoPuertoEmbarqueDocumento);
                parametrosIn.Add("@CodigoPuertoDescargaDocumento", request.CodigoPuertoDescargaDocumento);
                parametrosIn.Add("@CodigoPuertoFinalDocumento", request.CodigoPuertoFinalDocumento);
                parametrosIn.Add("@CodigoLineaNaviera", request.CodigoLineaNaviera);
                parametrosIn.Add("@CodigoAduana", request.CodigoAduana);
                parametrosIn.Add("@NumeroDocumento", request.NumeroDocumento);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_VALIDAR_DOCUMENTO", conexion, parametrosIn, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Documento Documento = new Documento();
                            Documento.NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento")).Trim();
                            listaDocumento.Add(Documento);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaDocumento = listaDocumento;

                }
            }
            return response;
        }

        public List<DetalleDocumento> ConsultarDetalleDocumento(ConsultaDetalleDocumento request)
        { // lstDocumentoDetalleFlete
            List<DetalleDocumento> lsDetalleDocumento = new List<DetalleDocumento>();
            List<DocumentoDetalleCargaConsulta> lstDocumentoDetalleCarga = new List<DocumentoDetalleCargaConsulta>();
            List<DocumentoDetalleClienteConsulta> lstDocumentoDetalleCliente = new List<DocumentoDetalleClienteConsulta>();
            List<DocumentoDetalleFleteConsulta> lstDocumentoDetalleFlete = new List<DocumentoDetalleFleteConsulta>();

            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();

                parametrosIn.Add("@CodigoDocumento", request.CodigoDocumento);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_DETALLE_DOCUMENTO", conexion, parametrosIn, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            DetalleDocumento Documento = new DetalleDocumento();

                            Documento.CodigoDocumento = dr.IsDBNull(dr.GetOrdinal("CodigoDocumento")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoDocumento"));
                            Documento.CodigoItinerario = dr.IsDBNull(dr.GetOrdinal("CodigoItinerario")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoItinerario"));
                            Documento.NombreNave = dr.IsDBNull(dr.GetOrdinal("NombreNave")) ? "" : dr.GetString(dr.GetOrdinal("NombreNave")).Trim();
                            Documento.NumeroViajeItinerario = dr.IsDBNull(dr.GetOrdinal("NumeroViajeItinerario")) ? "" : dr.GetString(dr.GetOrdinal("NumeroViajeItinerario")).Trim();
                            Documento.NombreAduanaNave = dr.IsDBNull(dr.GetOrdinal("NombreAduanaNave")) ? "" : dr.GetString(dr.GetOrdinal("NombreAduanaNave")).Trim();
                            Documento.NombreTipoOperacion = dr.IsDBNull(dr.GetOrdinal("NombreTipoOperacion")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoOperacion")).Trim();
                            Documento.CodigoPuertoOrigenDocumento = dr.IsDBNull(dr.GetOrdinal("CodigoPuertoOrigenDocumento")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoPuertoOrigenDocumento"));
                            Documento.NombrePuertoOrigen = dr.IsDBNull(dr.GetOrdinal("NombrePuertoOrigen")) ? "" : dr.GetString(dr.GetOrdinal("NombrePuertoOrigen")).Trim();
                            Documento.CodigoPuertoEmbarqueDocumento = dr.IsDBNull(dr.GetOrdinal("CodigoPuertoEmbarqueDocumento")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoPuertoEmbarqueDocumento"));
                            Documento.NombrePuertoEmbarque = dr.IsDBNull(dr.GetOrdinal("NombrePuertoEmbarque")) ? "" : dr.GetString(dr.GetOrdinal("NombrePuertoEmbarque")).Trim();
                            Documento.CodigoPuertoDescargaDocumento = dr.IsDBNull(dr.GetOrdinal("CodigoPuertoDescargaDocumento")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoPuertoDescargaDocumento"));
                            Documento.NombrePuertoDescarga = dr.IsDBNull(dr.GetOrdinal("NombrePuertoDescarga")) ? "" : dr.GetString(dr.GetOrdinal("NombrePuertoDescarga")).Trim();
                            Documento.CodigoPuertoFinalDocumento = dr.IsDBNull(dr.GetOrdinal("CodigoPuertoFinalDocumento")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoPuertoFinalDocumento"));
                            Documento.NombrePuertoFinal = dr.IsDBNull(dr.GetOrdinal("NombrePuertoFinal")) ? "" : dr.GetString(dr.GetOrdinal("NombrePuertoFinal")).Trim();
                            Documento.CodigoLineaNaviera = dr.IsDBNull(dr.GetOrdinal("CodigoLineaNaviera")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoLineaNaviera"));
                            Documento.NombreLineaNaviera = dr.IsDBNull(dr.GetOrdinal("NombreLineaNaviera")) ? "" : dr.GetString(dr.GetOrdinal("NombreLineaNaviera")).Trim();
                            Documento.CodigoAduana = dr.IsDBNull(dr.GetOrdinal("CodigoAduana")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoAduana"));
                            Documento.NombreAduana = dr.IsDBNull(dr.GetOrdinal("NombreAduana")) ? "" : dr.GetString(dr.GetOrdinal("NombreAduana")).Trim();
                            Documento.CodigoTipoBL = dr.IsDBNull(dr.GetOrdinal("CodigoTipoBL")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoTipoBL"));
                            Documento.NombreTipoBL = dr.IsDBNull(dr.GetOrdinal("NombreTipoBL")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoBL")).Trim();
                            Documento.CodigoTipoEnvio = dr.IsDBNull(dr.GetOrdinal("CodigoTipoEnvio")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoTipoEnvio"));
                            Documento.NombreTipoEnvio = dr.IsDBNull(dr.GetOrdinal("NombreTipoEnvio")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoEnvio")).Trim();
                            Documento.CodigoCondicionContrato = dr.IsDBNull(dr.GetOrdinal("CodigoCondicionContrato")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoCondicionContrato"));
                            Documento.NombreCondicionContrato = dr.IsDBNull(dr.GetOrdinal("NombreCondicionContrato")) ? "" : dr.GetString(dr.GetOrdinal("NombreCondicionContrato")).Trim();
                            Documento.CodigoRequerimientoServicio = dr.IsDBNull(dr.GetOrdinal("CodigoRequerimientoServicio")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoRequerimientoServicio"));
                            Documento.NombreRequerimientoServicio = dr.IsDBNull(dr.GetOrdinal("NombreRequerimientoServicio")) ? "" : dr.GetString(dr.GetOrdinal("NombreRequerimientoServicio")).Trim();
                            Documento.NumeroDocumento = dr.IsDBNull(dr.GetOrdinal("NumeroDocumento")) ? "" : dr.GetString(dr.GetOrdinal("NumeroDocumento")).Trim();
                            Documento.FechaEmisionDocumento = dr.IsDBNull(dr.GetOrdinal("FechaEmisionDocumento")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaEmisionDocumento"));
                            Documento.FechaEmbarqueDocumento = dr.IsDBNull(dr.GetOrdinal("FechaEmbarqueDocumento")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaEmbarqueDocumento"));
                            Documento.EstadoRegistro = dr.GetBoolean(dr.GetOrdinal("EstadoRegistro"));
                            Documento.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            Documento.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            Documento.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            Documento.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            lsDetalleDocumento.Add(Documento);
                        }

                        dr.NextResult();

                        while (dr.Read())
                        {
                            DocumentoDetalleCargaConsulta DetalleCargaConsulta = new DocumentoDetalleCargaConsulta();
                            {
                                DetalleCargaConsulta.CodigoDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("CodigoDocumentoDetalleCarga")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoDocumentoDetalleCarga"));
                                DetalleCargaConsulta.CodigoDocumento = dr.IsDBNull(dr.GetOrdinal("CodigoDocumento")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoDocumento"));
                                DetalleCargaConsulta.CodigoContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoContenedor")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoContenedor"));
                                DetalleCargaConsulta.NumeroContenedor = dr.IsDBNull(dr.GetOrdinal("NumeroContenedor")) ? "" : dr.GetString(dr.GetOrdinal("NumeroContenedor")).Trim();
                                DetalleCargaConsulta.NombreTipoContenedor = dr.IsDBNull(dr.GetOrdinal("NombreTipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoContenedor")).Trim();
                                DetalleCargaConsulta.TamanioTipoContenedor = dr.IsDBNull(dr.GetOrdinal("TamanioTipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("TamanioTipoContenedor")).Trim();
                                DetalleCargaConsulta.CodigoCondicionTransporte = dr.IsDBNull(dr.GetOrdinal("CodigoCondicionTransporte")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoCondicionTransporte"));
                                DetalleCargaConsulta.NombreCondicionTransporte = dr.IsDBNull(dr.GetOrdinal("NombreCondicionTransporte")) ? "" : dr.GetString(dr.GetOrdinal("NombreCondicionTransporte")).Trim();
                                DetalleCargaConsulta.CodigoTipoMovimiento = dr.IsDBNull(dr.GetOrdinal("CodigoTipoMovimiento")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoTipoMovimiento"));
                                DetalleCargaConsulta.NombreTipoMovimiento = dr.IsDBNull(dr.GetOrdinal("NombreTipoMovimiento")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoMovimiento")).Trim();
                                DetalleCargaConsulta.CodigoUnidadMercancia = dr.IsDBNull(dr.GetOrdinal("CodigoUnidadMercancia")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoUnidadMercancia"));
                                DetalleCargaConsulta.NombreUnidadMercancia = dr.IsDBNull(dr.GetOrdinal("NombreUnidadMercancia")) ? "" : dr.GetString(dr.GetOrdinal("NombreUnidadMercancia")).Trim();
                                DetalleCargaConsulta.CodigoNaturalezaCarga = dr.IsDBNull(dr.GetOrdinal("CodigoNaturalezaCarga")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoNaturalezaCarga"));
                                DetalleCargaConsulta.NombreNaturalezaCarga = dr.IsDBNull(dr.GetOrdinal("NombreNaturalezaCarga")) ? "" : dr.GetString(dr.GetOrdinal("NombreNaturalezaCarga")).Trim();
                                DetalleCargaConsulta.CodigoCondicionCarga = dr.IsDBNull(dr.GetOrdinal("CodigoCondicionCarga")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoCondicionCarga"));
                                DetalleCargaConsulta.NombreCondicionCarga = dr.IsDBNull(dr.GetOrdinal("NombreCondicionCarga")) ? "" : dr.GetString(dr.GetOrdinal("NombreCondicionCarga")).Trim();
                                DetalleCargaConsulta.CodigoTemperatura = dr.IsDBNull(dr.GetOrdinal("CodigoTemperatura")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoTemperatura"));
                                DetalleCargaConsulta.NombreTemperatura = dr.IsDBNull(dr.GetOrdinal("NombreTemperatura")) ? "" : dr.GetString(dr.GetOrdinal("NombreTemperatura")).Trim();
                                DetalleCargaConsulta.CodigoClaseIMO = dr.IsDBNull(dr.GetOrdinal("CodigoClaseIMO")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoClaseIMO"));
                                DetalleCargaConsulta.NombreClaseIMO = dr.IsDBNull(dr.GetOrdinal("NombreClaseIMO")) ? "" : dr.GetString(dr.GetOrdinal("NombreClaseIMO")).Trim();
                                DetalleCargaConsulta.CodigoNumeroIMO = dr.IsDBNull(dr.GetOrdinal("CodigoNumeroIMO")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoNumeroIMO"));
                                DetalleCargaConsulta.NombreNumeroIMO = dr.IsDBNull(dr.GetOrdinal("NombreNumeroIMO")) ? "" : dr.GetString(dr.GetOrdinal("NombreNumeroIMO")).Trim();
                                DetalleCargaConsulta.CodigoAlmacenDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("CodigoAlmacenDocumentoDetalleCarga")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoAlmacenDocumentoDetalleCarga"));
                                DetalleCargaConsulta.NombreAlmacen = dr.IsDBNull(dr.GetOrdinal("NombreAlmacen")) ? "" : dr.GetString(dr.GetOrdinal("NombreAlmacen")).Trim();
                                DetalleCargaConsulta.CodigoDepositoDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("CodigoDepositoDocumentoDetalleCarga")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoDepositoDocumentoDetalleCarga"));
                                DetalleCargaConsulta.NombreDeposito = dr.IsDBNull(dr.GetOrdinal("NombreDeposito")) ? "" : dr.GetString(dr.GetOrdinal("NombreDeposito")).Trim();
                                DetalleCargaConsulta.CodigoPrecinto = dr.IsDBNull(dr.GetOrdinal("CodigoPrecinto")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoPrecinto"));
                                DetalleCargaConsulta.NumeroPrecinto = dr.IsDBNull(dr.GetOrdinal("NumeroPrecinto")) ? "" : dr.GetString(dr.GetOrdinal("NumeroPrecinto")).Trim();
                                DetalleCargaConsulta.ItemDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("ItemDocumentoDetalleCarga")) ? 0 : dr.GetInt32(dr.GetOrdinal("ItemDocumentoDetalleCarga"));
                                DetalleCargaConsulta.CantidadBultoDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("CantidadBultoDocumentoDetalleCarga")) ? 0 : dr.GetInt32(dr.GetOrdinal("CantidadBultoDocumentoDetalleCarga"));
                                DetalleCargaConsulta.PesoBrutoDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("PesoBrutoDocumentoDetalleCarga")) ? new Nullable<Decimal>() : dr.GetDecimal(dr.GetOrdinal("PesoBrutoDocumentoDetalleCarga"));
                                DetalleCargaConsulta.VolumenBrutoDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("VolumenBrutoDocumentoDetalleCarga")) ? new Nullable<Decimal>() : dr.GetDecimal(dr.GetOrdinal("VolumenBrutoDocumentoDetalleCarga"));
                                DetalleCargaConsulta.TemperaturaMinimaDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("TemperaturaMinimaDocumentoDetalleCarga")) ? new Nullable<Decimal>() : dr.GetDecimal(dr.GetOrdinal("TemperaturaMinimaDocumentoDetalleCarga"));
                                DetalleCargaConsulta.TemperaturaMaximaDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("TemperaturaMaximaDocumentoDetalleCarga")) ? new Nullable<Decimal>() : dr.GetDecimal(dr.GetOrdinal("TemperaturaMaximaDocumentoDetalleCarga"));
                                DetalleCargaConsulta.PropietarioDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("PropietarioDocumentoDetalleCarga")) ? false : dr.GetBoolean(dr.GetOrdinal("PropietarioDocumentoDetalleCarga"));
                                DetalleCargaConsulta.ObservacionDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("ObservacionDocumentoDetalleCarga")) ? "" : dr.GetString(dr.GetOrdinal("ObservacionDocumentoDetalleCarga")).Trim();
                                DetalleCargaConsulta.DescripcionDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("DescripcionDocumentoDetalleCarga")) ? "" : dr.GetString(dr.GetOrdinal("DescripcionDocumentoDetalleCarga")).Trim();
                                DetalleCargaConsulta.MarcasNumerosDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("MarcasNumerosDocumentoDetalleCarga")) ? "" : dr.GetString(dr.GetOrdinal("MarcasNumerosDocumentoDetalleCarga")).Trim();
                                DetalleCargaConsulta.FaltoDocumentoDetalleCarga = dr.IsDBNull(dr.GetOrdinal("FaltoDocumentoDetalleCarga")) ? false : dr.GetBoolean(dr.GetOrdinal("FaltoDocumentoDetalleCarga"));
                            };

                            lstDocumentoDetalleCarga.Add(DetalleCargaConsulta);
                        }

                        dr.NextResult();

                        while (dr.Read())
                        {
                            DocumentoDetalleClienteConsulta DetalleClienteConsulta = new DocumentoDetalleClienteConsulta();
                            {
                                DetalleClienteConsulta.CodigoDocumentoDetalleCliente = dr.IsDBNull(dr.GetOrdinal("CodigoDocumentoDetalleCliente")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoDocumentoDetalleCliente"));
                                DetalleClienteConsulta.CodigoDocumento = dr.IsDBNull(dr.GetOrdinal("CodigoDocumento")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoDocumento"));
                                DetalleClienteConsulta.CodigoRol = dr.IsDBNull(dr.GetOrdinal("CodigoRol")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoRol"));
                                DetalleClienteConsulta.NombreRol = dr.IsDBNull(dr.GetOrdinal("NombreRol")) ? "" : dr.GetString(dr.GetOrdinal("NombreRol")).Trim();
                                DetalleClienteConsulta.CodigoPersona = dr.IsDBNull(dr.GetOrdinal("CodigoPersona")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoPersona"));
                                DetalleClienteConsulta.RazonSocialPersona = dr.IsDBNull(dr.GetOrdinal("RazonSocialPersona")) ? "" : dr.GetString(dr.GetOrdinal("RazonSocialPersona")).Trim();
                            };

                            lstDocumentoDetalleCliente.Add(DetalleClienteConsulta);
                        }

                        dr.NextResult();

                        while (dr.Read())
                        {
                            DocumentoDetalleFleteConsulta DetalleFleteConsulta = new DocumentoDetalleFleteConsulta();
                            {
                                DetalleFleteConsulta.CodigoDocumentoDetalleFlete = dr.IsDBNull(dr.GetOrdinal("CodigoDocumentoDetalleFlete")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoDocumentoDetalleFlete"));
                                DetalleFleteConsulta.CodigoDocumento = dr.IsDBNull(dr.GetOrdinal("CodigoDocumento")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoDocumento"));
                                DetalleFleteConsulta.CodigoTipoFlete = dr.IsDBNull(dr.GetOrdinal("CodigoTipoFlete")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoTipoFlete"));
                                DetalleFleteConsulta.NombreTipoFlete = dr.IsDBNull(dr.GetOrdinal("NombreTipoFlete")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoFlete")).Trim();
                                DetalleFleteConsulta.CodigoMoneda = dr.IsDBNull(dr.GetOrdinal("CodigoMoneda")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoMoneda"));
                                DetalleFleteConsulta.NombreMoneda = dr.IsDBNull(dr.GetOrdinal("NombreMoneda")) ? "" : dr.GetString(dr.GetOrdinal("NombreMoneda")).Trim();
                                DetalleFleteConsulta.CodigoModoPago = dr.IsDBNull(dr.GetOrdinal("CodigoModoPago")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoModoPago"));
                                DetalleFleteConsulta.NombreModoPago = dr.IsDBNull(dr.GetOrdinal("NombreModoPago")) ? "" : dr.GetString(dr.GetOrdinal("NombreModoPago")).Trim();
                                DetalleFleteConsulta.MontoDocumentoDetalleFlete = dr.IsDBNull(dr.GetOrdinal("MontoDocumentoDetalleFlete")) ? new Nullable<Decimal>() : dr.GetDecimal(dr.GetOrdinal("MontoDocumentoDetalleFlete"));
                            };

                            lstDocumentoDetalleFlete.Add(DetalleFleteConsulta);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }

                    foreach (var objDocumento in lsDetalleDocumento)
                    {
                        objDocumento.ListaDocumentoDetalleCarga = lstDocumentoDetalleCarga.Where(x => x.CodigoDocumento == objDocumento.CodigoDocumento).ToList();
                        objDocumento.ListaDocumentoDetalleCliente = lstDocumentoDetalleCliente.Where(x => x.CodigoDocumento == objDocumento.CodigoDocumento).ToList();
                        objDocumento.ListaDocumentoDetalleFlete = lstDocumentoDetalleFlete.Where(x => x.CodigoDocumento == objDocumento.CodigoDocumento).ToList();
                    }
                }
            }

            return lsDetalleDocumento;

        }
    }
}
