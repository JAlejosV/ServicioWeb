using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAMARSA.TRANSMISIONES.Entidades.Persona;
using TRAMARSA.TRANSMISIONES.Entidades.Persona.Request;
using TRAMARSA.TRANSMISIONES.Entidades.Persona.Response;
using TRAMARSA.TRANSMISIONES.Framework;


namespace TRAMARSA.TRANSMISIONES.AccesoDatos
{
    public class RepositorioPersona : RepositorioBase<RepositorioPersona>
    {
        public RepositorioPersona(ContextoParaBaseDatos contexto) : base(contexto) { }

        public long RegistrarPersona(RegistraPersona request)
        {
            long CodigoPersona = 0;
            int result;
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int CodPersona = 0;

                parametrosIn.Add("@CodigoTipoDocumento", request.CodigoTipoDocumento);
                parametrosIn.Add("@CodigoPais", request.CodigoPais);
                parametrosIn.Add("@RazonSocialPersona", request.RazonSocialPersona);
                parametrosIn.Add("@NumeroDocumentoPersona", request.NumeroDocumentoPersona);
                parametrosIn.Add("@DireccionPersona", request.DireccionPersona);
                parametrosIn.Add("@TelefonoPersona", request.TelefonoPersona);
                parametrosIn.Add("@EmailPersona", request.EmailPersona);
                parametrosIn.Add("@ContactoPersona", request.ContactoPersona);
                parametrosIn.Add("@WebPersona", request.WebPersona);
                parametrosIn.Add("@UsuarioRegistro", request.UsuarioCreacion);

                parametrosOut.Add("@CodigoPersona", CodPersona);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_INSERTAR_PERSONA", conexion, parametrosIn, true, parametrosOut))
                {
                    result = cmd.ExecuteNonQuery();
                    CodigoPersona = long.Parse(cmd.Parameters["@CodigoPersona"].Value.ToString());
                    SqlHelper.CloseConnection(conexion);
                }

            }
            return CodigoPersona;
        }

        public long ModificarPersona(RegistraPersona request)
        {
            long result;
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();

                parametrosIn.Add("@CodigoPersona", request.CodigoPersona);
                parametrosIn.Add("@CodigoTipoDocumento", request.CodigoTipoDocumento);
                parametrosIn.Add("@CodigoPais", request.CodigoPais);
                parametrosIn.Add("@RazonSocialPersona", request.RazonSocialPersona);
                parametrosIn.Add("@NumeroDocumentoPersona", request.NumeroDocumentoPersona);
                parametrosIn.Add("@DireccionPersona", request.DireccionPersona);
                parametrosIn.Add("@TelefonoPersona", request.TelefonoPersona);
                parametrosIn.Add("@EmailPersona", request.EmailPersona);
                parametrosIn.Add("@ContactoPersona", request.ContactoPersona);
                parametrosIn.Add("@WebPersona", request.WebPersona);
                parametrosIn.Add("@EstadoRegistro", request.EstadoRegistro);
                parametrosIn.Add("@UsuarioRegistro", request.UsuarioActualizacion);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_MODIFICAR_PERSONA", conexion, parametrosIn, true))
                {
                    result = cmd.ExecuteNonQuery();
                    SqlHelper.CloseConnection(conexion);
                }

            }
            return result;
        }

        public bool RegistrarPersonaRol(List<PersonaRol> request)
        {
            int rows = 0;

            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB"));

            Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
            var PersonaRolDataTable = request.ToDataTable();
            parametrosIn.Add("@dtPersonaRol", PersonaRolDataTable);

            using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_REGISTRAR_PERSONAROL", conexion, parametrosIn, true))
            {
                rows = cmd.ExecuteNonQuery();
                SqlHelper.CloseConnection(conexion);
            }

            return rows > 0;
        }

        public ResponseConsultarPersona ConsultarPersona(RequestConsultarPersona request)
        {
            var response = new ResponseConsultarPersona();
            var listaPersona = new List<Persona>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
                int totRegs = 0;
                int cantRegs = 0;

                parametrosIn.Add("@CodigoPersona", request.CodigoPersona);
                parametrosIn.Add("@RazonSocialPersona", request.RazonSocialPersona);
                parametrosIn.Add("@NumeroDocumentoPersona", request.NumeroDocumentoPersona);
   
                parametrosIn.Add("@OrdenCampo", request.OrdenCampo);
                parametrosIn.Add("@OrdenOrientacion", request.OrdenOrientacion);
                parametrosIn.Add("@PaginaActual", request.PaginaActual);
                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina);

                parametrosOut.Add("@TotalRegistros", totRegs);
                parametrosOut.Add("@CantidadPaginas", cantRegs);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_PERSONA", conexion, parametrosIn, true, parametrosOut))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Persona Persona = new Persona();
                            Persona.CodigoPersona = dr.GetInt64(dr.GetOrdinal("CodigoPersona"));
                            Persona.RazonSocialPersona = dr.GetString(dr.GetOrdinal("RazonSocialPersona")).Trim();
                            Persona.NumeroDocumentoPersona = dr.IsDBNull(dr.GetOrdinal("NumeroDocumentoPersona")) ? "" : dr.GetString(dr.GetOrdinal("NumeroDocumentoPersona")).Trim();
                            Persona.NombreTipoDocumento = dr.GetString(dr.GetOrdinal("NombreTipoDocumento")).Trim();
                            Persona.NombrePais = dr.GetString(dr.GetOrdinal("NombrePais")).Trim();
                            Persona.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            Persona.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            Persona.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            Persona.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            listaPersona.Add(Persona);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaPersona = listaPersona;
                    response.TotalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
                    response.CantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());

                }

            }
            return response;
        }

        public ResponseConsultarPersona ValidarPersona(RequestConsultarPersona request)
        {
            var response = new ResponseConsultarPersona();
            var listaPersona = new List<Persona>();
            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {

                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();

                parametrosIn.Add("@CodigoPersona", request.CodigoPersona);
                parametrosIn.Add("@CodigoTipoDocumento", request.CodigoTipoDocumento);
                parametrosIn.Add("@NumeroDocumentoPersona", request.NumeroDocumentoPersona);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_VALIDAR_PERSONA", conexion, parametrosIn, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Persona Persona = new Persona();
                            Persona.NumeroDocumentoPersona = dr.GetString(dr.GetOrdinal("NumeroDocumentoPersona")).Trim();
                            listaPersona.Add(Persona);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }
                    response.ListaPersona = listaPersona;
                }
            }
            return response;
        }

        public List<DetallePersona> ConsultarDetallePersona(ConsultaDetallePersona request)
        {
            List<DetallePersona> lsDetallePersona = new List<DetallePersona>();
            List<PersonaRolConsulta> lstPersonaRol = new List<PersonaRolConsulta>();

            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TransmisionesDB")))
            {
                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();

                parametrosIn.Add("@CodigoPersona", request.CodigoPersona);

                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_DETALLE_PERSONA", conexion, parametrosIn, true))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            DetallePersona Persona = new DetallePersona();

                            Persona.CodigoPersona = dr.IsDBNull(dr.GetOrdinal("CodigoPersona")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoPersona"));
                            Persona.CodigoTipoDocumento = dr.IsDBNull(dr.GetOrdinal("CodigoTipoDocumento")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoTipoDocumento"));
                            Persona.NombreTipoDocumento = dr.IsDBNull(dr.GetOrdinal("NombreTipoDocumento")) ? "" : dr.GetString(dr.GetOrdinal("NombreTipoDocumento")).Trim();
                            Persona.CodigoPais = dr.IsDBNull(dr.GetOrdinal("CodigoPais")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoPais"));
                            Persona.NombrePais = dr.IsDBNull(dr.GetOrdinal("NombrePais")) ? "" : dr.GetString(dr.GetOrdinal("NombrePais")).Trim();
                            Persona.RazonSocialPersona = dr.IsDBNull(dr.GetOrdinal("RazonSocialPersona")) ? "" : dr.GetString(dr.GetOrdinal("RazonSocialPersona")).Trim();
                            Persona.NumeroDocumentoPersona = dr.IsDBNull(dr.GetOrdinal("NumeroDocumentoPersona")) ? "" : dr.GetString(dr.GetOrdinal("NumeroDocumentoPersona")).Trim();
                            Persona.DireccionPersona = dr.IsDBNull(dr.GetOrdinal("DireccionPersona")) ? "" : dr.GetString(dr.GetOrdinal("DireccionPersona")).Trim();
                            Persona.TelefonoPersona = dr.IsDBNull(dr.GetOrdinal("TelefonoPersona")) ? "" : dr.GetString(dr.GetOrdinal("TelefonoPersona")).Trim();
                            Persona.EmailPersona = dr.IsDBNull(dr.GetOrdinal("EmailPersona")) ? "" : dr.GetString(dr.GetOrdinal("EmailPersona")).Trim();
                            Persona.ContactoPersona = dr.IsDBNull(dr.GetOrdinal("ContactoPersona")) ? "" : dr.GetString(dr.GetOrdinal("ContactoPersona")).Trim();
                            Persona.WebPersona = dr.IsDBNull(dr.GetOrdinal("WebPersona")) ? "" : dr.GetString(dr.GetOrdinal("WebPersona")).Trim();
                            Persona.EstadoRegistro = dr.GetBoolean(dr.GetOrdinal("EstadoRegistro"));
                            Persona.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim();
                            Persona.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
                            Persona.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
                            Persona.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));

                            lsDetallePersona.Add(Persona);
                        }

                        dr.NextResult();

                        while (dr.Read())
                        {
                            PersonaRolConsulta  RolConsulta = new PersonaRolConsulta();
                            {
                                RolConsulta.CodigoPersonaRol = dr.IsDBNull(dr.GetOrdinal("CodigoPersonaRol")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoPersonaRol"));
                                RolConsulta.CodigoPersona = dr.IsDBNull(dr.GetOrdinal("CodigoPersona")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoPersona"));
                                RolConsulta.CodigoRol = dr.IsDBNull(dr.GetOrdinal("CodigoRol")) ? 0 : dr.GetInt64(dr.GetOrdinal("CodigoRol"));
                                RolConsulta.NombreRol = dr.IsDBNull(dr.GetOrdinal("NombreRol")) ? "" : dr.GetString(dr.GetOrdinal("NombreRol")).Trim();
                                RolConsulta.CodigoAduanaPersonaRol = dr.IsDBNull(dr.GetOrdinal("CodigoAduanaPersonaRol")) ? "" : dr.GetString(dr.GetOrdinal("CodigoAduanaPersonaRol")).Trim();
                            };

                            lstPersonaRol.Add(RolConsulta);
                        }

                        SqlHelper.CloseConnection(conexion);
                    }

                    foreach (var objPersona in lsDetallePersona)
                    {
                        objPersona.ListaPersonaRol = lstPersonaRol.Where(x => x.CodigoPersona == objPersona.CodigoPersona).ToList();
                    }
                }
            }

            return lsDetallePersona;

        }
    }
}
