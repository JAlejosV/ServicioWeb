using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Documento;
using TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Documento.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Documento.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Nave;
using TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Nave.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Nave.Response;
using TRAMARSA.TRANSMISIONES.Framework;

namespace TRAMARSA.TRANSMISIONES.AccesoDatos
{
    public class RepositorioTransmisiones : RepositorioBase<RepositorioTransmisiones>
    {
        public RepositorioTransmisiones(ContextoParaBaseDatos contexto) : base(contexto) { }

        public ResponseConsultarTransmisionNave ConsultarTransmisionNave(RequestConsultarTransmisionNave request)
        {
            var response = new ResponseConsultarTransmisionNave();
            var listaTransmisionNave = new List<TransmisionNave>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoItinerario", request.CodigoItinerario);
                parametrosIn.Add("@CodigoNave", request.CodigoNave);
                parametrosIn.Add("@CodigoAduana", request.CodigoAduana);
                parametrosIn.Add("@CodigoTipoOperacion", request.CodigoTipoOperacion);
                parametrosIn.Add("@NumeroViajeItinerario", request.NumeroViajeItinerario);
                parametrosIn.Add("@NumeroManifiestoItinerario", request.NumeroManifiestoItinerario);
                parametrosIn.Add("@AnioManifiestoItinerario", request.AnioManifiestoItinerario);
                parametrosIn.Add("@EstadoEnvioAduanas", request.EstadoEnvioAduanas);
                parametrosIn.Add("@EstadoTransmision", request.EstadoTransmision);
                parametrosIn.Add("@FechaInicio", request.FechaInicio);
                parametrosIn.Add("@FechaFin", request.FechaFin);
                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_TRANSMISION_NAVES", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TransmisionNave TransmisionNave = new TransmisionNave();
                            TransmisionNave.CodigoItinerario = dr.GetInt64(dr.GetOrdinal("CodigoItinerario"));
                            TransmisionNave.AnioManifiestoItinerario = dr.IsDBNull(dr.GetOrdinal("AnioManifiestoItinerario")) ? 0 : dr.GetInt32(dr.GetOrdinal("AnioManifiestoItinerario"));
                            TransmisionNave.NumeroManifiestoItinerario = dr.IsDBNull(dr.GetOrdinal("NumeroManifiestoItinerario")) ? "" : dr.GetString(dr.GetOrdinal("NumeroManifiestoItinerario")).Trim();
                            TransmisionNave.NombreNave = dr.IsDBNull(dr.GetOrdinal("NombreNave")) ? "" : dr.GetString(dr.GetOrdinal("NombreNave")).Trim();
                            TransmisionNave.NumeroViajeItinerario = dr.IsDBNull(dr.GetOrdinal("NumeroViajeItinerario")) ? "" : dr.GetString(dr.GetOrdinal("NumeroViajeItinerario")).Trim();
                            TransmisionNave.NombreAduana = dr.IsDBNull(dr.GetOrdinal("NombreAduana")) ? "" : dr.GetString(dr.GetOrdinal("NombreAduana")).Trim();
                            TransmisionNave.NombreTipoOperacion = dr.IsDBNull(dr.GetOrdinal("NombreTipoOperacion")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoOperacion")).Trim();
                            TransmisionNave.NombreOperadorDescargaItinerario = dr.IsDBNull(dr.GetOrdinal("NombreOperadorDescargaItinerario")) ? "" : dr.GetString(dr.GetOrdinal("NombreOperadorDescargaItinerario")).Trim();
                            TransmisionNave.FechaArriboItinerario = dr.IsDBNull(dr.GetOrdinal("FechaArriboItinerario")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaArriboItinerario"));
                            TransmisionNave.TotalPesoBrutoTransmision = dr.IsDBNull(dr.GetOrdinal("TotalPesoBrutoTransmision")) ? new Nullable<Decimal>() : dr.GetDecimal(dr.GetOrdinal("TotalPesoBrutoTransmision"));
                            TransmisionNave.TotalBultosTransmision = dr.IsDBNull(dr.GetOrdinal("TotalBultosTransmision")) ? 0 : dr.GetInt64(dr.GetOrdinal("TotalBultosTransmision"));
                            TransmisionNave.TotalContenedoresTransmision = dr.IsDBNull(dr.GetOrdinal("TotalContenedoresTransmision")) ? 0 : dr.GetInt64(dr.GetOrdinal("TotalContenedoresTransmision"));
                            //TransmisionNave.EstadoEnvioAduanas = dr.IsDBNull(dr.GetOrdinal("EstadoEnvioAduanas")) ? false : dr.GetBoolean(dr.GetOrdinal("EstadoEnvioAduanas"));
                            TransmisionNave.EstadoEnvioAduanas = dr.GetBoolean(dr.GetOrdinal("EstadoEnvioAduanas"));
                            //TransmisionNave.EstadoTransmision = dr.IsDBNull(dr.GetOrdinal("EstadoTransmision")) ? false : dr.GetBoolean(dr.GetOrdinal("EstadoTransmision"));
                            TransmisionNave.EstadoTransmision = dr.GetBoolean(dr.GetOrdinal("EstadoTransmision"));
                            TransmisionNave.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            listaTransmisionNave.Add(TransmisionNave);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaTransmisionNave = listaTransmisionNave;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseConsultarTransmisionDocumento ConsultarTransmisionDocumento(RequestConsultarTransmisionDocumento request)
        {
            var response = new ResponseConsultarTransmisionDocumento();
            var listaTransmisionDocumento = new List<TransmisionDocumento>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoDocumento", request.CodigoDocumento);
                parametrosIn.Add("@CodigoItinerario", request.CodigoItinerario);
                parametrosIn.Add("@NumeroManifiestoItinerario", request.NumeroManifiestoItinerario);
                parametrosIn.Add("@AnioManifiestoItinerario", request.AnioManifiestoItinerario);
                parametrosIn.Add("@NumeroDocumento", request.NumeroDocumento);
                parametrosIn.Add("@CodigoTipoEnvio", request.CodigoTipoEnvio);
                parametrosIn.Add("@EstadoEnvioAduanas", request.EstadoEnvioAduanas);
                parametrosIn.Add("@EstadoTransmision", request.EstadoTransmision);
                parametrosIn.Add("@FechaInicio", request.FechaInicio);
                parametrosIn.Add("@FechaFin", request.FechaFin);
                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_TRANSMISION_DOCUMENTOS", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TransmisionDocumento TransmisionDocumento = new TransmisionDocumento();
                            TransmisionDocumento.CodigoDocumento = dr.GetInt64(dr.GetOrdinal("CodigoDocumento"));
                            TransmisionDocumento.NumeroDocumento = dr.IsDBNull(dr.GetOrdinal("NumeroDocumento")) ? "" : dr.GetString(dr.GetOrdinal("NumeroDocumento")).Trim();
                            TransmisionDocumento.NombreNave = dr.IsDBNull(dr.GetOrdinal("NombreNave")) ? "" : dr.GetString(dr.GetOrdinal("NombreNave")).Trim();
                            TransmisionDocumento.NumeroViajeItinerario = dr.IsDBNull(dr.GetOrdinal("NumeroViajeItinerario")) ? "" : dr.GetString(dr.GetOrdinal("NumeroViajeItinerario")).Trim();
                            TransmisionDocumento.AnioManifiestoItinerario = dr.IsDBNull(dr.GetOrdinal("AnioManifiestoItinerario")) ? 0 : dr.GetInt32(dr.GetOrdinal("AnioManifiestoItinerario"));
                            TransmisionDocumento.NumeroManifiestoItinerario = dr.IsDBNull(dr.GetOrdinal("NumeroManifiestoItinerario")) ? "" : dr.GetString(dr.GetOrdinal("NumeroManifiestoItinerario")).Trim();
                            TransmisionDocumento.NombreAduana = dr.IsDBNull(dr.GetOrdinal("NombreAduana")) ? "" : dr.GetString(dr.GetOrdinal("NombreAduana")).Trim();
                            TransmisionDocumento.NombreTipoEnvio = dr.IsDBNull(dr.GetOrdinal("NombreTipoEnvio")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoEnvio")).Trim();
                            TransmisionDocumento.TotalPesoBrutoTransmision = dr.IsDBNull(dr.GetOrdinal("TotalPesoBrutoTransmision")) ? new Nullable<Decimal>() : dr.GetDecimal(dr.GetOrdinal("TotalPesoBrutoTransmision"));
                            TransmisionDocumento.TotalBultosTransmision = dr.IsDBNull(dr.GetOrdinal("TotalBultosTransmision")) ? 0 : dr.GetInt64(dr.GetOrdinal("TotalBultosTransmision"));
                            TransmisionDocumento.TotalContenedoresTransmision = dr.IsDBNull(dr.GetOrdinal("TotalContenedoresTransmision")) ? 0 : dr.GetInt64(dr.GetOrdinal("TotalContenedoresTransmision"));
                            TransmisionDocumento.Consignatario = dr.IsDBNull(dr.GetOrdinal("Consignatario")) ? "" : dr.GetString(dr.GetOrdinal("Consignatario")).Trim();
                            TransmisionDocumento.Embarcador = dr.IsDBNull(dr.GetOrdinal("Embarcador")) ? "" : dr.GetString(dr.GetOrdinal("Embarcador")).Trim();
                            TransmisionDocumento.PuertoEmbarque = dr.IsDBNull(dr.GetOrdinal("PuertoEmbarque")) ? "" : dr.GetString(dr.GetOrdinal("PuertoEmbarque")).Trim();
                            TransmisionDocumento.PuertoFinal = dr.IsDBNull(dr.GetOrdinal("PuertoFinal")) ? "" : dr.GetString(dr.GetOrdinal("PuertoFinal")).Trim();
                            TransmisionDocumento.EstadoEnvioAduanas = dr.GetBoolean(dr.GetOrdinal("EstadoEnvioAduanas"));
                            TransmisionDocumento.EstadoTransmision = dr.GetBoolean(dr.GetOrdinal("EstadoTransmision"));
                            TransmisionDocumento.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            listaTransmisionDocumento.Add(TransmisionDocumento);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaTransmisionDocumento = listaTransmisionDocumento;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseConsultarLogTransmisionNave ConsultarLogTransmisionNave(RequestConsultarLogTransmisionNave request)
        {
            var response = new ResponseConsultarLogTransmisionNave();
            var listaLogTransmisionNave = new List<LogTransmisionNave>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoItinerario", request.CodigoItinerario);
                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_LOG_TRANSMISION_NAVES", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            LogTransmisionNave LogTransmisionNave = new LogTransmisionNave();
                            LogTransmisionNave.CodigoItinerario = dr.GetInt64(dr.GetOrdinal("CodigoItinerario"));
                            LogTransmisionNave.CampoLogTransmisionItinerario = dr.IsDBNull(dr.GetOrdinal("CampoLogTransmisionItinerario")) ? "" : dr.GetString(dr.GetOrdinal("CampoLogTransmisionItinerario")).Trim();
                            LogTransmisionNave.ValorLogTransmisionItinerario = dr.IsDBNull(dr.GetOrdinal("ValorLogTransmisionItinerario")) ? "" : dr.GetString(dr.GetOrdinal("ValorLogTransmisionItinerario")).Trim();
                            LogTransmisionNave.TextoLogTransmisionItinerario = dr.IsDBNull(dr.GetOrdinal("TextoLogTransmisionItinerario")) ? "" : dr.GetString(dr.GetOrdinal("TextoLogTransmisionItinerario")).Trim();
                            LogTransmisionNave.FechaLogTransmisionItinerario = dr.IsDBNull(dr.GetOrdinal("FechaLogTransmisionItinerario")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaLogTransmisionItinerario"));
                            listaLogTransmisionNave.Add(LogTransmisionNave);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaLogTransmisionNave = listaLogTransmisionNave;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseConsultarLogTransmisionDocumento ConsultarLogTransmisionDocumento(RequestConsultarLogTransmisionDocumento request)
        {
            var response = new ResponseConsultarLogTransmisionDocumento();
            var listaLogTransmisionDocumento = new List<LogTransmisionDocumento>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoDocumento", request.CodigoDocumento);
                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_LOG_TRANSMISION_DOCUMENTOS", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            LogTransmisionDocumento LogTransmisionDocumento = new LogTransmisionDocumento();
                            LogTransmisionDocumento.CodigoDocumento = dr.GetInt64(dr.GetOrdinal("CodigoDocumento"));
                            LogTransmisionDocumento.CampoLogTransmisionDocumento = dr.IsDBNull(dr.GetOrdinal("CampoLogTransmisionDocumento")) ? "" : dr.GetString(dr.GetOrdinal("CampoLogTransmisionDocumento")).Trim();
                            LogTransmisionDocumento.ValorLogTransmisionDocumento = dr.IsDBNull(dr.GetOrdinal("ValorLogTransmisionDocumento")) ? "" : dr.GetString(dr.GetOrdinal("ValorLogTransmisionDocumento")).Trim();
                            LogTransmisionDocumento.TextoLogTransmisionDocumento = dr.IsDBNull(dr.GetOrdinal("TextoLogTransmisionDocumento")) ? "" : dr.GetString(dr.GetOrdinal("TextoLogTransmisionDocumento")).Trim();
                            LogTransmisionDocumento.FechaLogTransmisionDocumento = dr.IsDBNull(dr.GetOrdinal("FechaLogTransmisionDocumento")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaLogTransmisionDocumento"));
                            listaLogTransmisionDocumento.Add(LogTransmisionDocumento);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaLogTransmisionDocumento = listaLogTransmisionDocumento;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public long RegistraTransmisionNave(RegistraTransmisionNave request)
        {
            long result;
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();

                var DetalleTransmisionNave = request.ListaItinerarios.ToDataTable();
                parametrosIn.Add("@dtItinerarios", DetalleTransmisionNave);
                parametrosIn.Add("@TipoTransmision", request.TipoTransmision);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_REGISTRA_TRANSMISION_SUNAT_NAVES", conexion, parametrosIn, true))
                {
                    result = cmd.ExecuteNonQuery();
                    SqlHelper.CloseConnection(conexion);
                }

            }
            return result;
        }

        public long RegistraTransmisionDocumento(RegistraTransmisionDocumento request)
        {
            long result;
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();

                var DetalleTransmisionDocumento = request.ListaDocumentos.ToDataTable();
                parametrosIn.Add("@dtDocumentos", DetalleTransmisionDocumento);
                parametrosIn.Add("@TipoTransmision", request.TipoTransmision);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_REGISTRA_TRANSMISION_SUNAT_DOCUMENTOS", conexion, parametrosIn, true))
                {
                    result = cmd.ExecuteNonQuery();
                    SqlHelper.CloseConnection(conexion);
                }

            }
            return result;
        }
    }
}
