using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAMARSA.TRANSMISIONES.AccesoDatos;
using TRAMARSA.TRANSMISIONES.Entidades.Aduana;
using TRAMARSA.TRANSMISIONES.Entidades.Aduana.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Aduana.Response;
using TRAMARSA.TRANSMISIONES.Entidades.ClaseIMO;
using TRAMARSA.TRANSMISIONES.Entidades.ClaseIMO.Request;
using TRAMARSA.TRANSMISIONES.Entidades.ClaseIMO.Response;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionCarga;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionCarga.Request;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionCarga.Response;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionContrato;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionContrato.Request;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionContrato.Response;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionPrecinto;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionPrecinto.Request;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionPrecinto.Response;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionTransporte;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionTransporte.Request;
using TRAMARSA.TRANSMISIONES.Entidades.CondicionTransporte.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Contenedor;
using TRAMARSA.TRANSMISIONES.Entidades.Contenedor.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Contenedor.Response;
using TRAMARSA.TRANSMISIONES.Entidades.EntidadPrecinto;
using TRAMARSA.TRANSMISIONES.Entidades.EntidadPrecinto.Request;
using TRAMARSA.TRANSMISIONES.Entidades.EntidadPrecinto.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Itinerario;
using TRAMARSA.TRANSMISIONES.Entidades.Itinerario.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Itinerario.Response;
using TRAMARSA.TRANSMISIONES.Entidades.LineaNaviera;
using TRAMARSA.TRANSMISIONES.Entidades.LineaNaviera.Request;
using TRAMARSA.TRANSMISIONES.Entidades.LineaNaviera.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.CondicionCarga;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.CondicionContrato;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.CondicionTransporte;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.LineaNaviera;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.ModoPago;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.PersonaxRol;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.PersonaxRol.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.PersonaxRol.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.Rol;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.Temperatura;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.TipoBL;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.TipoEnvio;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.TipoOperacion;
using TRAMARSA.TRANSMISIONES.Entidades.Maestros.TipoTransmision;
using TRAMARSA.TRANSMISIONES.Entidades.MedioTransporte;
using TRAMARSA.TRANSMISIONES.Entidades.MedioTransporte.Request;
using TRAMARSA.TRANSMISIONES.Entidades.MedioTransporte.Response;
using TRAMARSA.TRANSMISIONES.Entidades.ModoPago;
using TRAMARSA.TRANSMISIONES.Entidades.ModoPago.Request;
using TRAMARSA.TRANSMISIONES.Entidades.ModoPago.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Moneda;
using TRAMARSA.TRANSMISIONES.Entidades.Moneda.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Moneda.Response;
using TRAMARSA.TRANSMISIONES.Entidades.NaturalezaCarga;
using TRAMARSA.TRANSMISIONES.Entidades.NaturalezaCarga.Request;
using TRAMARSA.TRANSMISIONES.Entidades.NaturalezaCarga.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Nave;
using TRAMARSA.TRANSMISIONES.Entidades.Nave.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Nave.Response;
using TRAMARSA.TRANSMISIONES.Entidades.NumeroIMO;
using TRAMARSA.TRANSMISIONES.Entidades.NumeroIMO.Request;
using TRAMARSA.TRANSMISIONES.Entidades.NumeroIMO.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Pais;
using TRAMARSA.TRANSMISIONES.Entidades.Pais.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Pais.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Precinto;
using TRAMARSA.TRANSMISIONES.Entidades.Precinto.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Precinto.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Puerto;
using TRAMARSA.TRANSMISIONES.Entidades.Puerto.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Puerto.Response;
using TRAMARSA.TRANSMISIONES.Entidades.RequerimientoServicio;
using TRAMARSA.TRANSMISIONES.Entidades.RequerimientoServicio.Request;
using TRAMARSA.TRANSMISIONES.Entidades.RequerimientoServicio.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Rol;
using TRAMARSA.TRANSMISIONES.Entidades.Rol.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Rol.Response;
using TRAMARSA.TRANSMISIONES.Entidades.Temperatura;
using TRAMARSA.TRANSMISIONES.Entidades.Temperatura.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Temperatura.Response;
using TRAMARSA.TRANSMISIONES.Entidades.TipoBL;
using TRAMARSA.TRANSMISIONES.Entidades.TipoBL.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoBL.Response;
using TRAMARSA.TRANSMISIONES.Entidades.TipoContenedor;
using TRAMARSA.TRANSMISIONES.Entidades.TipoContenedor.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoContenedor.Response;
using TRAMARSA.TRANSMISIONES.Entidades.TipoDocumento;
using TRAMARSA.TRANSMISIONES.Entidades.TipoDocumento.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoDocumento.Response;
using TRAMARSA.TRANSMISIONES.Entidades.TipoEnvio;
using TRAMARSA.TRANSMISIONES.Entidades.TipoEnvio.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoEnvio.Response;
using TRAMARSA.TRANSMISIONES.Entidades.TipoFlete;
using TRAMARSA.TRANSMISIONES.Entidades.TipoFlete.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoFlete.Response;
using TRAMARSA.TRANSMISIONES.Entidades.TipoLugarCarga;
using TRAMARSA.TRANSMISIONES.Entidades.TipoLugarCarga.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoLugarCarga.Response;
using TRAMARSA.TRANSMISIONES.Entidades.TipoMovimiento;
using TRAMARSA.TRANSMISIONES.Entidades.TipoMovimiento.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoMovimiento.Response;
using TRAMARSA.TRANSMISIONES.Entidades.TipoNave;
using TRAMARSA.TRANSMISIONES.Entidades.TipoNave.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoNave.Response;
using TRAMARSA.TRANSMISIONES.Entidades.TipoOperacion;
using TRAMARSA.TRANSMISIONES.Entidades.TipoOperacion.Request;
using TRAMARSA.TRANSMISIONES.Entidades.TipoOperacion.Response;
using TRAMARSA.TRANSMISIONES.Entidades.UnidadMercancia;
using TRAMARSA.TRANSMISIONES.Entidades.UnidadMercancia.Request;
using TRAMARSA.TRANSMISIONES.Entidades.UnidadMercancia.Response;
using TRAMARSA.TRANSMISIONES.Entidades.ViaTransporte;
using TRAMARSA.TRANSMISIONES.Entidades.ViaTransporte.Request;
using TRAMARSA.TRANSMISIONES.Entidades.ViaTransporte.Response;

namespace TRAMARSA.TRANSMISIONES.AccesoDatos
{
    public class RepositorioMaestros : RepositorioBase<RepositorioMaestros>
    {
        public RepositorioMaestros(ContextoParaBaseDatos contexto) : base(contexto) { }

        public ResponseRegistroPais RegistroPais(RequestRegistroPais request)
        {
            var response = new ResponseRegistroPais();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_PAIS", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoPais", request.CodigoPais);
                    parametrosIn.AddWithValue("@CodigoPaisSunat", request.CodigoPaisSunat);
                    parametrosIn.AddWithValue("@NombrePais", request.NombrePais);
                    parametrosIn.AddWithValue("@CodigoAlfaPais", request.CodigoAlfaPais);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarPais ConsultarPais(RequestConsultarPais request)
        {
            var response = new ResponseConsultarPais();
            var listaPais = new List<Pais>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoPais", request.CodigoPais);
                parametrosIn.Add("@CodigoPaisSunat", request.CodigoPaisSunat);
                parametrosIn.Add("@NombrePais", request.NombrePais);
                parametrosIn.Add("@CodigoAlfaPais", request.CodigoAlfaPais);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_PAIS", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Pais pais = new Pais();
                            pais.CodigoPais = dr.GetInt64(dr.GetOrdinal("CodigoPais"));
                            pais.CodigoPaisSunat = dr.IsDBNull(dr.GetOrdinal("CodigoPaisSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoPaisSunat")).Trim();
                            pais.NombrePais = dr.IsDBNull(dr.GetOrdinal("NombrePais")) ? "" : dr.GetString(dr.GetOrdinal("NombrePais")).Trim();
                            pais.CodigoAlfaPais = dr.IsDBNull(dr.GetOrdinal("CodigoAlfaPais")) ? "" : dr.GetString(dr.GetOrdinal("CodigoAlfaPais")).Trim();
                            pais.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            pais.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            pais.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            pais.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaPais.Add(pais);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaPais = listaPais;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());

                }

            }
            return response;
        }

        public ResponseRegistroAduana RegistroAduana(RequestRegistroAduana request)
        {
            var response = new ResponseRegistroAduana();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_ADUANA", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoAduana", request.CodigoAduana);
                    parametrosIn.AddWithValue("@CodigoPuerto", request.CodigoPuerto);
                    parametrosIn.AddWithValue("@CodigoViaTransporte", request.CodigoViaTransporte);
                    parametrosIn.AddWithValue("@CodigoAduanaSunat", request.CodigoAduanaSunat);
                    parametrosIn.AddWithValue("@NombreAduana", request.NombreAduana);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarAduana ConsultarAduana(RequestConsultarAduana request)
        {
            var response = new ResponseConsultarAduana();
            var listaAduana = new List<Aduana>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoAduana", request.CodigoAduana);
                parametrosIn.Add("@CodigoPuerto", request.CodigoPuerto);
                parametrosIn.Add("@CodigoViaTransporte", request.CodigoViaTransporte);
                parametrosIn.Add("@CodigoAduanaSunat", request.CodigoAduanaSunat);
                parametrosIn.Add("@NombreAduana", request.NombreAduana);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_ADUANA", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Aduana Aduana = new Aduana();
                            Aduana.CodigoAduana = dr.GetInt64(dr.GetOrdinal("CodigoAduana"));
                            Aduana.CodigoAduanaSunat = dr.GetInt32(dr.GetOrdinal("CodigoAduanaSunat"));
                            Aduana.NombreAduana = dr.IsDBNull(dr.GetOrdinal("NombreAduana")) ? "" : dr.GetString(dr.GetOrdinal("NombreAduana")).Trim();
                            Aduana.CodigoPuerto = dr.GetInt64(dr.GetOrdinal("CodigoPuerto"));
                            Aduana.NombrePuerto = dr.IsDBNull(dr.GetOrdinal("NombrePuerto")) ? "" : dr.GetString(dr.GetOrdinal("NombrePuerto")).Trim();
                            Aduana.CodigoViaTransporte = dr.GetInt64(dr.GetOrdinal("CodigoViaTransporte"));
                            Aduana.NombreViaTransporte = dr.IsDBNull(dr.GetOrdinal("NombreViaTransporte")) ? "" : dr.GetString(dr.GetOrdinal("NombreViaTransporte")).Trim();
                            Aduana.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            Aduana.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            Aduana.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            Aduana.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));
                            listaAduana.Add(Aduana);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaAduana = listaAduana;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroClaseIMO RegistroClaseIMO(RequestRegistroClaseIMO request)
        {
            var response = new ResponseRegistroClaseIMO();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_CLASEIMO", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoClaseIMO", request.CodigoClaseIMO);
                    parametrosIn.AddWithValue("@CodigoClaseIMOSunat", request.CodigoClaseIMOSunat);
                    parametrosIn.AddWithValue("@NombreClaseIMO", request.NombreClaseIMO);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarClaseIMO ConsultarClaseIMO(RequestConsultarClaseIMO request)
        {
            var response = new ResponseConsultarClaseIMO();
            var listaClaseIMO = new List<ClaseIMO>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoClaseIMO", request.CodigoClaseIMO);
                parametrosIn.Add("@CodigoClaseIMOSunat", request.CodigoClaseIMOSunat);
                parametrosIn.Add("@NombreClaseIMO", request.NombreClaseIMO);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_CLASEIMO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ClaseIMO ClaseIMO = new ClaseIMO();
                            ClaseIMO.CodigoClaseIMO = dr.GetInt64(dr.GetOrdinal("CodigoClaseIMO"));
                            ClaseIMO.CodigoClaseIMOSunat = dr.IsDBNull(dr.GetOrdinal("CodigoClaseIMOSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoClaseIMOSunat")).Trim();
                            ClaseIMO.NombreClaseIMO = dr.IsDBNull(dr.GetOrdinal("NombreClaseIMO")) ? "" : dr.GetString(dr.GetOrdinal("NombreClaseIMO")).Trim();
                            ClaseIMO.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            ClaseIMO.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            ClaseIMO.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            ClaseIMO.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaClaseIMO.Add(ClaseIMO);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaClaseIMO = listaClaseIMO;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroCondicionCarga RegistroCondicionCarga(RequestRegistroCondicionCarga request)
        {
            var response = new ResponseRegistroCondicionCarga();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_CONDICIONCARGA", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoCondicionCarga", request.CodigoCondicionCarga);
                    parametrosIn.AddWithValue("@CodigoCondicionCargaSunat", request.CodigoCondicionCargaSunat);
                    parametrosIn.AddWithValue("@NombreCondicionCarga", request.NombreCondicionCarga);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarCondicionCarga ConsultarCondicionCarga(RequestConsultarCondicionCarga request)
        {
            var response = new ResponseConsultarCondicionCarga();
            var listaCondicionCarga = new List<CondicionCarga>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoCondicionCarga", request.CodigoCondicionCarga);
                parametrosIn.Add("@CodigoCondicionCargaSunat", request.CodigoCondicionCargaSunat);
                parametrosIn.Add("@NombreCondicionCarga", request.NombreCondicionCarga);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_CONDICIONCARGA", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CondicionCarga CondicionCarga = new CondicionCarga();
                            CondicionCarga.CodigoCondicionCarga = dr.GetInt64(dr.GetOrdinal("CodigoCondicionCarga"));
                            CondicionCarga.CodigoCondicionCargaSunat = dr.IsDBNull(dr.GetOrdinal("CodigoCondicionCargaSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoCondicionCargaSunat")).Trim();
                            CondicionCarga.NombreCondicionCarga = dr.IsDBNull(dr.GetOrdinal("NombreCondicionCarga")) ? "" : dr.GetString(dr.GetOrdinal("NombreCondicionCarga")).Trim();
                            CondicionCarga.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            CondicionCarga.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            CondicionCarga.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            CondicionCarga.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaCondicionCarga.Add(CondicionCarga);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaCondicionCarga = listaCondicionCarga;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroCondicionContrato RegistroCondicionContrato(RequestRegistroCondicionContrato request)
        {
            var response = new ResponseRegistroCondicionContrato();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_CONDICIONCONTRATO", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoCondicionContrato", request.CodigoCondicionContrato);
                    parametrosIn.AddWithValue("@CodigoCondicionContratoSunat", request.CodigoCondicionContratoSunat);
                    parametrosIn.AddWithValue("@NombreCondicionContrato", request.NombreCondicionContrato);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarCondicionContrato ConsultarCondicionContrato(RequestConsultarCondicionContrato request)
        {
            var response = new ResponseConsultarCondicionContrato();
            var listaCondicionContrato = new List<CondicionContrato>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoCondicionContrato", request.CodigoCondicionContrato);
                parametrosIn.Add("@CodigoCondicionContratoSunat", request.CodigoCondicionContratoSunat);
                parametrosIn.Add("@NombreCondicionContrato", request.NombreCondicionContrato);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_CONDICIONCONTRATO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CondicionContrato CondicionContrato = new CondicionContrato();
                            CondicionContrato.CodigoCondicionContrato = dr.GetInt64(dr.GetOrdinal("CodigoCondicionContrato"));
                            CondicionContrato.CodigoCondicionContratoSunat = dr.IsDBNull(dr.GetOrdinal("CodigoCondicionContratoSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoCondicionContratoSunat")).Trim();
                            CondicionContrato.NombreCondicionContrato = dr.IsDBNull(dr.GetOrdinal("NombreCondicionContrato")) ? "" : dr.GetString(dr.GetOrdinal("NombreCondicionContrato")).Trim();
                            CondicionContrato.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            CondicionContrato.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            CondicionContrato.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            CondicionContrato.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaCondicionContrato.Add(CondicionContrato);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaCondicionContrato = listaCondicionContrato;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroCondicionPrecinto RegistroCondicionPrecinto(RequestRegistroCondicionPrecinto request)
        {
            var response = new ResponseRegistroCondicionPrecinto();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_CONDICIONPRECINTO", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoCondicionPrecinto", request.CodigoCondicionPrecinto);
                    parametrosIn.AddWithValue("@CodigoCondicionPrecintoSunat", request.CodigoCondicionPrecintoSunat);
                    parametrosIn.AddWithValue("@NombreCondicionPrecinto", request.NombreCondicionPrecinto);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarCondicionPrecinto ConsultarCondicionPrecinto(RequestConsultarCondicionPrecinto request)
        {
            var response = new ResponseConsultarCondicionPrecinto();
            var listaCondicionPrecinto = new List<CondicionPrecinto>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoCondicionPrecinto", request.CodigoCondicionPrecinto);
                parametrosIn.Add("@CodigoCondicionPrecintoSunat", request.CodigoCondicionPrecintoSunat);
                parametrosIn.Add("@NombreCondicionPrecinto", request.NombreCondicionPrecinto);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_CONDICIONPRECINTO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CondicionPrecinto CondicionPrecinto = new CondicionPrecinto();
                            CondicionPrecinto.CodigoCondicionPrecinto = dr.GetInt64(dr.GetOrdinal("CodigoCondicionPrecinto"));
                            CondicionPrecinto.CodigoCondicionPrecintoSunat = dr.IsDBNull(dr.GetOrdinal("CodigoCondicionPrecintoSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoCondicionPrecintoSunat")).Trim();
                            CondicionPrecinto.NombreCondicionPrecinto = dr.IsDBNull(dr.GetOrdinal("NombreCondicionPrecinto")) ? "" : dr.GetString(dr.GetOrdinal("NombreCondicionPrecinto")).Trim();
                            CondicionPrecinto.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            CondicionPrecinto.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            CondicionPrecinto.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            CondicionPrecinto.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaCondicionPrecinto.Add(CondicionPrecinto);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaCondicionPrecinto = listaCondicionPrecinto;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());

                }

            }
            return response;
        }

        public ResponseRegistroCondicionTransporte RegistroCondicionTransporte(RequestRegistroCondicionTransporte request)
        {
            var response = new ResponseRegistroCondicionTransporte();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_CONDICIONTRANSPORTE", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoCondicionTransporte", request.CodigoCondicionTransporte);
                    parametrosIn.AddWithValue("@CodigoCondicionTransporteSunat", request.CodigoCondicionTransporteSunat);
                    parametrosIn.AddWithValue("@NombreCondicionTransporte", request.NombreCondicionTransporte);
                    parametrosIn.AddWithValue("@CodigoAduanaCondicionTransporte", request.CodigoAduanaCondicionTransporte);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarCondicionTransporte ConsultarCondicionTransporte(RequestConsultarCondicionTransporte request)
        {
            var response = new ResponseConsultarCondicionTransporte();
            var listaCondicionTransporte = new List<CondicionTransporte>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoCondicionTransporte", request.CodigoCondicionTransporte);
                parametrosIn.Add("@CodigoCondicionTransporteSunat", request.CodigoCondicionTransporteSunat);
                parametrosIn.Add("@NombreCondicionTransporte", request.NombreCondicionTransporte);
                parametrosIn.Add("@CodigoAduanaCondicionTransporte", request.CodigoAduanaCondicionTransporte);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_CONDICIONTRANSPORTE", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CondicionTransporte CondicionTransporte = new CondicionTransporte();
                            CondicionTransporte.CodigoCondicionTransporte = dr.GetInt64(dr.GetOrdinal("CodigoCondicionTransporte"));
                            CondicionTransporte.CodigoCondicionTransporteSunat = dr.IsDBNull(dr.GetOrdinal("CodigoCondicionTransporteSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoCondicionTransporteSunat")).Trim();
                            CondicionTransporte.NombreCondicionTransporte = dr.IsDBNull(dr.GetOrdinal("NombreCondicionTransporte")) ? "" : dr.GetString(dr.GetOrdinal("NombreCondicionTransporte")).Trim();
                            CondicionTransporte.CodigoAduanaCondicionTransporte = dr.IsDBNull(dr.GetOrdinal("CodigoAduanaCondicionTransporte")) ? "" : dr.GetString(dr.GetOrdinal("CodigoAduanaCondicionTransporte")).Trim();
                            CondicionTransporte.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            CondicionTransporte.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            CondicionTransporte.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            CondicionTransporte.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaCondicionTransporte.Add(CondicionTransporte);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaCondicionTransporte = listaCondicionTransporte;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroContenedor RegistroContenedor(RequestRegistroContenedor request)
        {
            var response = new ResponseRegistroContenedor();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_CONTENEDOR", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoContenedor", request.CodigoContenedor);
                    parametrosIn.AddWithValue("@CodigoTipoContenedor", request.CodigoTipoContenedor);
                    parametrosIn.AddWithValue("@NumeroContenedor", request.NumeroContenedor);
                    parametrosIn.AddWithValue("@TaraContenedor", request.TaraContenedor);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarContenedor ConsultarContenedor(RequestConsultarContenedor request)
        {
            var response = new ResponseConsultarContenedor();
            var listaContenedor = new List<Contenedor>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoContenedor", request.CodigoContenedor);
                parametrosIn.Add("@CodigoTipoContenedor", request.CodigoTipoContenedor);
                parametrosIn.Add("@NumeroContenedor", request.NumeroContenedor);
                parametrosIn.Add("@TaraContenedor", request.TaraContenedor);
                parametrosIn.Add("@CodTipoContenedor", request.CodTipoContenedor);
                parametrosIn.Add("@TamanioTipoContenedor", request.TamanioTipoContenedor);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_CONTENEDOR", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Contenedor Contenedor = new Contenedor();
                            Contenedor.CodigoContenedor = dr.GetInt64(dr.GetOrdinal("CodigoContenedor"));
                            Contenedor.NumeroContenedor = dr.IsDBNull(dr.GetOrdinal("NumeroContenedor")) ? "" : dr.GetString(dr.GetOrdinal("NumeroContenedor")).Trim();
                            Contenedor.TaraContenedor = dr.GetDecimal(dr.GetOrdinal("TaraContenedor"));
                            Contenedor.CodigoTipoContenedor = dr.GetInt64(dr.GetOrdinal("CodigoTipoContenedor"));
                            Contenedor.NombreTipoContenedor = dr.GetString(dr.GetOrdinal("NombreTipoContenedor")).Trim();
                            Contenedor.CodTipoContenedor = dr.GetString(dr.GetOrdinal("CodTipoContenedor")).Trim();
                            Contenedor.TamanioTipoContenedor = dr.GetString(dr.GetOrdinal("TamanioTipoContenedor")).Trim();
                            Contenedor.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            Contenedor.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            Contenedor.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            Contenedor.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaContenedor.Add(Contenedor);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaContenedor = listaContenedor;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroEntidadPrecinto RegistroEntidadPrecinto(RequestRegistroEntidadPrecinto request)
        {
            var response = new ResponseRegistroEntidadPrecinto();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_ENTIDADPRECINTO", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoEntidadPrecinto", request.CodigoEntidadPrecinto);
                    parametrosIn.AddWithValue("@CodigoEntidadPrecintoSunat", request.CodigoEntidadPrecintoSunat);
                    parametrosIn.AddWithValue("@NombreEntidadPrecinto", request.NombreEntidadPrecinto);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarEntidadPrecinto ConsultarEntidadPrecinto(RequestConsultarEntidadPrecinto request)
        {
            var response = new ResponseConsultarEntidadPrecinto();
            var listaEntidadPrecinto = new List<EntidadPrecinto>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoEntidadPrecinto", request.CodigoEntidadPrecinto);
                parametrosIn.Add("@CodigoEntidadPrecintoSunat", request.CodigoEntidadPrecintoSunat);
                parametrosIn.Add("@NombreEntidadPrecinto", request.NombreEntidadPrecinto);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_ENTIDADPRECINTO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            EntidadPrecinto EntidadPrecinto = new EntidadPrecinto();
                            EntidadPrecinto.CodigoEntidadPrecinto = dr.GetInt64(dr.GetOrdinal("CodigoEntidadPrecinto"));
                            EntidadPrecinto.CodigoEntidadPrecintoSunat = dr.IsDBNull(dr.GetOrdinal("CodigoEntidadPrecintoSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoEntidadPrecintoSunat")).Trim();
                            EntidadPrecinto.NombreEntidadPrecinto = dr.IsDBNull(dr.GetOrdinal("NombreEntidadPrecinto")) ? "" : dr.GetString(dr.GetOrdinal("NombreEntidadPrecinto")).Trim();
                            EntidadPrecinto.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            EntidadPrecinto.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            EntidadPrecinto.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            EntidadPrecinto.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaEntidadPrecinto.Add(EntidadPrecinto);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaEntidadPrecinto = listaEntidadPrecinto;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroItinerario RegistroItinerario(RequestRegistroItinerario request)
        {
            var response = new ResponseRegistroItinerario();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_ITINERARIO", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoItinerario", request.CodigoItinerario);
                    parametrosIn.AddWithValue("@CodigoNave", request.CodigoNave);
                    parametrosIn.AddWithValue("@CodigoAduana", request.CodigoAduana);
                    parametrosIn.AddWithValue("@CodigoTipoOperacion", request.CodigoTipoOperacion);
                    parametrosIn.AddWithValue("@CodigoTipoLugarCarga", request.CodigoTipoLugarCarga);
                    parametrosIn.AddWithValue("@CodigoOperadorEmbarqueItinerario", request.CodigoOperadorEmbarqueItinerario);
                    parametrosIn.AddWithValue("@CodigoOperadorDescargaItinerario", request.CodigoOperadorDescargaItinerario);
                    parametrosIn.AddWithValue("@CodigoAgenteMaritimoItinerario", request.CodigoAgenteMaritimoItinerario);
                    parametrosIn.AddWithValue("@CodigoTipoLugarCargaPuertoIntermedio", request.CodigoTipoLugarCargaPuertoIntermedio);
                    parametrosIn.AddWithValue("@CodigoPuertoIntermedio", request.CodigoPuertoIntermedio);
                    parametrosIn.AddWithValue("@NumeroViajeItinerario", request.NumeroViajeItinerario);
                    parametrosIn.AddWithValue("@NumeroManifiestoItinerario", request.NumeroManifiestoItinerario);
                    parametrosIn.AddWithValue("@AnioManifiestoItinerario", request.AnioManifiestoItinerario);
                    parametrosIn.AddWithValue("@FechaArriboItinerario", request.FechaArriboItinerario);
                    parametrosIn.AddWithValue("@FechaZarpeItinerario", request.FechaZarpeItinerario);
                    parametrosIn.AddWithValue("@FechaAtraqueItinerario", request.FechaAtraqueItinerario);
                    parametrosIn.AddWithValue("@FechaTerminoDescargaItinerario", request.FechaTerminoDescargaItinerario);
                    parametrosIn.AddWithValue("@DUEItinerario", request.DUEItinerario);
                    parametrosIn.AddWithValue("@CapitanNaveItinerario", request.CapitanNaveItinerario);
                    parametrosIn.AddWithValue("@FechaZarpePuertoIntermedio", request.FechaZarpePuertoIntermedio);
                    parametrosIn.AddWithValue("@Voyage", request.Voyage);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarItinerario ConsultarItinerario(RequestConsultarItinerario request)
        {
            var response = new ResponseConsultarItinerario();
            var listaItinerario = new List<Itinerario>();
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
                parametrosIn.Add("@FechaArriboItinerarioInicio", request.FechaArriboItinerarioInicio);
                parametrosIn.Add("@FechaArriboItinerarioFin", request.FechaArriboItinerarioFin);
                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_ITINERARIO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Itinerario Itinerario = new Itinerario();
                            Itinerario.CodigoItinerario = dr.GetInt64(dr.GetOrdinal("CodigoItinerario"));
                            Itinerario.CodigoNave = dr.GetInt64(dr.GetOrdinal("CodigoNave"));
                            Itinerario.NombreNave = dr.IsDBNull(dr.GetOrdinal("NombreNave")) ? "" : dr.GetString(dr.GetOrdinal("NombreNave")).Trim();
                            Itinerario.NumeroViajeItinerario = dr.IsDBNull(dr.GetOrdinal("NumeroViajeItinerario")) ? "" : dr.GetString(dr.GetOrdinal("NumeroViajeItinerario")).Trim();
                            Itinerario.CodigoAduana = dr.GetInt64(dr.GetOrdinal("CodigoAduana"));
                            Itinerario.NombreAduana = dr.IsDBNull(dr.GetOrdinal("NombreAduana")) ? "" : dr.GetString(dr.GetOrdinal("NombreAduana")).Trim();
                            Itinerario.CodigoTipoOperacion = dr.GetInt64(dr.GetOrdinal("CodigoTipoOperacion"));
                            Itinerario.NombreTipoOperacion = dr.IsDBNull(dr.GetOrdinal("NombreTipoOperacion")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoOperacion")).Trim();
                            Itinerario.CodigoTipoLugarCarga = dr.GetInt64(dr.GetOrdinal("CodigoTipoLugarCarga"));
                            Itinerario.NombreTipoLugarCarga = dr.IsDBNull(dr.GetOrdinal("NombreTipoLugarCarga")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoLugarCarga")).Trim();
                            Itinerario.CodigoOperadorEmbarqueItinerario = dr.GetInt64(dr.GetOrdinal("CodigoOperadorEmbarqueItinerario"));
                            Itinerario.NombreOperadorEmbarqueItinerario = dr.IsDBNull(dr.GetOrdinal("NombreOperadorEmbarqueItinerario")) ? "" : dr.GetString(dr.GetOrdinal("NombreOperadorEmbarqueItinerario")).Trim();
                            Itinerario.CodigoOperadorDescargaItinerario = dr.GetInt64(dr.GetOrdinal("CodigoOperadorDescargaItinerario"));
                            Itinerario.NombreOperadorDescargaItinerario = dr.IsDBNull(dr.GetOrdinal("NombreOperadorDescargaItinerario")) ? "" : dr.GetString(dr.GetOrdinal("NombreOperadorDescargaItinerario")).Trim();
                            Itinerario.CodigoAgenteMaritimoItinerario = dr.GetInt64(dr.GetOrdinal("CodigoAgenteMaritimoItinerario"));
                            Itinerario.NombreAgenteMaritimoItinerario = dr.IsDBNull(dr.GetOrdinal("NombreAgenteMaritimoItinerario")) ? "" : dr.GetString(dr.GetOrdinal("NombreAgenteMaritimoItinerario")).Trim();
                            Itinerario.CodigoTipoLugarCargaPuertoIntermedio = dr.GetInt64(dr.GetOrdinal("CodigoTipoLugarCargaPuertoIntermedio"));
                            Itinerario.NombreTipoLugarCargaPuertoIntermedio = dr.IsDBNull(dr.GetOrdinal("NombreTipoLugarCargaPuertoIntermedio")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoLugarCargaPuertoIntermedio")).Trim();
                            Itinerario.CodigoPuertoIntermedio = dr.GetInt64(dr.GetOrdinal("CodigoPuertoIntermedio"));
                            Itinerario.NombrePuertoIntermedio = dr.IsDBNull(dr.GetOrdinal("NombrePuertoIntermedio")) ? "" : dr.GetString(dr.GetOrdinal("NombrePuertoIntermedio")).Trim();
                            Itinerario.NumeroManifiestoItinerario = dr.IsDBNull(dr.GetOrdinal("NumeroManifiestoItinerario")) ? "" : dr.GetString(dr.GetOrdinal("NumeroManifiestoItinerario")).Trim();
                            Itinerario.AnioManifiestoItinerario = dr.GetInt32(dr.GetOrdinal("AnioManifiestoItinerario"));
                            Itinerario.FechaArriboItinerario = dr.IsDBNull(dr.GetOrdinal("FechaArriboItinerario")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaArriboItinerario"));
                            Itinerario.FechaZarpeItinerario = dr.IsDBNull(dr.GetOrdinal("FechaZarpeItinerario")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaZarpeItinerario"));
                            Itinerario.FechaAtraqueItinerario = dr.IsDBNull(dr.GetOrdinal("FechaAtraqueItinerario")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaAtraqueItinerario"));
                            Itinerario.FechaTerminoDescargaItinerario = dr.IsDBNull(dr.GetOrdinal("FechaTerminoDescargaItinerario")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaTerminoDescargaItinerario"));
                            Itinerario.DUEItinerario = dr.IsDBNull(dr.GetOrdinal("DUEItinerario")) ? "" : dr.GetString(dr.GetOrdinal("DUEItinerario")).Trim();
                            Itinerario.CapitanNaveItinerario = dr.IsDBNull(dr.GetOrdinal("CapitanNaveItinerario")) ? "" : dr.GetString(dr.GetOrdinal("CapitanNaveItinerario")).Trim();
                            Itinerario.FechaZarpePuertoIntermedio = dr.IsDBNull(dr.GetOrdinal("FechaZarpePuertoIntermedio")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaZarpePuertoIntermedio"));
                            Itinerario.Voyage = dr.IsDBNull(dr.GetOrdinal("Voyage")) ? "" : dr.GetString(dr.GetOrdinal("Voyage")).Trim();
                            Itinerario.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            Itinerario.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            Itinerario.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            Itinerario.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaItinerario.Add(Itinerario);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaItinerario = listaItinerario;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroLineaNaviera RegistroLineaNaviera(RequestRegistroLineaNaviera request)
        {
            var response = new ResponseRegistroLineaNaviera();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_LINEANAVIERA", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoLineaNaviera", request.CodigoLineaNaviera);
                    parametrosIn.AddWithValue("@NombreLineaNaviera", request.NombreLineaNaviera);
                    parametrosIn.AddWithValue("@DireccionLineaNaviera", request.DireccionLineaNaviera);
                    parametrosIn.AddWithValue("@RucLineaNaviera", request.RucLineaNaviera);
                    parametrosIn.AddWithValue("@CodigoEquivalencia", request.CodigoEquivalencia);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarLineaNaviera ConsultarLineaNaviera(RequestConsultarLineaNaviera request)
        {
            var response = new ResponseConsultarLineaNaviera();
            var listaLineaNaviera = new List<LineaNaviera>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoLineaNaviera", request.CodigoLineaNaviera);
                parametrosIn.Add("@NombreLineaNaviera", request.NombreLineaNaviera);
                parametrosIn.Add("@RucLineaNaviera ", request.RucLineaNaviera);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_LINEANAVIERA", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            LineaNaviera LineaNaviera = new LineaNaviera();
                            LineaNaviera.CodigoLineaNaviera = dr.GetInt64(dr.GetOrdinal("CodigoLineaNaviera"));
                            LineaNaviera.NombreLineaNaviera = dr.IsDBNull(dr.GetOrdinal("NombreLineaNaviera")) ? "" : dr.GetString(dr.GetOrdinal("NombreLineaNaviera")).Trim();
                            LineaNaviera.DireccionLineaNaviera = dr.IsDBNull(dr.GetOrdinal("DireccionLineaNaviera")) ? "" : dr.GetString(dr.GetOrdinal("DireccionLineaNaviera")).Trim();
                            LineaNaviera.RucLineaNaviera = dr.IsDBNull(dr.GetOrdinal("RucLineaNaviera")) ? "" : dr.GetString(dr.GetOrdinal("RucLineaNaviera")).Trim();
                            LineaNaviera.CodigoEquivalencia = dr.IsDBNull(dr.GetOrdinal("CodigoEquivalencia")) ? "" : dr.GetString(dr.GetOrdinal("CodigoEquivalencia")).Trim();
                            LineaNaviera.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            LineaNaviera.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            LineaNaviera.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            LineaNaviera.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaLineaNaviera.Add(LineaNaviera);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaLineaNaviera = listaLineaNaviera;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroMedioTransporte RegistroMedioTransporte(RequestRegistroMedioTransporte request)
        {
            var response = new ResponseRegistroMedioTransporte();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_MEDIOTRANSPORTE", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoMedioTransporte", request.CodigoMedioTransporte);
                    parametrosIn.AddWithValue("@CodigoMedioTransporteSunat", request.CodigoMedioTransporteSunat);
                    parametrosIn.AddWithValue("@NombreMedioTransporte", request.NombreMedioTransporte);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarMedioTransporte ConsultarMedioTransporte(RequestConsultarMedioTransporte request)
        {
            var response = new ResponseConsultarMedioTransporte();
            var listaMedioTransporte = new List<MedioTransporte>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoMedioTransporte", request.CodigoMedioTransporte);
                parametrosIn.Add("@CodigoMedioTransporteSunat", request.CodigoMedioTransporteSunat);
                parametrosIn.Add("@NombreMedioTransporte", request.NombreMedioTransporte);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_MEDIOTRANSPORTE", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            MedioTransporte MedioTransporte = new MedioTransporte();
                            MedioTransporte.CodigoMedioTransporte = dr.GetInt64(dr.GetOrdinal("CodigoMedioTransporte"));
                            MedioTransporte.CodigoMedioTransporteSunat = dr.GetByte(dr.GetOrdinal("CodigoMedioTransporteSunat"));
                            MedioTransporte.NombreMedioTransporte = dr.IsDBNull(dr.GetOrdinal("NombreMedioTransporte")) ? "" : dr.GetString(dr.GetOrdinal("NombreMedioTransporte")).Trim();
                            MedioTransporte.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            MedioTransporte.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            MedioTransporte.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            MedioTransporte.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaMedioTransporte.Add(MedioTransporte);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaMedioTransporte = listaMedioTransporte;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());

                }

            }
            return response;
        }

        public ResponseRegistroModoPago RegistroModoPago(RequestRegistroModoPago request)
        {
            var response = new ResponseRegistroModoPago();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_MODOPAGO", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoModoPago", request.CodigoModoPago);
                    parametrosIn.AddWithValue("@CodigoModoPagoSunat", request.CodigoModoPagoSunat);
                    parametrosIn.AddWithValue("@NombreModoPago", request.NombreModoPago);
                    parametrosIn.AddWithValue("@CodigoEquivalencia", request.CodigoEquivalencia);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarModoPago ConsultarModoPago(RequestConsultarModoPago request)
        {
            var response = new ResponseConsultarModoPago();
            var listaModoPago = new List<ModoPago>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoModoPago", request.CodigoModoPago);
                parametrosIn.Add("@CodigoModoPagoSunat", request.CodigoModoPagoSunat);
                parametrosIn.Add("@NombreModoPago", request.NombreModoPago);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_MODOPAGO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ModoPago ModoPago = new ModoPago();
                            ModoPago.CodigoModoPago = dr.GetInt64(dr.GetOrdinal("CodigoModoPago"));
                            ModoPago.CodigoModoPagoSunat = dr.GetString(dr.GetOrdinal("CodigoModoPagoSunat"));
                            ModoPago.NombreModoPago = dr.IsDBNull(dr.GetOrdinal("NombreModoPago")) ? "" : dr.GetString(dr.GetOrdinal("NombreModoPago")).Trim();
                            ModoPago.CodigoEquivalencia = dr.IsDBNull(dr.GetOrdinal("CodigoEquivalencia")) ? "" : dr.GetString(dr.GetOrdinal("CodigoEquivalencia")).Trim();
                            ModoPago.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            ModoPago.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            ModoPago.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            ModoPago.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaModoPago.Add(ModoPago);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaModoPago = listaModoPago;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());

                }
            }
            return response;
        }

        public ResponseRegistroMoneda RegistroMoneda(RequestRegistroMoneda request)
        {
            var response = new ResponseRegistroMoneda();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_MONEDA", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoMoneda", request.CodigoMoneda);
                    parametrosIn.AddWithValue("@CodigoMonedaSunat", request.CodigoMonedaSunat);
                    parametrosIn.AddWithValue("@NombreMoneda", request.NombreMoneda);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarMoneda ConsultarMoneda(RequestConsultarMoneda request)
        {
            var response = new ResponseConsultarMoneda();
            var listaMoneda = new List<Moneda>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoMoneda", request.CodigoMoneda);
                parametrosIn.Add("@CodigoMonedaSunat", request.CodigoMonedaSunat);
                parametrosIn.Add("@NombreMoneda", request.NombreMoneda);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_MONEDA", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Moneda Moneda = new Moneda();
                            Moneda.CodigoMoneda = dr.GetInt64(dr.GetOrdinal("CodigoMoneda"));
                            Moneda.CodigoMonedaSunat = dr.GetString(dr.GetOrdinal("CodigoMonedaSunat"));
                            Moneda.NombreMoneda = dr.IsDBNull(dr.GetOrdinal("NombreMoneda")) ? "" : dr.GetString(dr.GetOrdinal("NombreMoneda")).Trim();
                            Moneda.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            Moneda.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            Moneda.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            Moneda.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaMoneda.Add(Moneda);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaMoneda = listaMoneda;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroNaturalezaCarga RegistroNaturalezaCarga(RequestRegistroNaturalezaCarga request)
        {
            var response = new ResponseRegistroNaturalezaCarga();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_NATURALEZACARGA", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoNaturalezaCarga", request.CodigoNaturalezaCarga);
                    parametrosIn.AddWithValue("@CodigoNaturalezaCargaSunat", request.CodigoNaturalezaCargaSunat);
                    parametrosIn.AddWithValue("@NombreNaturalezaCarga", request.NombreNaturalezaCarga);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarNaturalezaCarga ConsultarNaturalezaCarga(RequestConsultarNaturalezaCarga request)
        {
            var response = new ResponseConsultarNaturalezaCarga();
            var listaNaturalezaCarga = new List<NaturalezaCarga>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoNaturalezaCarga", request.CodigoNaturalezaCarga);
                parametrosIn.Add("@CodigoNaturalezaCargaSunat", request.CodigoNaturalezaCargaSunat);
                parametrosIn.Add("@NombreNaturalezaCarga", request.NombreNaturalezaCarga);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_NATURALEZACARGA", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            NaturalezaCarga NaturalezaCarga = new NaturalezaCarga();
                            NaturalezaCarga.CodigoNaturalezaCarga = dr.GetInt64(dr.GetOrdinal("CodigoNaturalezaCarga"));
                            NaturalezaCarga.CodigoNaturalezaCargaSunat = dr.GetString(dr.GetOrdinal("CodigoNaturalezaCargaSunat"));
                            NaturalezaCarga.NombreNaturalezaCarga = dr.IsDBNull(dr.GetOrdinal("NombreNaturalezaCarga")) ? "" : dr.GetString(dr.GetOrdinal("NombreNaturalezaCarga")).Trim();
                            NaturalezaCarga.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            NaturalezaCarga.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            NaturalezaCarga.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            NaturalezaCarga.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaNaturalezaCarga.Add(NaturalezaCarga);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaNaturalezaCarga = listaNaturalezaCarga;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroNave RegistroNave(RequestRegistroNave request)
        {
            var response = new ResponseRegistroNave();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_NAVE", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoNave", request.CodigoNave);
                    parametrosIn.AddWithValue("@CodigoPais", request.CodigoPais);
                    parametrosIn.AddWithValue("@CodigoTipoNave", request.CodigoTipoNave);
                    parametrosIn.AddWithValue("@CodigoLineaNaviera", request.CodigoLineaNaviera);
                    parametrosIn.AddWithValue("@NombreNave", request.NombreNave);
                    parametrosIn.AddWithValue("@MatriculaNave", request.MatriculaNave);
                    parametrosIn.AddWithValue("@TrbNave", request.TrbNave);
                    parametrosIn.AddWithValue("@TrnNave", request.TrnNave);
                    parametrosIn.AddWithValue("@EsloraNave", request.EsloraNave);
                    parametrosIn.AddWithValue("@MangaNave", request.MangaNave);
                    parametrosIn.AddWithValue("@CaladoNave", request.CaladoNave);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarNave ConsultarNave(RequestConsultarNave request)
        {
            var response = new ResponseConsultarNave();
            var listaNave = new List<Nave>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoNave", request.CodigoNave);
                parametrosIn.Add("@CodigoPais", request.CodigoPais);
                parametrosIn.Add("@CodigoTipoNave", request.CodigoTipoNave);
                parametrosIn.Add("@CodigoLineaNaviera", request.CodigoLineaNaviera);
                parametrosIn.Add("@NombreNave", request.NombreNave);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_NAVE", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Nave Nave = new Nave();
                            Nave.CodigoNave = dr.GetInt64(dr.GetOrdinal("CodigoNave"));
                            Nave.NombreNave = dr.IsDBNull(dr.GetOrdinal("NombreNave")) ? "" : dr.GetString(dr.GetOrdinal("NombreNave")).Trim();
                            Nave.CodigoPais = dr.GetInt64(dr.GetOrdinal("CodigoPais"));
                            Nave.NombrePais = dr.IsDBNull(dr.GetOrdinal("NombrePais")) ? "" : dr.GetString(dr.GetOrdinal("NombrePais")).Trim();
                            Nave.CodigoTipoNave = dr.GetInt64(dr.GetOrdinal("CodigoTipoNave"));
                            Nave.NombreTipoNave = dr.IsDBNull(dr.GetOrdinal("NombreTipoNave")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoNave")).Trim();
                            Nave.CodigoLineaNaviera = dr.GetInt64(dr.GetOrdinal("CodigoLineaNaviera"));
                            Nave.NombreLineaNaviera = dr.IsDBNull(dr.GetOrdinal("NombreLineaNaviera")) ? "" : dr.GetString(dr.GetOrdinal("NombreLineaNaviera")).Trim();
                            Nave.MatriculaNave = dr.IsDBNull(dr.GetOrdinal("MatriculaNave")) ? "" : dr.GetString(dr.GetOrdinal("MatriculaNave")).Trim();
                            Nave.TrbNave = dr.IsDBNull(dr.GetOrdinal("TrbNave")) ? new Nullable<Decimal>() : dr.GetDecimal(dr.GetOrdinal("TrbNave"));
                            Nave.TrnNave = dr.IsDBNull(dr.GetOrdinal("TrnNave")) ? new Nullable<Decimal>() : dr.GetDecimal(dr.GetOrdinal("TrnNave"));
                            Nave.EsloraNave = dr.IsDBNull(dr.GetOrdinal("EsloraNave")) ? new Nullable<Decimal>() : dr.GetDecimal(dr.GetOrdinal("EsloraNave"));
                            Nave.MangaNave = dr.IsDBNull(dr.GetOrdinal("MangaNave")) ? new Nullable<Decimal>() : dr.GetDecimal(dr.GetOrdinal("MangaNave"));
                            Nave.CaladoNave = dr.IsDBNull(dr.GetOrdinal("CaladoNave")) ? new Nullable<Decimal>() : dr.GetDecimal(dr.GetOrdinal("CaladoNave"));
                            Nave.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            Nave.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            Nave.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            Nave.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));
                            listaNave.Add(Nave);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaNave = listaNave;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroNumeroIMO RegistroNumeroIMO(RequestRegistroNumeroIMO request)
        {
            var response = new ResponseRegistroNumeroIMO();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_NUMEROIMO", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoNumeroIMO", request.CodigoNumeroIMO);
                    parametrosIn.AddWithValue("@CodigoClaseIMO", request.CodigoClaseIMO);
                    parametrosIn.AddWithValue("@NumberIMO", request.NumberIMO);
                    parametrosIn.AddWithValue("@NombreNumeroIMO", request.NombreNumeroIMO);
                    parametrosIn.AddWithValue("@PaginaNumeroIMO", request.PaginaNumeroIMO);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarNumeroIMO ConsultarNumeroIMO(RequestConsultarNumeroIMO request)
        {
            var response = new ResponseConsultarNumeroIMO();
            var listaNumeroIMO = new List<NumeroIMO>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoNumeroIMO", request.CodigoNumeroIMO);
                parametrosIn.Add("@CodigoClaseIMO", request.CodigoClaseIMO);
                parametrosIn.Add("@NumberIMO", request.NumberIMO);
                parametrosIn.Add("@NombreNumeroIMO", request.NombreNumeroIMO);
                parametrosIn.Add("@PaginaNumeroIMO", request.PaginaNumeroIMO);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_NUMEROIMO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            NumeroIMO NumeroIMO = new NumeroIMO();
                            NumeroIMO.CodigoNumeroIMO = dr.GetInt64(dr.GetOrdinal("CodigoNumeroIMO"));
                            NumeroIMO.NumberIMO = dr.IsDBNull(dr.GetOrdinal("NumberIMO")) ? "" : dr.GetString(dr.GetOrdinal("NumberIMO")).Trim();
                            NumeroIMO.NombreNumeroIMO = dr.IsDBNull(dr.GetOrdinal("NombreNumeroIMO")) ? "" : dr.GetString(dr.GetOrdinal("NombreNumeroIMO")).Trim();
                            //NumeroIMO.PaginaNumeroIMO = dr.GetInt32(dr.GetOrdinal("PaginaNumeroIMO"));
                            NumeroIMO.PaginaNumeroIMO = dr.IsDBNull(dr.GetOrdinal("PaginaNumeroIMO")) ? new Nullable<int>() : dr.GetInt32(dr.GetOrdinal("PaginaNumeroIMO"));
                            NumeroIMO.CodigoClaseIMO = dr.GetInt64(dr.GetOrdinal("CodigoClaseIMO"));
                            NumeroIMO.NombreClaseIMO = dr.IsDBNull(dr.GetOrdinal("NombreClaseIMO")) ? "" : dr.GetString(dr.GetOrdinal("NombreClaseIMO")).Trim();
                            NumeroIMO.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            NumeroIMO.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            NumeroIMO.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            NumeroIMO.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaNumeroIMO.Add(NumeroIMO);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaNumeroIMO = listaNumeroIMO;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroPrecinto RegistroPrecinto(RequestRegistroPrecinto request)
        {
            var response = new ResponseRegistroPrecinto();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_PRECINTO", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoPrecinto", request.CodigoPrecinto);
                    parametrosIn.AddWithValue("@CodigoCondicionPrecinto", request.CodigoCondicionPrecinto);
                    parametrosIn.AddWithValue("@CodigoEntidadPrecinto", request.CodigoEntidadPrecinto);
                    parametrosIn.AddWithValue("@NumeroPrecinto", request.NumeroPrecinto);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarPrecinto ConsultarPrecinto(RequestConsultarPrecinto request)
        {
            var response = new ResponseConsultarPrecinto();
            var listaPrecinto = new List<Precinto>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoPrecinto", request.CodigoPrecinto);
                parametrosIn.Add("@CodigoCondicionPrecinto", request.CodigoCondicionPrecinto);
                parametrosIn.Add("@CodigoEntidadPrecinto", request.CodigoEntidadPrecinto);
                parametrosIn.Add("@NumeroPrecinto", request.NumeroPrecinto);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_PRECINTO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Precinto Precinto = new Precinto();
                            Precinto.CodigoPrecinto = dr.GetInt64(dr.GetOrdinal("CodigoPrecinto"));
                            Precinto.NumeroPrecinto = dr.IsDBNull(dr.GetOrdinal("NumeroPrecinto")) ? "" : dr.GetString(dr.GetOrdinal("NumeroPrecinto")).Trim();
                            Precinto.CodigoCondicionPrecinto = dr.GetInt64(dr.GetOrdinal("CodigoCondicionPrecinto"));
                            Precinto.NombreCondicionPrecinto = dr.IsDBNull(dr.GetOrdinal("NombreCondicionPrecinto")) ? "" : dr.GetString(dr.GetOrdinal("NombreCondicionPrecinto")).Trim();
                            Precinto.CodigoEntidadPrecinto = dr.GetInt64(dr.GetOrdinal("CodigoEntidadPrecinto"));
                            Precinto.NombreEntidadPrecinto = dr.IsDBNull(dr.GetOrdinal("NombreEntidadPrecinto")) ? "" : dr.GetString(dr.GetOrdinal("NombreEntidadPrecinto")).Trim();
                            Precinto.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            Precinto.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            Precinto.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            Precinto.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaPrecinto.Add(Precinto);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaPrecinto = listaPrecinto;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroPuerto RegistroPuerto(RequestRegistroPuerto request)
        {
            var response = new ResponseRegistroPuerto();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_PUERTO", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoPuerto", request.CodigoPuerto);
                    parametrosIn.AddWithValue("@CodigoPais", request.CodigoPais);
                    parametrosIn.AddWithValue("@CodigoPuertoSunat", request.CodigoPuertoSunat);
                    parametrosIn.AddWithValue("@NombrePuerto", request.NombrePuerto);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarPuerto ConsultarPuerto(RequestConsultarPuerto request)
        {
            var response = new ResponseConsultarPuerto();
            var listaPuerto = new List<Puerto>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoPuerto", request.CodigoPuerto);
                parametrosIn.Add("@CodigoPais", request.CodigoPais);
                parametrosIn.Add("@CodigoPuertoSunat", request.CodigoPuertoSunat);
                parametrosIn.Add("@NombrePuerto", request.NombrePuerto);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_PUERTO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Puerto puerto = new Puerto();
                            puerto.CodigoPuerto = dr.GetInt64(dr.GetOrdinal("CodigoPuerto"));
                            puerto.CodigoPuertoSunat = dr.IsDBNull(dr.GetOrdinal("CodigoPuertoSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoPuertoSunat")).Trim();
                            puerto.NombrePuerto = dr.IsDBNull(dr.GetOrdinal("NombrePuerto")) ? "" : dr.GetString(dr.GetOrdinal("NombrePuerto")).Trim();
                            puerto.CodigoPais = dr.GetInt64(dr.GetOrdinal("CodigoPais"));
                            puerto.NombrePais = dr.IsDBNull(dr.GetOrdinal("NombrePais")) ? "" : dr.GetString(dr.GetOrdinal("NombrePais")).Trim();
                            puerto.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            puerto.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            puerto.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            puerto.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaPuerto.Add(puerto);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaPuerto = listaPuerto;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroRequerimientoServicio RegistroRequerimientoServicio(RequestRegistroRequerimientoServicio request)
        {
            var response = new ResponseRegistroRequerimientoServicio();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_REQUERIMIENTOSERVICIO", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoRequerimientoServicio", request.CodigoRequerimientoServicio);
                    parametrosIn.AddWithValue("@CodigoRequerimientoServicioSunat", request.CodigoRequerimientoServicioSunat);
                    parametrosIn.AddWithValue("@NombreRequerimientoServicio", request.NombreRequerimientoServicio);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarRequerimientoServicio ConsultarRequerimientoServicio(RequestConsultarRequerimientoServicio request)
        {
            var response = new ResponseConsultarRequerimientoServicio();
            var listaRequerimientoServicio = new List<RequerimientoServicio>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoRequerimientoServicio", request.CodigoRequerimientoServicio);
                parametrosIn.Add("@CodigoRequerimientoServicioSunat", request.CodigoRequerimientoServicioSunat);
                parametrosIn.Add("@NombreRequerimientoServicio", request.NombreRequerimientoServicio);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_REQUERIMIENTOSERVICIO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            RequerimientoServicio RequerimientoServicio = new RequerimientoServicio();
                            RequerimientoServicio.CodigoRequerimientoServicio = dr.GetInt64(dr.GetOrdinal("CodigoRequerimientoServicio"));
                            RequerimientoServicio.CodigoRequerimientoServicioSunat = dr.IsDBNull(dr.GetOrdinal("CodigoRequerimientoServicioSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoRequerimientoServicioSunat")).Trim();
                            RequerimientoServicio.NombreRequerimientoServicio = dr.IsDBNull(dr.GetOrdinal("NombreRequerimientoServicio")) ? "" : dr.GetString(dr.GetOrdinal("NombreRequerimientoServicio")).Trim();
                            RequerimientoServicio.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            RequerimientoServicio.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            RequerimientoServicio.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            RequerimientoServicio.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaRequerimientoServicio.Add(RequerimientoServicio);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaRequerimientoServicio = listaRequerimientoServicio;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroRol RegistroRol(RequestRegistroRol request)
        {
            var response = new ResponseRegistroRol();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_ROL", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoRol", request.CodigoRol);
                    parametrosIn.AddWithValue("@CodigoRolSunat", request.CodigoRolSunat);
                    parametrosIn.AddWithValue("@NombreRol", request.NombreRol);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarRol ConsultarRol(RequestConsultarRol request)
        {
            var response = new ResponseConsultarRol();
            var listaRol = new List<Rol>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoRol", request.CodigoRol);
                parametrosIn.Add("@CodigoRolSunat", request.CodigoRolSunat);
                parametrosIn.Add("@NombreRol", request.NombreRol);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_ROL", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Rol Rol = new Rol();
                            Rol.CodigoRol = dr.GetInt64(dr.GetOrdinal("CodigoRol"));
                            Rol.CodigoRolSunat = dr.IsDBNull(dr.GetOrdinal("CodigoRolSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoRolSunat")).Trim();
                            Rol.NombreRol = dr.IsDBNull(dr.GetOrdinal("NombreRol")) ? "" : dr.GetString(dr.GetOrdinal("NombreRol")).Trim();
                            Rol.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            Rol.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            Rol.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            Rol.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaRol.Add(Rol);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaRol = listaRol;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public List<Roles> ConsultaRoles()
        {
            List<Roles> lstRoles = new List<Roles>();

            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_LISTAR_ROLES", conexion, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Roles rol = new Roles();
                            {
                                rol.CodigoRol = dr.GetInt64(dr.GetOrdinal("CodigoRol"));
                                rol.CodigoRolSunat = dr.IsDBNull(dr.GetOrdinal("CodigoRolSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoRolSunat")).Trim();
                                rol.NombreRol = dr.IsDBNull(dr.GetOrdinal("NombreRol")) ? "" : dr.GetString(dr.GetOrdinal("NombreRol")).Trim();
                            };

                            lstRoles.Add(rol);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                }
            }

            return lstRoles;
        }

        public List<TiposBL> ConsultaTiposBL()
        {
            List<TiposBL> lstTiposBL = new List<TiposBL>();

            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_LISTAR_TIPOBL", conexion, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TiposBL tipobl = new TiposBL();
                            {
                                tipobl.CodigoTipoBL = dr.GetInt64(dr.GetOrdinal("CodigoTipoBL"));
                                tipobl.NombreTipoBL = dr.IsDBNull(dr.GetOrdinal("NombreTipoBL")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoBL")).Trim();
                            };

                            lstTiposBL.Add(tipobl);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                }
            }

            return lstTiposBL;
        }

        public List<Temperaturas> ConsultaTemperaturas()
        {
            List<Temperaturas> lstTemperaturas = new List<Temperaturas>();

            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_LISTAR_TEMPERATURA", conexion, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Temperaturas temperatura = new Temperaturas();
                            {
                                temperatura.CodigoTemperatura = dr.GetInt64(dr.GetOrdinal("CodigoTemperatura"));
                                temperatura.NombreTemperatura = dr.IsDBNull(dr.GetOrdinal("NombreTemperatura")) ? "" : dr.GetString(dr.GetOrdinal("NombreTemperatura")).Trim();
                            };

                            lstTemperaturas.Add(temperatura);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                }
            }

            return lstTemperaturas;
        }

        public List<CondicionesCarga> ConsultaCondicionesCarga()
        {
            List<CondicionesCarga> lstCondicionesCarga = new List<CondicionesCarga>();

            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_LISTAR_CONDICION_CARGA", conexion, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CondicionesCarga condicioncarga = new CondicionesCarga();
                            {
                                condicioncarga.CodigoCondicionCarga = dr.GetInt64(dr.GetOrdinal("CodigoCondicionCarga"));
                                condicioncarga.NombreCondicionCarga = dr.IsDBNull(dr.GetOrdinal("NombreCondicionCarga")) ? "" : dr.GetString(dr.GetOrdinal("NombreCondicionCarga")).Trim();
                            };

                            lstCondicionesCarga.Add(condicioncarga);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                }
            }

            return lstCondicionesCarga;
        }

        public List<CondicionesTransporte> ConsultaCondicionesTransporte()
        {
            List<CondicionesTransporte> lstCondicionesTransporte = new List<CondicionesTransporte>();

            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_LISTAR_CONDICION_TRANSPORTE", conexion, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CondicionesTransporte condiciontransporte = new CondicionesTransporte();
                            {
                                condiciontransporte.CodigoCondicionTransporte = dr.GetInt64(dr.GetOrdinal("CodigoCondicionTransporte"));
                                condiciontransporte.NombreCondicionTransporte = dr.IsDBNull(dr.GetOrdinal("NombreCondicionTransporte")) ? "" : dr.GetString(dr.GetOrdinal("NombreCondicionTransporte")).Trim();
                            };

                            lstCondicionesTransporte.Add(condiciontransporte);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                }
            }

            return lstCondicionesTransporte;
        }

        public List<ModosPago> ConsultaModosPago()
        {
            List<ModosPago> lstModosPago = new List<ModosPago>();

            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_LISTAR_MODO_PAGO", conexion, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ModosPago tipobl = new ModosPago();
                            {
                                tipobl.CodigoModoPago = dr.GetInt64(dr.GetOrdinal("CodigoModoPago"));
                                tipobl.NombreModoPago = dr.IsDBNull(dr.GetOrdinal("NombreModoPago")) ? "" : dr.GetString(dr.GetOrdinal("NombreModoPago")).Trim();
                            };

                            lstModosPago.Add(tipobl);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                }
            }

            return lstModosPago;
        }

        public List<TiposTransmisionNave> ConsultaTiposTransmisionNave()
        {
            List<TiposTransmisionNave> lstTiposTransmisionNave = new List<TiposTransmisionNave>();

            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_LISTAR_TIPO_TRANSMISION_NAVES", conexion, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TiposTransmisionNave TipoTransmisionNave = new TiposTransmisionNave();
                            {
                                TipoTransmisionNave.Codigo= dr.IsDBNull(dr.GetOrdinal("Codigo")) ? "" : dr.GetString(dr.GetOrdinal("Codigo")).Trim();
                                TipoTransmisionNave.Descripcion = dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : dr.GetString(dr.GetOrdinal("Descripcion")).Trim();
                            };

                            lstTiposTransmisionNave.Add(TipoTransmisionNave);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                }
            }

            return lstTiposTransmisionNave;
        }

        public List<TiposTransmisionDocumento> ConsultaTiposTransmisionDocumento()
        {
            List<TiposTransmisionDocumento> lstTiposTransmisionDocumento = new List<TiposTransmisionDocumento>();

            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_LISTAR_TIPO_TRANSMISION_DOCUMENTOS", conexion, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TiposTransmisionDocumento TipoTransmisionDocumento = new TiposTransmisionDocumento();
                            {
                                TipoTransmisionDocumento.Codigo = dr.IsDBNull(dr.GetOrdinal("Codigo")) ? "" : dr.GetString(dr.GetOrdinal("Codigo")).Trim();
                                TipoTransmisionDocumento.Descripcion = dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : dr.GetString(dr.GetOrdinal("Descripcion")).Trim();
                            };

                            lstTiposTransmisionDocumento.Add(TipoTransmisionDocumento);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                }
            }

            return lstTiposTransmisionDocumento;
        }

        public List<CondicionesContrato> ConsultaCondicionesContrato()
        {
            List<CondicionesContrato> lstCondicionesContrato = new List<CondicionesContrato>();

            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_LISTAR_CONDICION_CONTRATO", conexion, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CondicionesContrato condicioncontrato = new CondicionesContrato();
                            {
                                condicioncontrato.CodigoCondicionContrato = dr.GetInt64(dr.GetOrdinal("CodigoCondicionContrato"));
                                condicioncontrato.NombreCondicionContrato = dr.IsDBNull(dr.GetOrdinal("NombreCondicionContrato")) ? "" : dr.GetString(dr.GetOrdinal("NombreCondicionContrato")).Trim();
                            };

                            lstCondicionesContrato.Add(condicioncontrato);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                }
            }

            return lstCondicionesContrato;
        }

        public List<TiposEnvio> ConsultaTiposEnvio()
        {
            List<TiposEnvio> lstTiposEnvio = new List<TiposEnvio>();

            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_LISTAR_TIPOENVIO", conexion, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TiposEnvio tipoEnvio = new TiposEnvio();
                            {
                                tipoEnvio.CodigoTipoEnvio = dr.GetInt64(dr.GetOrdinal("CodigoTipoEnvio"));
                                tipoEnvio.NombreTipoEnvio = dr.IsDBNull(dr.GetOrdinal("NombreTipoEnvio")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoEnvio")).Trim();
                            };

                            lstTiposEnvio.Add(tipoEnvio);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                }
            }

            return lstTiposEnvio;
        }

        public List<TiposOperacion> ConsultaTiposOperacion()
        {
            List<TiposOperacion> lstTiposOperacion = new List<TiposOperacion>();

            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_LISTAR_TIPOOPERACION", conexion, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TiposOperacion tipoOperacion = new TiposOperacion();
                            {
                                tipoOperacion.CodigoTipoOperacion = dr.GetInt64(dr.GetOrdinal("CodigoTipoOperacion"));
                                tipoOperacion.NombreTipoOperacion = dr.IsDBNull(dr.GetOrdinal("NombreTipoOperacion")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoOperacion")).Trim();
                            };

                            lstTiposOperacion.Add(tipoOperacion);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                }
            }

            return lstTiposOperacion;
        }

        public ResponseRegistroTemperatura RegistroTemperatura(RequestRegistroTemperatura request)
        {
            var response = new ResponseRegistroTemperatura();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_TEMPERATURA", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoTemperatura", request.CodigoTemperatura);
                    parametrosIn.AddWithValue("@CodigoTemperaturaSunat", request.CodigoTemperaturaSunat);
                    parametrosIn.AddWithValue("@NombreTemperatura", request.NombreTemperatura);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarTemperatura ConsultarTemperatura(RequestConsultarTemperatura request)
        {
            var response = new ResponseConsultarTemperatura();
            var listaTemperatura = new List<Temperatura>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoTemperatura", request.CodigoTemperatura);
                parametrosIn.Add("@CodigoTemperaturaSunat", request.CodigoTemperaturaSunat);
                parametrosIn.Add("@NombreTemperatura", request.NombreTemperatura);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_TEMPERATURA", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Temperatura Temperatura = new Temperatura();
                            Temperatura.CodigoTemperatura = dr.GetInt64(dr.GetOrdinal("CodigoTemperatura"));
                            Temperatura.CodigoTemperaturaSunat = dr.IsDBNull(dr.GetOrdinal("CodigoTemperaturaSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoTemperaturaSunat")).Trim();
                            Temperatura.NombreTemperatura = dr.IsDBNull(dr.GetOrdinal("NombreTemperatura")) ? "" : dr.GetString(dr.GetOrdinal("NombreTemperatura")).Trim();
                            Temperatura.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            Temperatura.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            Temperatura.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            Temperatura.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaTemperatura.Add(Temperatura);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaTemperatura = listaTemperatura;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroTipoBL RegistroTipoBL(RequestRegistroTipoBL request)
        {
            var response = new ResponseRegistroTipoBL();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_TIPOBL", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoTipoBL", request.CodigoTipoBL);
                    parametrosIn.AddWithValue("@CodigoTipoBLSunat", request.CodigoTipoBLSunat);
                    parametrosIn.AddWithValue("@NombreTipoBL", request.NombreTipoBL);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarTipoBL ConsultarTipoBL(RequestConsultarTipoBL request)
        {
            var response = new ResponseConsultarTipoBL();
            var listaTipoBL = new List<TipoBL>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoTipoBL", request.CodigoTipoBL);
                parametrosIn.Add("@CodigoTipoBLSunat", request.CodigoTipoBLSunat);
                parametrosIn.Add("@NombreTipoBL", request.NombreTipoBL);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_TIPOBL", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TipoBL TipoBL = new TipoBL();
                            TipoBL.CodigoTipoBL = dr.GetInt64(dr.GetOrdinal("CodigoTipoBL"));
                            TipoBL.CodigoTipoBLSunat = dr.IsDBNull(dr.GetOrdinal("CodigoTipoBLSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoTipoBLSunat")).Trim();
                            TipoBL.NombreTipoBL = dr.IsDBNull(dr.GetOrdinal("NombreTipoBL")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoBL")).Trim();
                            TipoBL.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            TipoBL.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            TipoBL.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            TipoBL.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaTipoBL.Add(TipoBL);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaTipoBL = listaTipoBL;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroTipoContenedor RegistroTipoContenedor(RequestRegistroTipoContenedor request)
        {
            var response = new ResponseRegistroTipoContenedor();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_TIPOCONTENEDOR", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoTipoContenedor", request.CodigoTipoContenedor);
                    parametrosIn.AddWithValue("@CodigoIsoTipoContenedor", request.CodigoIsoTipoContenedor);
                    parametrosIn.AddWithValue("@CodigoIsoGrupoTipoContenedor", request.CodigoIsoGrupoTipoContenedor);
                    parametrosIn.AddWithValue("@NombreTipoContenedor", request.NombreTipoContenedor);
                    parametrosIn.AddWithValue("@CodigoAduanaTipoContenedor", request.CodigoAduanaTipoContenedor);
                    parametrosIn.AddWithValue("@CodTipoContenedor", request.CodTipoContenedor);
                    parametrosIn.AddWithValue("@TamanioTipoContenedor", request.TamanioTipoContenedor);
                    parametrosIn.AddWithValue("@IsoTipoContenedor", request.IsoTipoContenedor);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarTipoContenedor ConsultarTipoContenedor(RequestConsultarTipoContenedor request)
        {
            var response = new ResponseConsultarTipoContenedor();
            var listaTipoContenedor = new List<TipoContenedor>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoTipoContenedor", request.CodigoTipoContenedor);
                parametrosIn.Add("@CodigoIsoTipoContenedor", request.CodigoIsoTipoContenedor);
                parametrosIn.Add("@CodigoIsoGrupoTipoContenedor", request.CodigoIsoGrupoTipoContenedor);
                parametrosIn.Add("@NombreTipoContenedor", request.NombreTipoContenedor);
                parametrosIn.Add("@CodTipoContenedor", request.CodTipoContenedor);
                parametrosIn.Add("@TamanioTipoContenedor", request.TamanioTipoContenedor);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_TIPOCONTENEDOR", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TipoContenedor TipoContenedor = new TipoContenedor();
                            TipoContenedor.CodigoTipoContenedor = dr.GetInt64(dr.GetOrdinal("CodigoTipoContenedor"));
                            TipoContenedor.CodigoIsoTipoContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoIsoTipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodigoIsoTipoContenedor")).Trim();
                            TipoContenedor.CodigoIsoGrupoTipoContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoIsoGrupoTipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodigoIsoGrupoTipoContenedor")).Trim();
                            TipoContenedor.NombreTipoContenedor = dr.IsDBNull(dr.GetOrdinal("NombreTipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoContenedor")).Trim();
                            TipoContenedor.CodigoAduanaTipoContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoAduanaTipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodigoAduanaTipoContenedor")).Trim();
                            TipoContenedor.CodTipoContenedor = dr.IsDBNull(dr.GetOrdinal("CodTipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodTipoContenedor")).Trim();
                            TipoContenedor.TamanioTipoContenedor = dr.IsDBNull(dr.GetOrdinal("TamanioTipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("TamanioTipoContenedor")).Trim();
                            TipoContenedor.IsoTipoContenedor = dr.IsDBNull(dr.GetOrdinal("IsoTipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("IsoTipoContenedor")).Trim();
                            TipoContenedor.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            TipoContenedor.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            TipoContenedor.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            TipoContenedor.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaTipoContenedor.Add(TipoContenedor);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaTipoContenedor = listaTipoContenedor;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroTipoDocumento RegistroTipoDocumento(RequestRegistroTipoDocumento request)
        {
            var response = new ResponseRegistroTipoDocumento();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_TIPODOCUMENTO", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoTipoDocumento", request.CodigoTipoDocumento);
                    parametrosIn.AddWithValue("@CodigoTipoDocumentoSunat", request.CodigoTipoDocumentoSunat);
                    parametrosIn.AddWithValue("@NombreTipoDocumento", request.NombreTipoDocumento);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarTipoDocumento ConsultarTipoDocumento(RequestConsultarTipoDocumento request)
        {
            var response = new ResponseConsultarTipoDocumento();
            var listaTipoDocumento = new List<TipoDocumento>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoTipoDocumento", request.CodigoTipoDocumento);
                parametrosIn.Add("@CodigoTipoDocumentoSunat", request.CodigoTipoDocumentoSunat);
                parametrosIn.Add("@NombreTipoDocumento", request.NombreTipoDocumento);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_TIPODOCUMENTO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TipoDocumento TipoDocumento = new TipoDocumento();
                            TipoDocumento.CodigoTipoDocumento = dr.GetInt64(dr.GetOrdinal("CodigoTipoDocumento"));
                            TipoDocumento.CodigoTipoDocumentoSunat = dr.GetInt16(dr.GetOrdinal("CodigoTipoDocumentoSunat"));
                            TipoDocumento.NombreTipoDocumento = dr.IsDBNull(dr.GetOrdinal("NombreTipoDocumento")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoDocumento")).Trim();
                            TipoDocumento.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            TipoDocumento.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            TipoDocumento.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            TipoDocumento.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaTipoDocumento.Add(TipoDocumento);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaTipoDocumento = listaTipoDocumento;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroTipoEnvio RegistroTipoEnvio(RequestRegistroTipoEnvio request)
        {
            var response = new ResponseRegistroTipoEnvio();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_TIPOENVIO", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoTipoEnvio", request.CodigoTipoEnvio);
                    parametrosIn.AddWithValue("@CodigoTipoEnvioSunat", request.CodigoTipoEnvioSunat);
                    parametrosIn.AddWithValue("@NombreTipoEnvio", request.NombreTipoEnvio);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarTipoEnvio ConsultarTipoEnvio(RequestConsultarTipoEnvio request)
        {
            var response = new ResponseConsultarTipoEnvio();
            var listaTipoEnvio = new List<TipoEnvio>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoTipoEnvio", request.CodigoTipoEnvio);
                parametrosIn.Add("@CodigoTipoEnvioSunat", request.CodigoTipoEnvioSunat);
                parametrosIn.Add("@NombreTipoEnvio", request.NombreTipoEnvio);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_TIPOENVIO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TipoEnvio TipoEnvio = new TipoEnvio();
                            TipoEnvio.CodigoTipoEnvio = dr.GetInt64(dr.GetOrdinal("CodigoTipoEnvio"));
                            TipoEnvio.CodigoTipoEnvioSunat = dr.GetInt16(dr.GetOrdinal("CodigoTipoEnvioSunat"));
                            TipoEnvio.NombreTipoEnvio = dr.IsDBNull(dr.GetOrdinal("NombreTipoEnvio")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoEnvio")).Trim();
                            TipoEnvio.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            TipoEnvio.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            TipoEnvio.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            TipoEnvio.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaTipoEnvio.Add(TipoEnvio);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaTipoEnvio = listaTipoEnvio;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroTipoFlete RegistroTipoFlete(RequestRegistroTipoFlete request)
        {
            var response = new ResponseRegistroTipoFlete();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_TIPOFLETE", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoTipoFlete", request.CodigoTipoFlete);
                    parametrosIn.AddWithValue("@NombreTipoFlete", request.NombreTipoFlete);
                    parametrosIn.AddWithValue("@CodigoAduanaTipoFlete", request.CodigoAduanaTipoFlete);
                    parametrosIn.AddWithValue("@CodigoEquivalencia", request.CodigoEquivalencia);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarTipoFlete ConsultarTipoFlete(RequestConsultarTipoFlete request)
        {
            var response = new ResponseConsultarTipoFlete();
            var listaTipoFlete = new List<TipoFlete>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoTipoFlete", request.CodigoTipoFlete);
                parametrosIn.Add("@NombreTipoFlete", request.NombreTipoFlete);
                parametrosIn.Add("@CodigoAduanaTipoFlete", request.CodigoAduanaTipoFlete);
                parametrosIn.Add("@CodigoEquivalencia", request.CodigoEquivalencia);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_TIPOFLETE", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TipoFlete TipoFlete = new TipoFlete();
                            TipoFlete.CodigoTipoFlete = dr.GetInt64(dr.GetOrdinal("CodigoTipoFlete"));
                            TipoFlete.NombreTipoFlete = dr.IsDBNull(dr.GetOrdinal("NombreTipoFlete")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoFlete")).Trim();
                            TipoFlete.CodigoAduanaTipoFlete = dr.IsDBNull(dr.GetOrdinal("CodigoAduanaTipoFlete")) ? "" : dr.GetString(dr.GetOrdinal("CodigoAduanaTipoFlete")).Trim();
                            TipoFlete.CodigoEquivalencia = dr.IsDBNull(dr.GetOrdinal("CodigoEquivalencia")) ? "" : dr.GetString(dr.GetOrdinal("CodigoEquivalencia")).Trim();
                            TipoFlete.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            TipoFlete.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            TipoFlete.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            TipoFlete.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaTipoFlete.Add(TipoFlete);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaTipoFlete = listaTipoFlete;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroTipoLugarCarga RegistroTipoLugarCarga(RequestRegistroTipoLugarCarga request)
        {
            var response = new ResponseRegistroTipoLugarCarga();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_TIPOLUGARCARGA", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoTipoLugarCarga", request.CodigoTipoLugarCarga);
                    parametrosIn.AddWithValue("@CodigoTipoLugarCargaSunat", request.CodigoTipoLugarCargaSunat);
                    parametrosIn.AddWithValue("@NombreTipoLugarCarga", request.NombreTipoLugarCarga);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarTipoLugarCarga ConsultarTipoLugarCarga(RequestConsultarTipoLugarCarga request)
        {
            var response = new ResponseConsultarTipoLugarCarga();
            var listaTipoLugarCarga = new List<TipoLugarCarga>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoTipoLugarCarga", request.CodigoTipoLugarCarga);
                parametrosIn.Add("@CodigoTipoLugarCargaSunat", request.CodigoTipoLugarCargaSunat);
                parametrosIn.Add("@NombreTipoLugarCarga", request.NombreTipoLugarCarga);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_TIPOLUGARCARGA", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TipoLugarCarga TipoLugarCarga = new TipoLugarCarga();
                            TipoLugarCarga.CodigoTipoLugarCarga = dr.GetInt64(dr.GetOrdinal("CodigoTipoLugarCarga"));
                            TipoLugarCarga.CodigoTipoLugarCargaSunat = dr.GetInt16(dr.GetOrdinal("CodigoTipoLugarCargaSunat"));
                            TipoLugarCarga.NombreTipoLugarCarga = dr.IsDBNull(dr.GetOrdinal("NombreTipoLugarCarga")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoLugarCarga")).Trim();
                            TipoLugarCarga.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            TipoLugarCarga.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            TipoLugarCarga.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            TipoLugarCarga.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));
                            //TipoLugarCarga.EstadoRegistro = dr.GetBoolean(dr.GetOrdinal("EstadoRegistro"));

                            listaTipoLugarCarga.Add(TipoLugarCarga);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaTipoLugarCarga = listaTipoLugarCarga;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroTipoMovimiento RegistroTipoMovimiento(RequestRegistroTipoMovimiento request)
        {
            var response = new ResponseRegistroTipoMovimiento();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_TIPOMOVIMIENTO", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoTipoMovimiento", request.CodigoTipoMovimiento);
                    parametrosIn.AddWithValue("@CodigoTipoMovimientoSunat", request.CodigoTipoMovimientoSunat);
                    parametrosIn.AddWithValue("@NombreTipoMovimiento", request.NombreTipoMovimiento);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarTipoMovimiento ConsultarTipoMovimiento(RequestConsultarTipoMovimiento request)
        {
            var response = new ResponseConsultarTipoMovimiento();
            var listaTipoMovimiento = new List<TipoMovimiento>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoTipoMovimiento", request.CodigoTipoMovimiento);
                parametrosIn.Add("@CodigoTipoMovimientoSunat", request.CodigoTipoMovimientoSunat);
                parametrosIn.Add("@NombreTipoMovimiento", request.NombreTipoMovimiento);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_TIPOMOVIMIENTO", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TipoMovimiento TipoMovimiento = new TipoMovimiento();
                            TipoMovimiento.CodigoTipoMovimiento = dr.GetInt64(dr.GetOrdinal("CodigoTipoMovimiento"));
                            TipoMovimiento.CodigoTipoMovimientoSunat = dr.IsDBNull(dr.GetOrdinal("CodigoTipoMovimientoSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoTipoMovimientoSunat")).Trim();
                            TipoMovimiento.NombreTipoMovimiento = dr.IsDBNull(dr.GetOrdinal("NombreTipoMovimiento")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoMovimiento")).Trim();
                            TipoMovimiento.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            TipoMovimiento.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            TipoMovimiento.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            TipoMovimiento.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaTipoMovimiento.Add(TipoMovimiento);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaTipoMovimiento = listaTipoMovimiento;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroTipoNave RegistroTipoNave(RequestRegistroTipoNave request)
        {
            var response = new ResponseRegistroTipoNave();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_TIPONAVE", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoTipoNave", request.CodigoTipoNave);
                    parametrosIn.AddWithValue("@CodigoTipoNaveSunat", request.CodigoTipoNaveSunat);
                    parametrosIn.AddWithValue("@NombreTipoNave", request.NombreTipoNave);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarTipoNave ConsultarTipoNave(RequestConsultarTipoNave request)
        {
            var response = new ResponseConsultarTipoNave();
            var listaTipoNave = new List<TipoNave>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoTipoNave", request.CodigoTipoNave);
                parametrosIn.Add("@CodigoTipoNaveSunat", request.CodigoTipoNaveSunat);
                parametrosIn.Add("@NombreTipoNave", request.NombreTipoNave);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_TIPONAVE", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TipoNave TipoNave = new TipoNave();
                            TipoNave.CodigoTipoNave = dr.GetInt64(dr.GetOrdinal("CodigoTipoNave"));
                            TipoNave.CodigoTipoNaveSunat = dr.IsDBNull(dr.GetOrdinal("CodigoTipoNaveSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoTipoNaveSunat")).Trim();
                            TipoNave.NombreTipoNave = dr.IsDBNull(dr.GetOrdinal("NombreTipoNave")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoNave")).Trim();
                            TipoNave.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            TipoNave.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            TipoNave.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            TipoNave.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaTipoNave.Add(TipoNave);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaTipoNave = listaTipoNave;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroTipoOperacion RegistroTipoOperacion(RequestRegistroTipoOperacion request)
        {
            var response = new ResponseRegistroTipoOperacion();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_TIPOOPERACION", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoTipoOperacion", request.CodigoTipoOperacion);
                    parametrosIn.AddWithValue("@CodigoTipoOperacionSunat", request.CodigoTipoOperacionSunat);
                    parametrosIn.AddWithValue("@NombreTipoOperacion", request.NombreTipoOperacion);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarTipoOperacion ConsultarTipoOperacion(RequestConsultarTipoOperacion request)
        {
            var response = new ResponseConsultarTipoOperacion();
            var listaTipoOperacion = new List<TipoOperacion>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoTipoOperacion", request.CodigoTipoOperacion);
                parametrosIn.Add("@CodigoTipoOperacionSunat", request.CodigoTipoOperacionSunat);
                parametrosIn.Add("@NombreTipoOperacion", request.NombreTipoOperacion);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_TIPOOPERACION", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TipoOperacion TipoOperacion = new TipoOperacion();
                            TipoOperacion.CodigoTipoOperacion = dr.GetInt64(dr.GetOrdinal("CodigoTipoOperacion"));
                            TipoOperacion.CodigoTipoOperacionSunat = dr.GetByte(dr.GetOrdinal("CodigoTipoOperacionSunat"));
                            TipoOperacion.NombreTipoOperacion = dr.IsDBNull(dr.GetOrdinal("NombreTipoOperacion")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoOperacion")).Trim();
                            TipoOperacion.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            TipoOperacion.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            TipoOperacion.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            TipoOperacion.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaTipoOperacion.Add(TipoOperacion);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaTipoOperacion = listaTipoOperacion;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroUnidadMercancia RegistroUnidadMercancia(RequestRegistroUnidadMercancia request)
        {
            var response = new ResponseRegistroUnidadMercancia();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_UNIDADMERCANCIA", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoUnidadMercancia", request.CodigoUnidadMercancia);
                    parametrosIn.AddWithValue("@CodigoUnidadMercanciaSunat", request.CodigoUnidadMercanciaSunat);
                    parametrosIn.AddWithValue("@NombreUnidadMercancia", request.NombreUnidadMercancia);
                    parametrosIn.AddWithValue("@CodigoAduanaUnidadMercancia", request.CodigoAduanaUnidadMercancia);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarUnidadMercancia ConsultarUnidadMercancia(RequestConsultarUnidadMercancia request)
        {
            var response = new ResponseConsultarUnidadMercancia();
            var listaUnidadMercancia = new List<UnidadMercancia>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoUnidadMercancia", request.CodigoUnidadMercancia);
                parametrosIn.Add("@CodigoUnidadMercanciaSunat", request.CodigoUnidadMercanciaSunat);
                parametrosIn.Add("@NombreUnidadMercancia", request.NombreUnidadMercancia);
                parametrosIn.Add("@CodigoAduanaUnidadMercancia", request.CodigoAduanaUnidadMercancia);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_UNIDADMERCANCIA", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            UnidadMercancia UnidadMercancia = new UnidadMercancia();
                            UnidadMercancia.CodigoUnidadMercancia = dr.GetInt64(dr.GetOrdinal("CodigoUnidadMercancia"));
                            UnidadMercancia.CodigoUnidadMercanciaSunat = dr.IsDBNull(dr.GetOrdinal("CodigoUnidadMercanciaSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoUnidadMercanciaSunat")).Trim();
                            UnidadMercancia.NombreUnidadMercancia = dr.IsDBNull(dr.GetOrdinal("NombreUnidadMercancia")) ? "" : dr.GetString(dr.GetOrdinal("NombreUnidadMercancia")).Trim();
                            UnidadMercancia.CodigoAduanaUnidadMercancia = dr.IsDBNull(dr.GetOrdinal("CodigoAduanaUnidadMercancia")) ? "" : dr.GetString(dr.GetOrdinal("CodigoAduanaUnidadMercancia")).Trim();
                            UnidadMercancia.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            UnidadMercancia.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            UnidadMercancia.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            UnidadMercancia.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaUnidadMercancia.Add(UnidadMercancia);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaUnidadMercancia = listaUnidadMercancia;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseRegistroViaTransporte RegistroViaTransporte(RequestRegistroViaTransporte request)
        {
            var response = new ResponseRegistroViaTransporte();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_REGISTRAR_VIATRANSPORTE", conexion, true))
                {
                    SqlParameterCollection parametrosIn = cmd.Parameters;
                    parametrosIn.AddWithValue("@CodigoViaTransporte", request.CodigoViaTransporte);
                    parametrosIn.AddWithValue("@CodigoViaTransporteSunat", request.CodigoViaTransporteSunat);
                    parametrosIn.AddWithValue("@NombreViaTransporte", request.NombreViaTransporte);
                    parametrosIn.AddWithValue("@UsuarioRegistro", request.UsuarioRegistro);
                    parametrosIn.AddWithValue("@Accion", request.Accion);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            response.CodigoMensaje = dr.IsDBNull(dr.GetOrdinal("CodigoMensaje")) ? "3" : dr.GetString(dr.GetOrdinal("CodigoMensaje")).Trim();
                            response.Mensaje = dr.IsDBNull(dr.GetOrdinal("Mensaje")) ? "" : dr.GetString(dr.GetOrdinal("Mensaje")).Trim();
                        }
                    }
                }
                return response;
            }
        }

        public ResponseConsultarViaTransporte ConsultarViaTransporte(RequestConsultarViaTransporte request)
        {
            var response = new ResponseConsultarViaTransporte();
            var listaViaTransporte = new List<ViaTransporte>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoViaTransporte", request.CodigoViaTransporte);
                parametrosIn.Add("@CodigoViaTransporteSunat", request.CodigoViaTransporteSunat);
                parametrosIn.Add("@NombreViaTransporte", request.NombreViaTransporte);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_VIATRANSPORTE", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ViaTransporte ViaTransporte = new ViaTransporte();
                            ViaTransporte.CodigoViaTransporte = dr.GetInt64(dr.GetOrdinal("CodigoViaTransporte"));
                            ViaTransporte.CodigoViaTransporteSunat = dr.GetByte(dr.GetOrdinal("CodigoViaTransporteSunat"));
                            ViaTransporte.NombreViaTransporte = dr.IsDBNull(dr.GetOrdinal("NombreViaTransporte")) ? "" : dr.GetString(dr.GetOrdinal("NombreViaTransporte")).Trim();
                            ViaTransporte.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            ViaTransporte.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            ViaTransporte.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            ViaTransporte.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaViaTransporte.Add(ViaTransporte);
                        }
                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaViaTransporte = listaViaTransporte;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
                }
            }
            return response;
        }

        public ResponseConsultarPersonaxRol ConsultarPersonaxRol(RequestConsultarPersonaxRol request)
        {
            var response = new ResponseConsultarPersonaxRol();
            var listaPersonaxRol = new List<PersonaxRol>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoPersona", request.CodigoPersona);
                parametrosIn.Add("@CodigoRol", request.CodigoRol);
                parametrosIn.Add("@RazonSocialPersona", request.RazonSocialPersona);
                parametrosIn.Add("@NumeroDocumentoPersona", request.NumeroDocumentoPersona);

                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_PERSONA_POR_ROL", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            PersonaxRol PersonaxRol = new PersonaxRol();
                            PersonaxRol.CodigoPersona = dr.GetInt64(dr.GetOrdinal("CodigoPersona"));
                            PersonaxRol.RazonSocialPersona = dr.GetString(dr.GetOrdinal("RazonSocialPersona")).Trim();
                            PersonaxRol.NumeroDocumentoPersona = dr.IsDBNull(dr.GetOrdinal("NumeroDocumentoPersona")) ? "" : dr.GetString(dr.GetOrdinal("NumeroDocumentoPersona")).Trim();
                            PersonaxRol.NombreTipoDocumento = dr.GetString(dr.GetOrdinal("NombreTipoDocumento")).Trim();
                            PersonaxRol.NombrePais = dr.GetString(dr.GetOrdinal("NombrePais")).Trim();

                            listaPersonaxRol.Add(PersonaxRol);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaPersonaxRol = listaPersonaxRol;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());

                }

            }
            return response;
        }

    }
}
