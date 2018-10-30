//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using TRAMARSA.TRANSMISIONES.DTO.Tramarsa;
//using TRAMARSA.TRANSMISIONES.DTO.AcuerdosComerciales;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales;
//using TRAMARSA.TRANSMISIONES.Framework;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales.DetalleCatalogo;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales.GrupoPuertoExterno;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales.DetalleGrupoPuertoExterno;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales.Tarifa;
//using TRAMARSA.TRANSMISIONES.Entidades.Tramarsa.Sucursal;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales.TerminalPortuario;
//using TRAMARSA.TRANSMISIONES.Entidades.Tramarsa.Linea;
//using TRAMARSA.TRANSMISIONES.Entidades.Tramarsa.Moneda;
//using TRAMARSA.TRANSMISIONES.Entidades.Tramarsa.Nave;
//using TRAMARSA.TRANSMISIONES.Entidades.Tramarsa.Tarifa;
//using TRAMARSA.TRANSMISIONES.Entidades.Tramarsa.BL;
//using TRAMARSA.TRANSMISIONES.Entidades.Tramarsa.Cliente;
//using TRAMARSA.TRANSMISIONES.Entidades.Tramarsa.Puerto;
//using TRAMARSA.TRANSMISIONES.Entidades.Core;
//using TRAMARSA.TRANSMISIONES.Entidades.Tramarsa.Servicio;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales.AcuerdoComercial;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales.TipoContenedorExterno;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales.TipoContenedor;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales.ClaseContenedor;
//using TRAMARSA.TRANSMISIONES.Entidades.Tramarsa;
//using TRAMARSA.TRANSMISIONES.Entidades.Constantes;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales.PesoVariable;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales.Notificacion;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales.CatalogoTablas;
//using TRAMARSA.TRANSMISIONES.Entidades.AcuerdosComerciales.Puerto;
//using TRAMARSA.TRANSMISIONES.Entidades.Tramarsa.Pais;
//using TRAMARSA.TRANSMISIONES.DTO;

//namespace TRAMARSA.TRANSMISIONES.AccesoDatos
//{
//    public class RepositorioAcuerdoComercial : RepositorioBase<RepositorioAcuerdoComercial>
//    {
//        public RepositorioAcuerdoComercial(ContextoParaBaseDatos contexto) : base(contexto) { }

//        public List<SucursalBE> ConsultaSucursales()
//        {
//            List<SucursalBE> lstSucursales = new List<SucursalBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {
//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTA_SUCURSALES", conexion, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            SucursalBE sucursal = new SucursalBE()
//                            {
//                                Nombre = dr.IsDBNull(dr.GetOrdinal("NombreSucursal")) ? "" : dr.GetString(dr.GetOrdinal("NombreSucursal")).Trim(),
//                                Codigo = dr.IsDBNull(dr.GetOrdinal("CodigoSucursal")) ? "" : dr.GetString(dr.GetOrdinal("CodigoSucursal")).Trim(),
//                                Puerto = dr.IsDBNull(dr.GetOrdinal("CodigoPuerto")) ? "" : dr.GetString(dr.GetOrdinal("CodigoPuerto")).Trim()
//                            };

//                            lstSucursales.Add(sucursal);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return lstSucursales;

//        }

//        public List<TerminalPortuarioBE> ConsultarTerminalPortuario()
//        {
//            List<TerminalPortuarioBE> lstTerminalesPortuarios = new List<TerminalPortuarioBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {
//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTA_TERMINAL_PORTUARIO", conexion, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            TerminalPortuarioBE terminalPortuario = new TerminalPortuarioBE()
//                            {
//                                CodigoAlmacen = dr.IsDBNull(dr.GetOrdinal("CodigoAlmacen")) ? "" : dr.GetString(dr.GetOrdinal("CodigoAlmacen")).Trim(),
//                                NombreAlmacen = dr.IsDBNull(dr.GetOrdinal("NombreAlmacen")) ? "" : dr.GetString(dr.GetOrdinal("NombreAlmacen")).Trim(),
//                                CodigoSucursal = dr.IsDBNull(dr.GetOrdinal("CodigoSucursal")) ? "" : dr.GetString(dr.GetOrdinal("CodigoSucursal")).Trim()
//                            };

//                            lstTerminalesPortuarios.Add(terminalPortuario);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }
//            return lstTerminalesPortuarios;
//        }


//        public List<LineaBE> ConsultarLineas()
//        {
//            List<LineaBE> lstLineas = new List<LineaBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {
//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTA_LINEAS", conexion, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            LineaBE linea = new LineaBE()
//                            {
//                                Codigo = dr.IsDBNull(dr.GetOrdinal("CodigoLinea")) ? "" : dr.GetString(dr.GetOrdinal("CodigoLinea")).Trim(),
//                                Nombre = dr.IsDBNull(dr.GetOrdinal("NombreLinea")) ? "" : dr.GetString(dr.GetOrdinal("NombreLinea")).Trim(),
//                                Carrier = dr.IsDBNull(dr.GetOrdinal("Carrier")) ? "" : dr.GetString(dr.GetOrdinal("Carrier")).Trim()
//                            };

//                            lstLineas.Add(linea);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return lstLineas;

//        }

//        public List<MonedaBE> ConsultarMoneda()
//        {
//            List<MonedaBE> lstMonedas = new List<MonedaBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {
//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTA_MONEDAS", conexion, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            MonedaBE moneda = new MonedaBE()
//                            {
//                                Codigo = dr.IsDBNull(dr.GetOrdinal("CodigoMoneda")) ? "" : dr.GetString(dr.GetOrdinal("CodigoMoneda")).Trim(),
//                                Nombre = dr.IsDBNull(dr.GetOrdinal("Abreviatura")) ? "" : dr.GetString(dr.GetOrdinal("Abreviatura")).Trim(),
//                                CodigoPais = dr.IsDBNull(dr.GetOrdinal("CodigoPais")) ? "" : dr.GetString(dr.GetOrdinal("CodigoPais")).Trim()
//                            };

//                            lstMonedas.Add(moneda);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return lstMonedas;

//        }

//        public List<NaveBE> ConsultarNave(ConsultaNavesBE request, out int totalRegistros, out int cantidadPaginas)
//        {
//            List<NaveBE> lstNaves = new List<NaveBE>();
//            List<DetalleArriboNaveBE> lstDetalleArriboNaveBE = new List<DetalleArriboNaveBE>();


//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {

//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
//                int totRegs = 0;
//                int cantRegs = 0;


//                parametrosIn.Add("@OrdenCampo", string.IsNullOrEmpty(request.OrdenCampo) ? string.Empty : request.OrdenCampo);
//                parametrosIn.Add("@OrdenOrientacion", string.IsNullOrEmpty(request.OrdenOrientacion) ? string.Empty : request.OrdenOrientacion);
//                parametrosIn.Add("@PaginaActual", request.PaginaActual == null ? new Nullable<int>() : request.PaginaActual);
//                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina == null ? new Nullable<int>() : request.NroRegistrosPorPagina);
//                parametrosIn.Add("@CodNav", string.IsNullOrEmpty(request.Codigo) ? string.Empty : request.Codigo);
//                parametrosIn.Add("@NomNav", string.IsNullOrEmpty(request.Nombre) ? string.Empty : request.Nombre);
//                parametrosIn.Add("@NumVia", string.IsNullOrEmpty(request.NumeroViaje) ? string.Empty : request.NumeroViaje);

//                parametrosOut.Add("@TotalRegistros", totRegs);
//                parametrosOut.Add("@CantidadPaginas", cantRegs);



//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTA_NAVES", conexion, parametrosIn, true, parametrosOut))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            NaveBE nave = new NaveBE();
//                            nave.Codigo = dr.IsDBNull(dr.GetOrdinal("CodigoNave")) ? "" : dr.GetString(dr.GetOrdinal("CodigoNave")).Trim();
//                            nave.Nombre = dr.IsDBNull(dr.GetOrdinal("NombreNave")) ? "" : dr.GetString(dr.GetOrdinal("NombreNave")).Trim();
//                            nave.NumeroViaje = dr.IsDBNull(dr.GetOrdinal("NumeroViaje")) ? "" : dr.GetString(dr.GetOrdinal("NumeroViaje")).Trim();

//                            lstNaves.Add(nave);
//                        }

//                        dr.NextResult();

//                        while (dr.Read())
//                        {
//                            DetalleArriboNaveBE DetalleArriboNave = new DetalleArriboNaveBE()
//                            {
//                                CodigoNave = dr.IsDBNull(dr.GetOrdinal("CodigoNave")) ? "" : dr.GetString(dr.GetOrdinal("CodigoNave")).Trim(),
//                                CodigoSucursal = dr.IsDBNull(dr.GetOrdinal("CodigoSucursal")) ? "" : dr.GetString(dr.GetOrdinal("CodigoSucursal")).Trim(),
//                                FechaArribo = dr.IsDBNull(dr.GetOrdinal("FechaArribo")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaArribo")),
//                                NumeroViaje = dr.IsDBNull(dr.GetOrdinal("NumeroViaje")) ? "" : dr.GetString(dr.GetOrdinal("NumeroViaje")).Trim()
//                            };

//                            lstDetalleArriboNaveBE.Add(DetalleArriboNave);
//                        }

//                        SqlHelper.CloseConnection(conexion);
//                    }

//                    foreach (var nave in lstNaves)
//                    {
//                        nave.DetalleArriboNaveList = lstDetalleArriboNaveBE.Where(x => x.CodigoNave == nave.Codigo).ToList();
//                    }


//                    totalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
//                    cantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());

//                }


//            }

//            return lstNaves;

//        }

//        public List<TarifaBE> ConsultarTarifa(ConsultaTarifasBE request, out int totalRegistros, out int cantidadPaginas)
//        {
//            List<TarifaBE> lstTarifas = new List<TarifaBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {

//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
//                int totRegs = 0;
//                int cantRegs = 0;

//                parametrosIn.Add("@OrdenCampo", string.IsNullOrEmpty(request.OrdenCampo) ? string.Empty : request.OrdenCampo);
//                parametrosIn.Add("@OrdenOrientacion", string.IsNullOrEmpty(request.OrdenOrientacion) ? string.Empty : request.OrdenOrientacion);
//                parametrosIn.Add("@PaginaActual", request.PaginaActual == null ? new Nullable<int>() : request.PaginaActual);
//                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina == null ? new Nullable<int>() : request.NroRegistrosPorPagina);
//                parametrosIn.Add("@CodigoLinea", string.IsNullOrEmpty(request.CodigoLinea) ? string.Empty : request.CodigoLinea);
//                parametrosIn.Add("@CodRegimen", string.IsNullOrEmpty(request.CodigoRegimen) ? string.Empty : request.CodigoRegimen);
//                parametrosIn.Add("@CodConcepto", string.IsNullOrEmpty(request.CodigoConcepto) ? string.Empty : request.CodigoConcepto);
//                parametrosIn.Add("@CodTarifa", string.IsNullOrEmpty(request.CodigoTarifa) ? string.Empty : request.CodigoTarifa);
//                parametrosIn.Add("@DescripcionTarifa", string.IsNullOrEmpty(request.DescripcionTarifa) ? string.Empty : request.DescripcionTarifa);

//                parametrosOut.Add("@TotalRegistros", totRegs);
//                parametrosOut.Add("@CantidadPaginas", cantRegs);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTA_TARIFAS", conexion, parametrosIn, true, parametrosOut))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            TarifaBE tarifa = new TarifaBE()
//                            {
//                                CodigoConcepto = dr.IsDBNull(dr.GetOrdinal("CodigoConcepto")) ? "" : dr.GetString(dr.GetOrdinal("CodigoConcepto")).Trim(),
//                                NombreConcepto = dr.IsDBNull(dr.GetOrdinal("NombreConcepto")) ? "" : dr.GetString(dr.GetOrdinal("NombreConcepto")).Trim(),
//                                AbreviacionConcepto = dr.IsDBNull(dr.GetOrdinal("AbreviacionConcepto")) ? "" : dr.GetString(dr.GetOrdinal("AbreviacionConcepto")).Trim(),
//                                CodigoTarifa = dr.IsDBNull(dr.GetOrdinal("CodigoTarifa")) ? "" : dr.GetString(dr.GetOrdinal("CodigoTarifa")).Trim(),
//                                NombreTarifa = dr.IsDBNull(dr.GetOrdinal("NombreTarifa")) ? "" : dr.GetString(dr.GetOrdinal("NombreTarifa")).Trim(),
//                                CodigoRegimen = dr.IsDBNull(dr.GetOrdinal("CodigoRegimen")) ? "" : dr.GetString(dr.GetOrdinal("CodigoRegimen")).Trim(),
//                                CodigoUnidadCalculo = dr.IsDBNull(dr.GetOrdinal("CodigoUnidadCalculo")) ? "" : dr.GetString(dr.GetOrdinal("CodigoUnidadCalculo")).Trim()
//                            };

//                            lstTarifas.Add(tarifa);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }

//                    totalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
//                    cantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
//                }

//            }

//            return lstTarifas;

//        }

//        public List<PuertoBE> ConsultarPuertos(ConsultaPuertosBE request, out int totalRegistros, out int cantidadPaginas)
//        {
//            List<PuertoBE> lstPuertos = new List<PuertoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {

//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
//                int totRegs = 0;
//                int cantRegs = 0;

//                parametrosIn.Add("@OrdenCampo", string.IsNullOrEmpty(request.OrdenCampo) ? string.Empty : request.OrdenCampo);
//                parametrosIn.Add("@OrdenOrientacion", string.IsNullOrEmpty(request.OrdenOrientacion) ? string.Empty : request.OrdenOrientacion);
//                parametrosIn.Add("@PaginaActual", request.PaginaActual == null ? new Nullable<int>() : request.PaginaActual);
//                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina == null ? new Nullable<int>() : request.NroRegistrosPorPagina);
//                parametrosIn.Add("@CodigoPuerto", string.IsNullOrEmpty(request.CodigoPuerto) ? string.Empty : request.CodigoPuerto);
//                parametrosIn.Add("@NombrePuerto", string.IsNullOrEmpty(request.NombrePuerto) ? string.Empty : request.NombrePuerto);
//                parametrosIn.Add("@CodigoPais", string.IsNullOrEmpty(request.CodigoPais) ? string.Empty : request.CodigoPais);

//                parametrosOut.Add("@TotalRegistros", totRegs);
//                parametrosOut.Add("@CantidadPaginas", cantRegs);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTA_PUERTOS", conexion, parametrosIn, true, parametrosOut))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            PuertoBE puerto = new PuertoBE()
//                            {
//                                Codigo = dr.IsDBNull(dr.GetOrdinal("CodigoPuerto")) ? "" : dr.GetString(dr.GetOrdinal("CodigoPuerto")).Trim(),
//                                Nombre = dr.IsDBNull(dr.GetOrdinal("NombrePuerto")) ? "" : dr.GetString(dr.GetOrdinal("NombrePuerto")).Trim(),
//                                CodigoPais = dr.IsDBNull(dr.GetOrdinal("CodigoPais")) ? "" : dr.GetString(dr.GetOrdinal("CodigoPais")).Trim()
//                            };

//                            lstPuertos.Add(puerto);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }

//                    totalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
//                    cantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
//                }
//            }

//            return lstPuertos;
//        }

//        public List<BLDocumentoOrigenBE> ConsultarBL_DocumentoOrigen(ConsultaBLDocumentoOrigenBE request, out int totalRegistros, out int cantidadPaginas)
//        {
//            List<BLDocumentoOrigenBE> lstDocumentosOrigen = new List<BLDocumentoOrigenBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {

//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
//                int totRegs = 0;
//                int cantRegs = 0;

//                parametrosIn.Add("@OrdenCampo", string.IsNullOrEmpty(request.OrdenCampo) ? string.Empty : request.OrdenCampo);
//                parametrosIn.Add("@OrdenOrientacion", string.IsNullOrEmpty(request.OrdenOrientacion) ? string.Empty : request.OrdenOrientacion);
//                parametrosIn.Add("@PaginaActual", request.PaginaActual == null ? new Nullable<int>() : request.PaginaActual);
//                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina == null ? new Nullable<int>() : request.NroRegistrosPorPagina);
//                parametrosIn.Add("@CodNav", string.IsNullOrEmpty(request.CodNave) ? string.Empty : request.CodNave);
//                parametrosIn.Add("@NumVia", string.IsNullOrEmpty(request.NumViaje) ? string.Empty : request.NumViaje);
//                parametrosIn.Add("@PtoOri", string.IsNullOrEmpty(request.PuertoOrigen) ? string.Empty : request.PuertoOrigen);
//                parametrosIn.Add("@PtoEmb", string.IsNullOrEmpty(request.PuertoEmbarque) ? string.Empty : request.PuertoEmbarque);
//                parametrosIn.Add("@PtoDes", string.IsNullOrEmpty(request.PuertoDesembarque) ? string.Empty : request.PuertoDesembarque);
//                parametrosIn.Add("@DesFin", string.IsNullOrEmpty(request.DestinoFinal) ? string.Empty : request.DestinoFinal);
//                parametrosIn.Add("@CodLin", string.IsNullOrEmpty(request.CodLinea) ? string.Empty : request.CodLinea);
//                parametrosIn.Add("@NroBL", string.IsNullOrEmpty(request.NroBL) ? string.Empty : request.NroBL);
//                parametrosIn.Add("@TipBL", string.IsNullOrEmpty(request.TipoBL) ? string.Empty : request.TipoBL);
//                parametrosIn.Add("@CodCtn", string.IsNullOrEmpty(request.CodContenedor) ? string.Empty : request.CodContenedor);
//                parametrosIn.Add("@TipoDocumento", string.IsNullOrEmpty(request.TipoDocumento) ? string.Empty : request.TipoDocumento);
//                parametrosIn.Add("@NroBkn", string.IsNullOrEmpty(request.NroBkn) ? string.Empty : request.NroBkn);
//                parametrosIn.Add("@CodigoInterlocutor", string.IsNullOrEmpty(request.CodigoInterlocutor) ? string.Empty : request.CodigoInterlocutor);


//                parametrosOut.Add("@TotalRegistros", totRegs);
//                parametrosOut.Add("@CantidadPaginas", cantRegs);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTA_BLS", conexion, parametrosIn, true, parametrosOut))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            BLDocumentoOrigenBE documento = new BLDocumentoOrigenBE();

//                            documento.CodNave = dr.IsDBNull(dr.GetOrdinal("CodNave")) ? "" : dr.GetString(dr.GetOrdinal("CodNave")).Trim();
//                            documento.DescripcionNave = dr.IsDBNull(dr.GetOrdinal("Nave")) ? "" : dr.GetString(dr.GetOrdinal("Nave")).Trim();
//                            documento.NumViaje = dr.IsDBNull(dr.GetOrdinal("NumViaje")) ? "" : dr.GetString(dr.GetOrdinal("NumViaje")).Trim();
//                            documento.PuertoOrigen = dr.IsDBNull(dr.GetOrdinal("PuertoOrigen")) ? "" : dr.GetString(dr.GetOrdinal("PuertoOrigen")).Trim();
//                            documento.PuertoEmbarque = dr.IsDBNull(dr.GetOrdinal("PuertoEmbarque")) ? "" : dr.GetString(dr.GetOrdinal("PuertoEmbarque")).Trim();
//                            documento.PuertoDesembarque = dr.IsDBNull(dr.GetOrdinal("PuertoDesembarque")) ? "" : dr.GetString(dr.GetOrdinal("PuertoDesembarque")).Trim();
//                            documento.DestinoFinal = dr.IsDBNull(dr.GetOrdinal("DestinoFinal")) ? "" : dr.GetString(dr.GetOrdinal("DestinoFinal")).Trim();
//                            documento.CodLinea = dr.IsDBNull(dr.GetOrdinal("CodLinea")) ? "" : dr.GetString(dr.GetOrdinal("CodLinea")).Trim();
//                            documento.NroBL = dr.IsDBNull(dr.GetOrdinal("NroBL")) ? "" : dr.GetString(dr.GetOrdinal("NroBL")).Trim();
//                            documento.TipoBL = dr.IsDBNull(dr.GetOrdinal("TipoBL")) ? "" : dr.GetString(dr.GetOrdinal("TipoBL")).Trim();
//                            documento.CodigoConsignatario = dr.IsDBNull(dr.GetOrdinal("CodigoConsignatario")) ? "" : dr.GetString(dr.GetOrdinal("CodigoConsignatario")).Trim();
//                            documento.RucConsignatario = dr.IsDBNull(dr.GetOrdinal("RucConsignatario")) ? "" : dr.GetString(dr.GetOrdinal("RucConsignatario")).Trim();
//                            documento.Consignatario = dr.IsDBNull(dr.GetOrdinal("Consignatario")) ? "" : dr.GetString(dr.GetOrdinal("Consignatario")).Trim();
//                            documento.DireccionConsignatario = dr.IsDBNull(dr.GetOrdinal("DireccionConsignatario")) ? "" : dr.GetString(dr.GetOrdinal("DireccionConsignatario")).Trim();
//                            documento.CodigoEmbarque = dr.IsDBNull(dr.GetOrdinal("CodigoEmbarque")) ? "" : dr.GetString(dr.GetOrdinal("CodigoEmbarque")).Trim();
//                            documento.CodigoServicio = dr.IsDBNull(dr.GetOrdinal("CodigoServicio")) ? "" : dr.GetString(dr.GetOrdinal("CodigoServicio")).Trim();
//                            documento.Servicio = dr.IsDBNull(dr.GetOrdinal("Servicio")) ? "" : dr.GetString(dr.GetOrdinal("Servicio")).Trim();
//                            documento.Fec_BL = dr.IsDBNull(dr.GetOrdinal("Fec_BL")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("Fec_BL"));
//                            documento.CodigoContenedor = dr.IsDBNull(dr.GetOrdinal("CodContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodContenedor")).Trim();
//                            documento.TipoDocumento = dr.IsDBNull(dr.GetOrdinal("TipoDocumento")) ? "" : dr.GetString(dr.GetOrdinal("TipoDocumento")).Trim();
//                            documento.NroBkn = dr.IsDBNull(dr.GetOrdinal("NroBkn")) ? "" : dr.GetString(dr.GetOrdinal("NroBkn")).Trim();
//                            documento.NumeroDocumentoBLMaster = dr.IsDBNull(dr.GetOrdinal("NroBLMaster")) ? "" : dr.GetString(dr.GetOrdinal("NroBLMaster")).Trim();
//                            documento.CodigoNotificante = dr.IsDBNull(dr.GetOrdinal("CodigoNotificante")) ? "" : dr.GetString(dr.GetOrdinal("CodigoNotificante")).Trim();
//                            documento.RucNotificante = dr.IsDBNull(dr.GetOrdinal("RucNotificante")) ? "" : dr.GetString(dr.GetOrdinal("RucNotificante")).Trim();
//                            documento.Notificante = dr.IsDBNull(dr.GetOrdinal("Notificante")) ? "" : dr.GetString(dr.GetOrdinal("Notificante")).Trim();
//                            documento.CodigoEmbarcador = dr.IsDBNull(dr.GetOrdinal("CodigoEmbarcador")) ? "" : dr.GetString(dr.GetOrdinal("CodigoEmbarcador")).Trim();
//                            documento.RucEmbarcador = dr.IsDBNull(dr.GetOrdinal("RucEmbarcador")) ? "" : dr.GetString(dr.GetOrdinal("RucEmbarcador")).Trim();
//                            documento.Embarcador = dr.IsDBNull(dr.GetOrdinal("Embarcador")) ? "" : dr.GetString(dr.GetOrdinal("Embarcador")).Trim();

//                            documento.CodigoRegimen = dr.IsDBNull(dr.GetOrdinal("CodigoRegimen")) ? "" : dr.GetString(dr.GetOrdinal("CodigoRegimen")).Trim();

//                            lstDocumentosOrigen.Add(documento);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }

//                    totalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
//                    cantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
//                }
//            }

//            return lstDocumentosOrigen;

//        }

//        public List<DetalleCatalogoBE> ConsultarDetalleCatalogo()
//        {
//            List<DetalleCatalogoBE> lstDetalleCatalogos = new List<DetalleCatalogoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("Reclamos")))
//            {

//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTA_DETALLECATALOGO", conexion, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            DetalleCatalogoBE nave = new DetalleCatalogoBE()
//                            {
//                                IdCatalogo = dr.IsDBNull(dr.GetOrdinal("IdCatalogo")) ? new Nullable<int>() : dr.GetInt32(dr.GetOrdinal("IdCatalogo")),
//                                Nombre = dr.IsDBNull(dr.GetOrdinal("Nombre")) ? "" : dr.GetString(dr.GetOrdinal("Nombre")).Trim(),
//                                Codigo = dr.IsDBNull(dr.GetOrdinal("Codigo")) ? "" : dr.GetString(dr.GetOrdinal("Codigo")).Trim(),
//                                CodigoCatalogo = dr.IsDBNull(dr.GetOrdinal("CodigoCatalogo")) ? "" : dr.GetString(dr.GetOrdinal("CodigoCatalogo")).Trim(),
//                                Label = dr.IsDBNull(dr.GetOrdinal("Label")) ? "" : dr.GetString(dr.GetOrdinal("Label")).Trim(),
//                                Descripcion = dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : dr.GetString(dr.GetOrdinal("Descripcion")).Trim(),
//                                Mnemonico = dr.IsDBNull(dr.GetOrdinal("Mnemonico")) ? "" : dr.GetString(dr.GetOrdinal("Mnemonico")).Trim(),
//                                Valor1 = dr.IsDBNull(dr.GetOrdinal("Val1")) ? "" : dr.GetString(dr.GetOrdinal("Val1")).Trim(),
//                                Valor2 = dr.IsDBNull(dr.GetOrdinal("Val2")) ? "" : dr.GetString(dr.GetOrdinal("Val2")).Trim()
//                            };

//                            lstDetalleCatalogos.Add(nave);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return lstDetalleCatalogos;

//        }

//        public List<GrupoPuertoExternoBE> ConsultarGrupoPuertoExterno(ConsultaGrupoPuertoExternoBE request, out int totalRegistros, out int cantidadPaginas)
//        {
//            List<GrupoPuertoExternoBE> lstGrupoPuertoExterno = new List<GrupoPuertoExternoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {

//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
//                int totRegs = 0;
//                int cantRegs = 0;

//                parametrosIn.Add("@OrdenCampo", string.IsNullOrEmpty(request.OrdenCampo) ? string.Empty : request.OrdenCampo);
//                parametrosIn.Add("@OrdenOrientacion", string.IsNullOrEmpty(request.OrdenOrientacion) ? string.Empty : request.OrdenOrientacion);
//                parametrosIn.Add("@PaginaActual", request.PaginaActual == null ? new Nullable<int>() : request.PaginaActual);
//                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina == null ? new Nullable<int>() : request.NroRegistrosPorPagina);
//                parametrosIn.Add("@CodigoGrupoPuerto", request.CodigoGrupoPuerto);
//                parametrosIn.Add("@NombreGrupoPuerto", string.IsNullOrEmpty(request.NombreGrupoPuerto) ? string.Empty : request.NombreGrupoPuerto);
//                parametrosIn.Add("@CodigoLinea", string.IsNullOrEmpty(request.CodigoLinea) ? string.Empty : request.CodigoLinea);

//                parametrosOut.Add("@TotalRegistros", totRegs);
//                parametrosOut.Add("@CantidadPaginas", cantRegs);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTA_GRUPOPUERTOEXTERNO", conexion, parametrosIn, true, parametrosOut))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            GrupoPuertoExternoBE grupopuertoexterno = new GrupoPuertoExternoBE();

//                            grupopuertoexterno.CodigoGrupoPuerto = dr.IsDBNull(dr.GetOrdinal("CodigoGrupoPuerto")) ? 0 : dr.GetInt32(dr.GetOrdinal("CodigoGrupoPuerto"));
//                            grupopuertoexterno.NombreGrupoPuerto = dr.IsDBNull(dr.GetOrdinal("NombreGrupoPuerto")) ? "" : dr.GetString(dr.GetOrdinal("NombreGrupoPuerto")).Trim();
//                            grupopuertoexterno.CodigoLinea = dr.IsDBNull(dr.GetOrdinal("CodigoLinea")) ? "" : dr.GetString(dr.GetOrdinal("CodigoLinea")).Trim();
//                            grupopuertoexterno.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioRegistro")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioRegistro")).Trim();
//                            grupopuertoexterno.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraRegistro")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraRegistro"));
//                            grupopuertoexterno.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim();
//                            grupopuertoexterno.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));
//                            grupopuertoexterno.EstadoRegistro = dr.GetBoolean(dr.GetOrdinal("EstadoRegistro"));


//                            lstGrupoPuertoExterno.Add(grupopuertoexterno);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }


//                    totalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
//                    cantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
//                }
//            }

//            return lstGrupoPuertoExterno;
//        }

//        public List<DetalleGrupoPuertoExternoBE> ConsultarDetalleGrupoPuertoExterno(int codigoGrupoPuerto)
//        {
//            List<DetalleGrupoPuertoExternoBE> lstDetalleGrupoPuertoExterno = new List<DetalleGrupoPuertoExternoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {

//                Dictionary<string, object> parametros = new Dictionary<string, object>();
//                parametros.Add("@CodigoGrupoPuerto", codigoGrupoPuerto);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTA_DETALLEGRUPOPUERTOEXTERNO", conexion, parametros, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            DetalleGrupoPuertoExternoBE detgrupopuertoexterno = new DetalleGrupoPuertoExternoBE()
//                            {
//                                CodigoGrupoPuertoDetalle = dr.IsDBNull(dr.GetOrdinal("CodigoGrupoPuertoDetalle")) ? 0 : dr.GetInt32(dr.GetOrdinal("CodigoGrupoPuertoDetalle")),
//                                CodigoGrupoPuerto = dr.IsDBNull(dr.GetOrdinal("CodigoGrupoPuerto")) ? 0 : dr.GetInt32(dr.GetOrdinal("CodigoGrupoPuerto")),
//                                CodigoPuerto = dr.IsDBNull(dr.GetOrdinal("CodigoPuerto")) ? "" : dr.GetString(dr.GetOrdinal("CodigoPuerto")).Trim(),
//                                UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioRegistro")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioRegistro")),
//                                FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraRegistro")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraRegistro")),
//                                EstadoRegistro = dr.GetBoolean(dr.GetOrdinal("EstadoRegistro"))
//                            };

//                            lstDetalleGrupoPuertoExterno.Add(detgrupopuertoexterno);
//                        }

//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return lstDetalleGrupoPuertoExterno;
//        }


//        public int InsertarGrupoPuertoExterno(ActualizaGrupoPuertoExternoBE request)
//        {

//            int CodigoGrupoPuerto;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            using (SqlCommand cmd = SqlHelper.CreateCommand("USP_INSERTA_GRUPOPUERTOEXTERNO", conexion, true))
//            {

//                SqlParameterCollection parametrosIn = cmd.Parameters;

//                parametrosIn.Add("@NombreGrupoPuerto", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.NombreGrupoPuerto) ? string.Empty : request.NombreGrupoPuerto;
//                parametrosIn.Add("@UsuarioRegistro", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.UsuarioCreacion) ? string.Empty : request.UsuarioCreacion;
//                parametrosIn.Add("@CodigoLinea", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoLinea) ? string.Empty : request.CodigoLinea;
//                parametrosIn.Add("@CodigoGrupoPuerto", DbType.Int32).Direction = ParameterDirection.InputOutput;

//                cmd.ExecuteNonQuery();

//                CodigoGrupoPuerto = int.Parse(cmd.Parameters["@CodigoGrupoPuerto"].Value.ToString());

//                SqlHelper.CloseConnection(conexion);

//            }

//            return CodigoGrupoPuerto;
//        }

//        public bool ActualizarGrupoPuertoExterno(ActualizaGrupoPuertoExternoBE request)
//        {

//            int queryExec;
//            bool result = false;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            using (SqlCommand cmd = SqlHelper.CreateCommand("USP_ACTUALIZA_GRUPOPUERTOEXTERNO", conexion, true))
//            {

//                SqlParameterCollection parametrosIn = cmd.Parameters;

//                parametrosIn.Add("@CodigoGrupoPuerto", SqlDbType.Int).Value = request.CodigoGrupoPuerto;
//                parametrosIn.Add("@NombreGrupoPuerto", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.NombreGrupoPuerto) ? string.Empty : request.NombreGrupoPuerto;
//                parametrosIn.Add("@UsuarioActualizacion", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.UsuarioActualizacion) ? string.Empty : request.UsuarioActualizacion;
//                parametrosIn.Add("@CodigoLinea", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoLinea) ? string.Empty : request.CodigoLinea;

//                queryExec = cmd.ExecuteNonQuery();

//                if (queryExec != -1)
//                {
//                    result = true;
//                }

//                SqlHelper.CloseConnection(conexion);

//            }

//            return result;
//        }

//        public int ModificarDetalleGrupoPuertoExterno(List<DetalleGrupoPuertoExternoBE> request)
//        {
//            int affected = 0;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//            var dtDetalleGrPexterno = request.ToDataTable();
//            parametrosIn.Add("@dtDetalleGrupoPuertoExterno", dtDetalleGrPexterno);

//            using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_MODIFICAR_DETALLEGRUPOPUERTOEXTERNO", conexion, parametrosIn, true))
//            {
//                affected = cmd.ExecuteNonQuery();

//                SqlHelper.CloseConnection(conexion);
//            }

//            return affected;
//        }

//        public int EliminarGrupoPuertoExterno(EliminaGrupoPuertoExternoBE request)
//        {
//            int affected = 0;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            Dictionary<string, object> parametros = new Dictionary<string, object>();
//            parametros.Add("@CodigoGrupoPuerto", request.CodigoGrupoPuerto);

//            using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_ELIMINA_GRUPOPUERTOEXTERNO", conexion, parametros, true))
//            {
//                affected = cmd.ExecuteNonQuery();

//                SqlHelper.CloseConnection(conexion);
//            }

//            return affected;
//        }

//        public bool InsertarPesoVariable(ActualizaPesoVariableBE request)
//        {

//            int result;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            using (SqlCommand cmd = SqlHelper.CreateCommand("USP_INSERTAR_PESOVARIABLE", conexion, true))
//            {

//                SqlParameterCollection parametrosIn = cmd.Parameters;

//                parametrosIn.Add("@Descripcion", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.Descripcion) ? string.Empty : request.Descripcion;
//                parametrosIn.Add("@PesoVariable", SqlDbType.Int).Value = request.PesoVariable;
//                parametrosIn.Add("@UsuarioRegistro", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.UsuarioCreacion) ? string.Empty : request.UsuarioCreacion;
//                parametrosIn.Add("@FechaHoraRegistro", SqlDbType.DateTime).Value = request.FechaHoraCreacion == null ? DateTime.Now : request.FechaHoraCreacion;
//                parametrosIn.Add("@EstadoRegistro", SqlDbType.Bit).Value = request.EstadoRegistro;

//                result = cmd.ExecuteNonQuery();

//                SqlHelper.CloseConnection(conexion);

//            }

//            return result > 0;
//        }

//        public bool ActualizarPesoVariable(ActualizaPesoVariableBE request)
//        {

//            int result;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            using (SqlCommand cmd = SqlHelper.CreateCommand("USP_ACTUALIZAR_PESOVARIABLE", conexion, true))
//            {

//                SqlParameterCollection parametrosIn = cmd.Parameters;

//                parametrosIn.Add("@CodigoVariable", SqlDbType.Int).Value = request.CodigoVariable;
//                parametrosIn.Add("@Descripcion", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.Descripcion) ? string.Empty : request.Descripcion;
//                parametrosIn.Add("@PesoVariable", SqlDbType.Int).Value = request.PesoVariable;
//                parametrosIn.Add("@UsuarioActualizacion", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.UsuarioActualizacion) ? string.Empty : request.UsuarioActualizacion;
//                parametrosIn.Add("@FechaHoraActualizacion", SqlDbType.DateTime).Value = request.FechaHoraActualizacion == null ? DateTime.Now : request.FechaHoraActualizacion;
//                parametrosIn.Add("@EstadoRegistro", SqlDbType.Bit).Value = request.EstadoRegistro;
//                parametrosIn.Add("@CodigoLinea", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoLinea) ? string.Empty : request.CodigoLinea;
//                result = cmd.ExecuteNonQuery();

//                SqlHelper.CloseConnection(conexion);

//            }

//            return result > 0;
//        }

//        public bool EliminarPesoVariable(EliminaPesoVariableBE request)
//        {

//            int result;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            using (SqlCommand cmd = SqlHelper.CreateCommand("USP_ELIMINA_PESOVARIABLE", conexion, true))
//            {

//                SqlParameterCollection parametrosIn = cmd.Parameters;

//                parametrosIn.Add("@CodigoVariable", SqlDbType.Int).Value = request.CodigoVariable;

//                result = cmd.ExecuteNonQuery();

//                SqlHelper.CloseConnection(conexion);

//            }

//            return result > 0;
//        }



//        public List<ParametroNegocio> ObtenerParametrosNegocio()
//        {
//            List<ParametroNegocio> lstParametroNegocio = new List<ParametroNegocio>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("Reclamos")))
//            {
//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTAR_PARAMETRONEGOCIO", conexion, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            ParametroNegocio parametroNegocio = new ParametroNegocio()
//                            {
//                                IdParametroNegocio = dr.IsDBNull(dr.GetOrdinal("IdParametroNegocio")) ? 0 : dr.GetInt32(dr.GetOrdinal("IdParametroNegocio")),
//                                Codigo = dr.IsDBNull(dr.GetOrdinal("Codigo")) ? "" : dr.GetString(dr.GetOrdinal("Codigo")).Trim(),
//                                Valor = dr.IsDBNull(dr.GetOrdinal("Valor")) ? "" : dr.GetString(dr.GetOrdinal("Valor")).Trim(),
//                                ValorRelacionado = dr.IsDBNull(dr.GetOrdinal("ValorRelacionado")) ? "" : dr.GetString(dr.GetOrdinal("ValorRelacionado")).Trim(),
//                                Descripcion = dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : dr.GetString(dr.GetOrdinal("Descripcion")).Trim(),
//                                UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion")).Trim(),
//                                FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new DateTime() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion")),
//                                UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim(),
//                                FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new DateTime() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion")),
//                                EstadoRegistro = dr.IsDBNull(dr.GetOrdinal("EstadoRegistro")) ? false : dr.GetBoolean(dr.GetOrdinal("EstadoRegistro"))
//                            };

//                            lstParametroNegocio.Add(parametroNegocio);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return lstParametroNegocio;

//        }

//        public bool ActualizarParametroNegocio(ActualizarParametroNegocio request)
//        {

//            int result;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            using (SqlCommand cmd = SqlHelper.CreateCommand("USP_ACTUALIZAR_PARAMETRONEGOCIO", conexion, true))
//            {

//                SqlParameterCollection parametrosIn = cmd.Parameters;

//                parametrosIn.Add("@IdParametroNegocio", SqlDbType.Int).Value = request.IdParametroNegocio;
//                parametrosIn.Add("@Codigo", SqlDbType.VarChar).Value = request.Codigo;
//                parametrosIn.Add("@Valor", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.Valor) ? string.Empty : request.Valor;
//                parametrosIn.Add("@ValorRelacionado", SqlDbType.VarChar).Value = request.ValorRelacionado;
//                parametrosIn.Add("@Descripcion", SqlDbType.VarChar).Value = request.Descripcion;
//                parametrosIn.Add("@UsuarioActualizacion", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.UsuarioActualizacion) ? string.Empty : request.UsuarioActualizacion;
//                parametrosIn.Add("@FechaHoraActualizacion", SqlDbType.DateTime).Value = request.FechaHoraActualizacion == null ? DateTime.Now : request.FechaHoraActualizacion;
//                parametrosIn.Add("@EstadoRegistro", SqlDbType.Bit).Value = request.EstadoRegistro;

//                result = cmd.ExecuteNonQuery();

//                SqlHelper.CloseConnection(conexion);

//            }

//            return result > 0;
//        }

//        public bool EliminarParametroNegocio(EliminarParametroNegocio request)
//        {

//            int result;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            using (SqlCommand cmd = SqlHelper.CreateCommand("USP_ELIMINA_PARAMETRONEGOCIO", conexion, true))
//            {

//                SqlParameterCollection parametrosIn = cmd.Parameters;

//                parametrosIn.Add("@IdParametroNegocio", SqlDbType.Int).Value = request.IdParametroNegocio;
//                parametrosIn.Add("@UsuarioActualizacion", SqlDbType.Int).Value = string.IsNullOrEmpty(request.UsuarioActualizacion) ? string.Empty : request.UsuarioActualizacion;

//                result = cmd.ExecuteNonQuery();

//                SqlHelper.CloseConnection(conexion);

//            }

//            return result > 0;
//        }

//        public List<ServicioBE> ConsultarServicio(ConsultaServiciosBE request, out int totalRegistros, out int cantidadPaginas)
//        {
//            List<ServicioBE> lstServicio = new List<ServicioBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {

//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
//                int totRegs = 0;
//                int cantRegs = 0;

//                parametrosIn.Add("@OrdenCampo", string.IsNullOrEmpty(request.OrdenCampo) ? string.Empty : request.OrdenCampo);
//                parametrosIn.Add("@OrdenOrientacion", string.IsNullOrEmpty(request.OrdenOrientacion) ? string.Empty : request.OrdenOrientacion);
//                parametrosIn.Add("@PaginaActual", request.PaginaActual == null ? new Nullable<int>() : request.PaginaActual);
//                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina == null ? new Nullable<int>() : request.NroRegistrosPorPagina);
//                parametrosIn.Add("@CodigoServicio", string.IsNullOrEmpty(request.CodigoServicio) ? string.Empty : request.CodigoServicio);
//                parametrosIn.Add("@NombreServicio", string.IsNullOrEmpty(request.NombreServicio) ? string.Empty : request.NombreServicio);

//                parametrosOut.Add("@TotalRegistros", totRegs);
//                parametrosOut.Add("@CantidadPaginas", cantRegs);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTA_SERVICIOS", conexion, parametrosIn, true, parametrosOut))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            ServicioBE servicio = new ServicioBE()
//                            {
//                                CodigoServicio = dr.IsDBNull(dr.GetOrdinal("CodigoServicio")) ? "" : dr.GetString(dr.GetOrdinal("CodigoServicio")).Trim(),
//                                NombreServicio = dr.IsDBNull(dr.GetOrdinal("NombreServicio")) ? "" : dr.GetString(dr.GetOrdinal("NombreServicio")).Trim()
//                            };

//                            lstServicio.Add(servicio);
//                        }

//                        SqlHelper.CloseConnection(conexion);
//                    }

//                    totalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
//                    cantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
//                }
//            }

//            return lstServicio;

//        }

//        public List<TipoContenedorExternoBE> ConsultarTipoContenedorExterno(ConsultaTipoContenedorExternoBE request, out int totalRegistros, out int cantidadPaginas)
//        {
//            List<TipoContenedorExternoBE> lstTipoContenedorExterno = new List<TipoContenedorExternoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {

//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();
//                int totRegs = 0;
//                int cantRegs = 0;

//                parametrosIn.Add("@OrdenCampo", string.IsNullOrEmpty(request.OrdenCampo) ? string.Empty : request.OrdenCampo);
//                parametrosIn.Add("@OrdenOrientacion", string.IsNullOrEmpty(request.OrdenOrientacion) ? string.Empty : request.OrdenOrientacion);
//                parametrosIn.Add("@PaginaActual", request.PaginaActual == null ? new Nullable<int>() : request.PaginaActual);
//                parametrosIn.Add("@NroRegistrosPorPagina", request.NroRegistrosPorPagina == null ? new Nullable<int>() : request.NroRegistrosPorPagina);

//                parametrosIn.Add("@CodigoTipoContenedorExterno", request.CodigoTipoContenedorExterno);
//                parametrosIn.Add("@CodigoEquivalencia", string.IsNullOrEmpty(request.CodigoEquivalencia) ? string.Empty : request.CodigoEquivalencia);
//                parametrosIn.Add("@CodigoLinea", string.IsNullOrEmpty(request.CodigoLinea) ? string.Empty : request.CodigoLinea);

//                parametrosOut.Add("@TotalRegistros", totRegs);
//                parametrosOut.Add("@CantidadPaginas", cantRegs);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_TIPOCONTENEDOREXTERNO", conexion, parametrosIn, true, parametrosOut))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            TipoContenedorExternoBE tipoContenedorExterno = new TipoContenedorExternoBE()
//                            {
//                                CodigoTipoContenedorExterno = dr.IsDBNull(dr.GetOrdinal("CodigoTipoContenedorExterno")) ? 0 : dr.GetInt32(dr.GetOrdinal("CodigoTipoContenedorExterno")),
//                                CodigoEquivalencia = dr.IsDBNull(dr.GetOrdinal("CodigoEquivalencia")) ? "" : dr.GetString(dr.GetOrdinal("CodigoEquivalencia")).Trim(),
//                                UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioRegistro")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioRegistro")).Trim(),
//                                FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraRegistro")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraRegistro")),
//                                UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim(),
//                                FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion")),
//                                EstadoRegistro = dr.IsDBNull(dr.GetOrdinal("EstadoRegistro")) ? false : dr.GetBoolean(dr.GetOrdinal("EstadoRegistro")),
//                                CodigoLinea = dr.IsDBNull(dr.GetOrdinal("CodigoLinea")) ? "" : dr.GetString(dr.GetOrdinal("CodigoLinea")).Trim()
//                            };

//                            lstTipoContenedorExterno.Add(tipoContenedorExterno);
//                        }

//                        SqlHelper.CloseConnection(conexion);
//                    }

//                    totalRegistros = Int32.Parse(cmd.Parameters["@TotalRegistros"].Value.ToString());
//                    cantidadPaginas = Int32.Parse(cmd.Parameters["@CantidadPaginas"].Value.ToString());
//                }
//            }

//            return lstTipoContenedorExterno;

//        }


//        public bool InsertarTipoContenedorExterno(ActualizarTipoContenedorExternoBE request)
//        {

//            int result;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            using (SqlCommand cmd = SqlHelper.CreateCommand("USP_INSERTAR_TIPOCONTENEDOREXTERNO", conexion, true))
//            {

//                SqlParameterCollection parametrosIn = cmd.Parameters;

//                //parametrosIn.Add("@CodigoTipoContenedorExterno", SqlDbType.Int).Value = request.CodigoTipoContenedorExterno;
//                //parametrosIn.Add("@CodigoClaseContenedor", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoClaseContenedor) ? string.Empty : request.CodigoClaseContenedor;
//                //parametrosIn.Add("@CodigoTipoContenedor", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoTipoContenedor) ? string.Empty : request.CodigoTipoContenedor;
//                parametrosIn.Add("@CodigoEquivalencia", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoEquivalencia) ? string.Empty : request.CodigoEquivalencia;
//                parametrosIn.Add("@UsuarioRegistro", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.UsuarioCreacion) ? string.Empty : request.UsuarioCreacion;
//                parametrosIn.Add("@FechaHoraRegistro", SqlDbType.DateTime).Value = request.FechaHoraCreacion == null ? DateTime.Now : request.FechaHoraCreacion;
//                parametrosIn.Add("@CodigoLinea", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoLinea) ? string.Empty : request.CodigoLinea;
//                parametrosIn.Add("@EstadoRegistro", SqlDbType.Bit).Value = request.EstadoRegistro;

//                result = cmd.ExecuteNonQuery();

//                SqlHelper.CloseConnection(conexion);

//            }

//            return result > 0;
//        }

//        public bool ActualizarTipoContenedorExterno(ActualizarTipoContenedorExternoBE request)
//        {

//            int result;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            using (SqlCommand cmd = SqlHelper.CreateCommand("USP_ACTUALIZAR_TIPOCONTENEDOREXTERNO", conexion, true))
//            {

//                SqlParameterCollection parametrosIn = cmd.Parameters;

//                parametrosIn.Add("@CodigoTipoContenedorExterno", SqlDbType.Int).Value = request.CodigoTipoContenedorExterno;
//                parametrosIn.Add("@CodigoEquivalencia", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoEquivalencia) ? string.Empty : request.CodigoEquivalencia;
//                parametrosIn.Add("@UsuarioActualizacion", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.UsuarioActualizacion) ? string.Empty : request.UsuarioActualizacion;
//                parametrosIn.Add("@FechaHoraActualizacion", SqlDbType.DateTime).Value = request.FechaHoraActualizacion == null ? DateTime.Now : request.FechaHoraActualizacion;
//                parametrosIn.Add("@CodigoLinea", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoLinea) ? string.Empty : request.CodigoLinea;
//                parametrosIn.Add("@EstadoRegistro", SqlDbType.Bit).Value = request.EstadoRegistro;

//                result = cmd.ExecuteNonQuery();

//                SqlHelper.CloseConnection(conexion);

//            }

//            return result > 0;
//        }

//        public bool EliminarTipoContenedorExterno(EliminarTipoContenedorExternoBE request)
//        {

//            int result;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            using (SqlCommand cmd = SqlHelper.CreateCommand("USP_ELIMINA_TIPOCONTENEDOREXTERNO", conexion, true))
//            {

//                SqlParameterCollection parametrosIn = cmd.Parameters;

//                parametrosIn.Add("@CodigoTipoContenedorExterno", SqlDbType.Int).Value = request.CodigoTipoContenedorExterno;
//                //parametrosIn.Add("@CodigoLinea", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoLinea) ? string.Empty : request.CodigoLinea;
//                //parametrosIn.Add("@CodigoClaseContenedor", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoClaseContenedor) ? string.Empty : request.CodigoClaseContenedor;
//                //parametrosIn.Add("@CodigoTipoContenedor", SqlDbType.Int).Value = string.IsNullOrEmpty(request.CodigoTipoContenedor) ? string.Empty : request.CodigoTipoContenedor;
//                //parametrosIn.Add("@UsuarioActualizacion", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.UsuarioActualizacion) ? string.Empty : request.UsuarioActualizacion;

//                result = cmd.ExecuteNonQuery();

//                SqlHelper.CloseConnection(conexion);

//            }

//            return result > 0;
//        }

//        public List<TipoContenedorBE> ConsultarTipoContenedor()
//        {
//            List<TipoContenedorBE> lstTipoContenedor = new List<TipoContenedorBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {
//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTAR_TIPOCONTENEDOR", conexion, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            TipoContenedorBE tipoContenedor = new TipoContenedorBE()
//                            {
//                                CodigoTipoContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoTipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodigoTipoContenedor")).Trim(),
//                                CodigoClaseContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoClaseContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodigoClaseContenedor")).Trim(),
//                                Descripcion = dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : dr.GetString(dr.GetOrdinal("Descripcion")).Trim(),
//                                UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioRegistro")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioRegistro")).Trim(),
//                                FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraRegistro")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraRegistro")),
//                                UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim(),
//                                FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion")),
//                                EstadoRegistro = dr.IsDBNull(dr.GetOrdinal("EstadoRegistro")) ? false : dr.GetBoolean(dr.GetOrdinal("EstadoRegistro")),
//                                CodigoLinea = dr.IsDBNull(dr.GetOrdinal("CodigoLinea")) ? "" : dr.GetString(dr.GetOrdinal("CodigoLinea")).Trim()
//                            };

//                            lstTipoContenedor.Add(tipoContenedor);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return lstTipoContenedor;

//        }

//        public bool ValidarTipoContenedor(string CodigoClaseContenedor, string CodigoTipoContenedor, string CodigoLinea)
//        {
//            bool leerDatos = true;

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {
//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_VALIDAR_TIPOCONTENEDOR", conexion, true))
//                {

//                    SqlParameterCollection parametrosIn = cmd.Parameters;

//                    parametrosIn.Add("@CodigoClaseContenedor", SqlDbType.VarChar).Value = string.IsNullOrEmpty(CodigoClaseContenedor) ? string.Empty : CodigoClaseContenedor;
//                    parametrosIn.Add("@CodigoTipoContenedor", SqlDbType.VarChar).Value = string.IsNullOrEmpty(CodigoTipoContenedor) ? string.Empty : CodigoTipoContenedor;
//                    parametrosIn.Add("@CodigoLinea", SqlDbType.VarChar).Value = string.IsNullOrEmpty(CodigoLinea) ? string.Empty : CodigoLinea;

//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        leerDatos = dr.Read();

//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return leerDatos;
//        }

//        public bool InsertarTipoContenedor(ActualizarTipoContenedorBE request)
//        {

//            int result;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            using (SqlCommand cmd = SqlHelper.CreateCommand("USP_INSERTAR_TIPOCONTENEDOR", conexion, true))
//            {

//                SqlParameterCollection parametrosIn = cmd.Parameters;

//                parametrosIn.Add("@CodigoTipoContenedor", SqlDbType.VarChar).Value = request.CodigoTipoContenedor;
//                parametrosIn.Add("@CodigoClaseContenedor", SqlDbType.VarChar).Value = request.CodigoClaseContenedor;
//                parametrosIn.Add("@Descripcion", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.Descripcion) ? string.Empty : request.Descripcion;
//                parametrosIn.Add("@UsuarioRegistro", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.UsuarioCreacion) ? string.Empty : request.UsuarioCreacion;
//                parametrosIn.Add("@FechaHoraRegistro", SqlDbType.DateTime).Value = request.FechaHoraCreacion == null ? DateTime.Now : request.FechaHoraCreacion;
//                parametrosIn.Add("@CodigoLinea", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoLinea) ? string.Empty : request.CodigoLinea;
//                parametrosIn.Add("@EstadoRegistro", SqlDbType.Bit).Value = request.EstadoRegistro;

//                result = cmd.ExecuteNonQuery();

//                SqlHelper.CloseConnection(conexion);

//            }

//            return result > 0;
//        }

//        public bool ActualizarTipoContenedor(ActualizarTipoContenedorBE request)
//        {

//            int result;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            using (SqlCommand cmd = SqlHelper.CreateCommand("USP_ACTUALIZAR_TIPOCONTENEDOR", conexion, true))
//            {

//                SqlParameterCollection parametrosIn = cmd.Parameters;

//                parametrosIn.Add("@CodigoTipoContenedor", SqlDbType.VarChar).Value = request.CodigoTipoContenedor;
//                parametrosIn.Add("@CodigoClaseContenedor", SqlDbType.VarChar).Value = request.CodigoClaseContenedor;
//                parametrosIn.Add("@Descripcion", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.Descripcion) ? string.Empty : request.Descripcion;
//                parametrosIn.Add("@UsuarioActualizacion", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.UsuarioActualizacion) ? string.Empty : request.UsuarioActualizacion;
//                parametrosIn.Add("@FechaHoraActualizacion", SqlDbType.DateTime).Value = request.FechaHoraActualizacion == null ? DateTime.Now : request.FechaHoraActualizacion;
//                parametrosIn.Add("@CodigoLinea", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoLinea) ? string.Empty : request.CodigoLinea;
//                parametrosIn.Add("@EstadoRegistro", SqlDbType.Bit).Value = request.EstadoRegistro;

//                result = cmd.ExecuteNonQuery();

//                SqlHelper.CloseConnection(conexion);

//            }

//            return result > 0;
//        }

//        public bool EliminarTipoContenedor(EliminarTipoContenedorBE request)
//        {

//            int result;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            using (SqlCommand cmd = SqlHelper.CreateCommand("USP_ELIMINA_TIPOCONTENEDOR", conexion, true))
//            {

//                SqlParameterCollection parametrosIn = cmd.Parameters;

//                parametrosIn.Add("@CodigoTipoContenedor", SqlDbType.VarChar).Value = request.CodigoTipoContenedor;
//                parametrosIn.Add("@CodigoClaseContenedor", SqlDbType.VarChar).Value = request.CodigoClaseContenedor;
//                parametrosIn.Add("@CodigoLinea", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoLinea) ? string.Empty : request.CodigoLinea;

//                try
//                {
//                    result = cmd.ExecuteNonQuery();
//                }
//                catch (SqlException ex)
//                {
//                    if (ex.ErrorCode == -2146232060)
//                        throw new ResultException { Result = new Result { Mensaje = "No se puede eliminar porque tiene referencias existentes.", CodigoError = ex.ErrorCode.ToString() } };
//                    else
//                        throw;
//                }
//                catch (Exception ex)
//                {
//                    throw;
//                }
//                finally
//                {
//                    SqlHelper.CloseConnection(conexion);
//                }

//            }

//            return result > 0;
//        }

//        public List<ClaseContenedorBE> ConsultarClaseContenedor()
//        {
//            List<ClaseContenedorBE> lstClaseContenedor = new List<ClaseContenedorBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {
//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTAR_CLASECONTENEDOR", conexion, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            ClaseContenedorBE claseContenedor = new ClaseContenedorBE()
//                            {
//                                CodigoClaseContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoClaseContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodigoClaseContenedor")).Trim(),
//                                Descripcion = dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : dr.GetString(dr.GetOrdinal("Descripcion")).Trim(),
//                                UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioRegistro")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioRegistro")).Trim(),
//                                FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraRegistro")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraRegistro")),
//                                UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")).Trim(),
//                                FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion")),
//                                EstadoRegistro = dr.IsDBNull(dr.GetOrdinal("EstadoRegistro")) ? false : dr.GetBoolean(dr.GetOrdinal("EstadoRegistro"))
//                            };

//                            lstClaseContenedor.Add(claseContenedor);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return lstClaseContenedor;

//        }


//        public List<GrupoPuertoExternoBE> ConsultarGrupoPuertoTodos()
//        {
//            List<GrupoPuertoExternoBE> grupoPuerto = new List<GrupoPuertoExternoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {
//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTA_GRUPOPUERTOEXTERNO_ALL", conexion, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            GrupoPuertoExternoBE grupoPuertoDetalle = new GrupoPuertoExternoBE()
//                            {
//                                CodigoGrupoPuerto = dr.IsDBNull(dr.GetOrdinal("CodigoGrupoPuerto")) ? 0 : dr.GetInt32(dr.GetOrdinal("CodigoGrupoPuerto")),
//                                NombreGrupoPuerto = dr.IsDBNull(dr.GetOrdinal("NombreGrupoPuerto")) ? "" : dr.GetString(dr.GetOrdinal("NombreGrupoPuerto")),
//                            };

//                            grupoPuerto.Add(grupoPuertoDetalle);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return grupoPuerto;

//        }

//        public List<PuertoBE> ConsultarPuertoTodos()
//        {
//            List<PuertoBE> puertoList = new List<PuertoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {
//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTA_PUERTO_TODOS", conexion, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            PuertoBE puerto = new PuertoBE()
//                            {
//                                Codigo = dr.IsDBNull(dr.GetOrdinal("Codigo")) ? "" : dr.GetString(dr.GetOrdinal("Codigo")).Trim(),
//                                Nombre = dr.IsDBNull(dr.GetOrdinal("Nombre")) ? "" : dr.GetString(dr.GetOrdinal("Nombre")).Trim(),
//                                CodigoPais = dr.IsDBNull(dr.GetOrdinal("CodigoPais")) ? "" : dr.GetString(dr.GetOrdinal("CodigoPais")).Trim(),
//                                CodigoInternacional = dr.IsDBNull(dr.GetOrdinal("CodigoInternacional")) ? "" : dr.GetInt16(dr.GetOrdinal("CodigoInternacional")).ToString().Trim(),
//                            };

//                            puertoList.Add(puerto);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return puertoList;
//        }

//        //public List<ClienteBE> ObtenerDatosCliente(List<GenericBE> request)
//        //{
//        //    List<ClienteBE> lstCliente = new List<ClienteBE>();

//        //    using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//        //    {

//        //        Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//        //        parametrosIn.Add("@listaGenerica", request.ToDataTable());


//        //        using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_OBTENER_DATOS_CLIENTE", conexion, parametrosIn, true))
//        //        {
//        //            using (IDataReader dr = cmd.ExecuteReader())
//        //            {
//        //                while (dr.Read())
//        //                {
//        //                    ClienteBE cliente = new ClienteBE()
//        //                    {
//        //                        CodigoCliente = dr.IsDBNull(dr.GetOrdinal("CodigoCliente")) ? "" : dr.GetString(dr.GetOrdinal("CodigoCliente")).Trim(),
//        //                        Nombre = dr.IsDBNull(dr.GetOrdinal("Nombre")) ? "" : dr.GetString(dr.GetOrdinal("Nombre")).Trim(),
//        //                        CodigoClienteSAP = dr.IsDBNull(dr.GetOrdinal("CodigoClienteSAP")) ? "" : dr.GetString(dr.GetOrdinal("CodigoClienteSAP")).Trim()
//        //                    };

//        //                    lstCliente.Add(cliente);
//        //                }
//        //                SqlHelper.CloseConnection(conexion);
//        //            }

//        //        }
//        //    }

//        //    return lstCliente;
//        //}

//        public List<PuertoBE> ObtenerDatosPuerto(List<GenericBE> request)
//        {
//            List<PuertoBE> lstPuerto = new List<PuertoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {

//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//                parametrosIn.Add("@listaGenerica", request.ToDataTable());


//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_OBTENER_DATOS_PUERTO", conexion, parametrosIn, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            PuertoBE Puerto = new PuertoBE()
//                            {
//                                Codigo = dr.IsDBNull(dr.GetOrdinal("CodigoPuerto")) ? "" : dr.GetString(dr.GetOrdinal("CodigoPuerto")).Trim(),
//                                Nombre = dr.IsDBNull(dr.GetOrdinal("Nombre")) ? "" : dr.GetString(dr.GetOrdinal("Nombre")).Trim(),
//                                CodigoInternacional = dr.IsDBNull(dr.GetOrdinal("CodigoInternacional")) ? "" : dr.GetInt16(dr.GetOrdinal("CodigoInternacional")).ToString().Trim(),
//                            };

//                            lstPuerto.Add(Puerto);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }

//                }
//            }

//            return lstPuerto;
//        }

//        public List<ServicioBE> ObtenerDatosServicio(List<GenericBE> request)
//        {
//            List<ServicioBE> lstServicio = new List<ServicioBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {

//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//                parametrosIn.Add("@listaGenerica", request.ToDataTable());


//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_OBTENER_DATOS_SERVICIO", conexion, parametrosIn, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            ServicioBE Servicio = new ServicioBE()
//                            {
//                                CodigoServicio = dr.IsDBNull(dr.GetOrdinal("CodigoServicio")) ? "" : dr.GetString(dr.GetOrdinal("CodigoServicio")).Trim(),
//                                NombreServicio = dr.IsDBNull(dr.GetOrdinal("Nombre")) ? "" : dr.GetString(dr.GetOrdinal("Nombre")).Trim()

//                            };

//                            lstServicio.Add(Servicio);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }

//                }
//            }

//            return lstServicio;
//        }


//        public List<TipoContenedorExternoBE> ConsultarContenedorExternoTodo()
//        {
//            List<TipoContenedorExternoBE> TipoContenedorExternoList = new List<TipoContenedorExternoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {
//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTAR_TIPOCONTENEDOREXTERNO_TODO", conexion, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            TipoContenedorExternoBE tipoContenedorExterno = new TipoContenedorExternoBE()
//                            {
//                                CodigoTipoContenedorExterno = dr.IsDBNull(dr.GetOrdinal("CodigoTipoContenedorExterno")) ? 0 : dr.GetInt32(dr.GetOrdinal("CodigoTipoContenedorExterno")),
//                                CodigoEquivalencia = dr.IsDBNull(dr.GetOrdinal("CodigoEquivalencia")) ? "" : dr.GetString(dr.GetOrdinal("CodigoEquivalencia")),
//                                CodigoClaseContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoClaseContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodigoClaseContenedor")),
//                                CodigoTipoContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoTipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodigoTipoContenedor")),
//                            };

//                            TipoContenedorExternoList.Add(tipoContenedorExterno);
//                        }

//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return TipoContenedorExternoList;

//        }

//        public List<ContenedoresNoDevueltosBE> ConsultarContenedoresNoDevueltos(ConsultaContenedorNoDevueltoBE request)
//        {
//            List<ContenedoresNoDevueltosBE> liquidacionList = new List<ContenedoresNoDevueltosBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            //using (SqlConnection conexion = new SqlConnection("Data Source=10.72.20.27;Initial Catalog=TRAMARSA;User ID=usrAntp;Password=6;MultipleActiveResultSets=True"))
//            {

//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//                Dictionary<string, object> parametrosOut = new Dictionary<string, object>();

//                parametrosIn.Add("@CodCli", (object)request.CodigoCliente ?? DBNull.Value);
//                parametrosIn.Add("@CodLin", (object)request.CodigoLinea ?? DBNull.Value);
//                parametrosIn.Add("@Nro_Bl", (object)request.NroBL ?? DBNull.Value);
//                parametrosIn.Add("@CodCtn", (object)request.CodigoContenedor ?? DBNull.Value);
//                parametrosIn.Add("@FecDesde", (object)request.Desde ?? DBNull.Value);
//                parametrosIn.Add("@FecHasta", (object)request.Hasta ?? DBNull.Value);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_Consulta_AlertasLiquidacionesNoDevueltos", conexion, parametrosIn, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            ContenedoresNoDevueltosBE cliente = new ContenedoresNoDevueltosBE()
//                            {
//                                CodigoAgente = dr.IsDBNull(dr.GetOrdinal("CodigoAgente")) ? "" : dr.GetString(dr.GetOrdinal("CodigoAgente")).Trim(),
//                                NombreSucursal = dr.IsDBNull(dr.GetOrdinal("NombreSucursal")) ? "" : dr.GetString(dr.GetOrdinal("NombreSucursal")).Trim(),
//                                NumeroTransaccion = dr.IsDBNull(dr.GetOrdinal("NumeroTransaccion")) ? 0 : dr.GetInt32(dr.GetOrdinal("NumeroTransaccion")),
//                                FechaTransaccion = dr.IsDBNull(dr.GetOrdinal("FechaTransaccion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaTransaccion")),
//                                CodigoNave = dr.IsDBNull(dr.GetOrdinal("CodigoNave")) ? "" : dr.GetString(dr.GetOrdinal("CodigoNave")).Trim(),
//                                NombreNave = dr.IsDBNull(dr.GetOrdinal("NombreNave")) ? "" : dr.GetString(dr.GetOrdinal("NombreNave")).Trim(),
//                                NumeroViaje = dr.IsDBNull(dr.GetOrdinal("NumeroViaje")) ? "" : dr.GetString(dr.GetOrdinal("NumeroViaje")).Trim(),
//                                PuertoOrigen = dr.IsDBNull(dr.GetOrdinal("PuertoOrigen")) ? "" : dr.GetString(dr.GetOrdinal("PuertoOrigen")).Trim(),
//                                PuertoEmbarque = dr.IsDBNull(dr.GetOrdinal("PuertoEmbarque")) ? "" : dr.GetString(dr.GetOrdinal("PuertoEmbarque")).Trim(),
//                                PuertoDescarga = dr.IsDBNull(dr.GetOrdinal("PuertoDescarga")) ? "" : dr.GetString(dr.GetOrdinal("PuertoDescarga")).Trim(),
//                                PuertoFinal = dr.IsDBNull(dr.GetOrdinal("PuertoFinal")) ? "" : dr.GetString(dr.GetOrdinal("PuertoFinal")).Trim(),
//                                CodigoLinea = dr.IsDBNull(dr.GetOrdinal("CodigoLinea")) ? "" : dr.GetString(dr.GetOrdinal("CodigoLinea")).Trim(),
//                                NumeroBL = dr.IsDBNull(dr.GetOrdinal("NumeroBL")) ? "" : dr.GetString(dr.GetOrdinal("NumeroBL")).Trim(),
//                                CodConsignatario = dr.IsDBNull(dr.GetOrdinal("Consignatario")) ? "" : dr.GetString(dr.GetOrdinal("Consignatario")).Trim(),
//                                CodNotificante = dr.IsDBNull(dr.GetOrdinal("Notificante")) ? "" : dr.GetString(dr.GetOrdinal("Notificante")).Trim(),
//                                CodigoContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodigoContenedor")).Trim(),
//                                FechaIDP = dr.IsDBNull(dr.GetOrdinal("FecIDP")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FecIDP")),
//                                UDL = dr.IsDBNull(dr.GetOrdinal("UDL")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("UDL")),
//                                DiasSobrantes = dr.IsDBNull(dr.GetOrdinal("DiasSob")) ? 0 : dr.GetInt32(dr.GetOrdinal("DiasSob")),
//                                FechaArribo = dr.IsDBNull(dr.GetOrdinal("FechaArribo")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaArribo")),
//                                SerivicioBL = dr.IsDBNull(dr.GetOrdinal("ServicioBL")) ? "" : dr.GetString(dr.GetOrdinal("ServicioBL")).Trim(),
//                                TipoContenedor = dr.IsDBNull(dr.GetOrdinal("TipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("TipoContenedor")).Trim(),
//                            };

//                            liquidacionList.Add(cliente);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return liquidacionList;
//        }

//        public List<CatalogoTablasBE> ConsultarCatalogoTablas()
//        {
//            List<CatalogoTablasBE> lstCatalogoTablas = new List<CatalogoTablasBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("Reclamos")))
//            {
//                conexion.Open();
//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTA_CATALOGOTABLAS", conexion))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            CatalogoTablasBE CatalogoTablas = new CatalogoTablasBE()
//                            {
//                                IdCatalogo = dr.IsDBNull(dr.GetOrdinal("IdCatalogo")) ? 0 : dr.GetInt32(dr.GetOrdinal("IdCatalogo")),
//                                Codigo = dr.IsDBNull(dr.GetOrdinal("Codigo")) ? "" : dr.GetString(dr.GetOrdinal("Codigo")),
//                                Nombre = dr.IsDBNull(dr.GetOrdinal("Nombre")) ? "" : dr.GetString(dr.GetOrdinal("Nombre")),
//                                Descripcion = dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : dr.GetString(dr.GetOrdinal("Descripcion")),
//                                CodigoTabla = dr.IsDBNull(dr.GetOrdinal("CodigoTabla")) ? "" : dr.GetString(dr.GetOrdinal("CodigoTabla")),
//                                UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioRegistro")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioRegistro")),
//                                FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraRegistro")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraRegistro")),
//                                UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion")),
//                                FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion")),
//                                EstadoRegistro = dr.IsDBNull(dr.GetOrdinal("EstadoRegistro")) ? false : dr.GetBoolean(dr.GetOrdinal("EstadoRegistro"))
//                            };

//                            lstCatalogoTablas.Add(CatalogoTablas);
//                        }

//                        SqlHelper.CloseConnection(conexion);
//                    }

//                }
//                conexion.Close();
//            }

//            return lstCatalogoTablas;

//        }


//        public List<DetalleCatalogoTablasBE> ConsultarDetalleCatalogoTablas(ConsultaDetalleCatalogoTablasBE request)
//        {
//            List<DetalleCatalogoTablasBE> lstDetalleCatalogoTablas = new List<DetalleCatalogoTablasBE>();
//            List<DetalleCatalogoBE> lstDetalleCatalogo = new List<DetalleCatalogoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("Reclamos")))
//            {

//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();

//                parametrosIn.Add("@IdCatalogo", request.IdCatalogo);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTA_DETALLECATALOGOTABLAS", conexion, parametrosIn, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            DetalleCatalogoTablasBE catalogoTablas = new DetalleCatalogoTablasBE();

//                            catalogoTablas.IdCatalogo = dr.IsDBNull(dr.GetOrdinal("IdCatalogo")) ? 0 : dr.GetInt32(dr.GetOrdinal("IdCatalogo"));
//                            catalogoTablas.Codigo = dr.IsDBNull(dr.GetOrdinal("Codigo")) ? "" : dr.GetString(dr.GetOrdinal("Codigo"));
//                            catalogoTablas.Nombre = dr.IsDBNull(dr.GetOrdinal("Nombre")) ? "" : dr.GetString(dr.GetOrdinal("Nombre"));
//                            catalogoTablas.Descripcion = dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : dr.GetString(dr.GetOrdinal("Descripcion"));
//                            catalogoTablas.CodigoTabla = dr.IsDBNull(dr.GetOrdinal("CodigoTabla")) ? "" : dr.GetString(dr.GetOrdinal("CodigoTabla"));
//                            catalogoTablas.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioCreacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioCreacion"));
//                            catalogoTablas.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraCreacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraCreacion"));
//                            catalogoTablas.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion"));
//                            catalogoTablas.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));
//                            catalogoTablas.EstadoRegistro = dr.IsDBNull(dr.GetOrdinal("EstadoRegistro")) ? false : dr.GetBoolean(dr.GetOrdinal("EstadoRegistro"));
//                            lstDetalleCatalogoTablas.Add(catalogoTablas);
//                        }

//                        dr.NextResult();

//                        while (dr.Read())
//                        {
//                            DetalleCatalogoBE detalleCatalogo = new DetalleCatalogoBE()
//                            {
//                                IdCatalogo = dr.IsDBNull(dr.GetOrdinal("IdCatalogo")) ? new Nullable<int>() : dr.GetInt32(dr.GetOrdinal("IdCatalogo")),
//                                Nombre = dr.IsDBNull(dr.GetOrdinal("Nombre")) ? "" : dr.GetString(dr.GetOrdinal("Nombre")).Trim(),
//                                Codigo = dr.IsDBNull(dr.GetOrdinal("Codigo")) ? "" : dr.GetString(dr.GetOrdinal("Codigo")).Trim(),
//                                Label = dr.IsDBNull(dr.GetOrdinal("Label")) ? "" : dr.GetString(dr.GetOrdinal("Label")).Trim(),
//                                Descripcion = dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : dr.GetString(dr.GetOrdinal("Descripcion")).Trim(),
//                                Mnemonico = dr.IsDBNull(dr.GetOrdinal("Mnemonico")) ? "" : dr.GetString(dr.GetOrdinal("Mnemonico")).Trim(),
//                                Valor1 = dr.IsDBNull(dr.GetOrdinal("Val1")) ? "" : dr.GetString(dr.GetOrdinal("Val1")).Trim(),
//                                Valor2 = dr.IsDBNull(dr.GetOrdinal("Val2")) ? "" : dr.GetString(dr.GetOrdinal("Val2")).Trim()
//                            };

//                            lstDetalleCatalogo.Add(detalleCatalogo);
//                        }


//                        SqlHelper.CloseConnection(conexion);
//                    }

//                    foreach (var detalle in lstDetalleCatalogoTablas)
//                    {
//                        detalle.ListaDetalleCatalogoTablas = lstDetalleCatalogo.Where(x => x.IdCatalogo == detalle.IdCatalogo).ToList();
//                    }


//                }


//            }

//            return lstDetalleCatalogoTablas;

//        }



//        public List<PuertoGrupoExternoBE> ConsultaGrupoPuertoExterno(ConsultaPuertosGrupoExternoBE request)
//        {
//            List<PuertoGrupoExternoBE> lstPuertoGExterno = new List<PuertoGrupoExternoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {
//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();

//                parametrosIn.Add("@CodigoGrupoPuerto", request.CodigoGrupoPuerto);
//                parametrosIn.Add("@NombreGrupoPuerto", string.IsNullOrEmpty(request.NombreGrupoPuerto) ? string.Empty : request.NombreGrupoPuerto);
//                parametrosIn.Add("@CodigoLinea", string.IsNullOrEmpty(request.CodigoLinea) ? string.Empty : request.CodigoLinea);


//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_PUERTO_GRUPOPUERTOEXTERNO", conexion, parametrosIn, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        if (dr != null)
//                        {
//                            while (dr.Read())
//                            {
//                                PuertoGrupoExternoBE puertoGExterno = new PuertoGrupoExternoBE()
//                                {
//                                    Codigo = dr.IsDBNull(dr.GetOrdinal("CodigoPuerto")) ? "" : dr.GetString(dr.GetOrdinal("CodigoPuerto"))
//                                };

//                                lstPuertoGExterno.Add(puertoGExterno);
//                            }
//                        }
//                    }

//                    SqlHelper.CloseConnection(conexion);
//                }
//            }

//            return lstPuertoGExterno;
//        }

//        public List<string> ConsultaDetalleTipoContenedorExterno(string rateGroupName)
//        {
//            List<string> rates = new List<string>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {
//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();

//                parametrosIn.Add("@CodigoTipoContenedorExternoDetalle", 0);
//                parametrosIn.Add("@CodigoTipoContenedorExterno", 0);
//                parametrosIn.Add("@CodigoEquivalencia", rateGroupName);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_DETALLETIPOCONTENEDOREXTERNO", conexion, parametrosIn, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            rates.Add(dr.IsDBNull(dr.GetOrdinal("CodigoPuerto")) ? "" : dr.GetString(dr.GetOrdinal("CodigoPuerto")));
//                        }
//                    }
//                    SqlHelper.CloseConnection(conexion);
//                }
//            }

//            return rates;

//        }

//        public List<PaisBE> ConsultarPaisTodos()
//        {
//            List<PaisBE> lstPais = new List<PaisBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {

//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTAR_PAIS", conexion, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            PaisBE pais = new PaisBE();

//                            pais.CodigoPais = dr.IsDBNull(dr.GetOrdinal("CodigoPais")) ? "" : dr.GetString(dr.GetOrdinal("CodigoPais")).Trim();
//                            pais.NombrePais = dr.IsDBNull(dr.GetOrdinal("NombrePais")) ? "" : dr.GetString(dr.GetOrdinal("NombrePais")).Trim();
//                            pais.CodigoUbigeo = dr.IsDBNull(dr.GetOrdinal("CodigoUbigeo")) ? "" : dr.GetString(dr.GetOrdinal("CodigoUbigeo")).Trim();
//                            pais.NumUID = dr.IsDBNull(dr.GetOrdinal("NumUID")) ? 0 : dr.GetInt16(dr.GetOrdinal("NumUID"));
//                            pais.AduPai = dr.IsDBNull(dr.GetOrdinal("AduPai")) ? "" : dr.GetString(dr.GetOrdinal("AduPai")).Trim();
//                            pais.FechaProceso = dr.IsDBNull(dr.GetOrdinal("FechaProceso")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaProceso"));
//                            pais.CodigoSunat = dr.IsDBNull(dr.GetOrdinal("CodigoSunat")) ? "" : dr.GetString(dr.GetOrdinal("CodigoSunat")).Trim();
//                            pais.CodigoNac = dr.IsDBNull(dr.GetOrdinal("CodigoNac")) ? "" : dr.GetString(dr.GetOrdinal("CodigoNac")).Trim();



//                            lstPais.Add(pais);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return lstPais;

//        }


//        public int ValidarGrupoPuertoExterno(int codigoGrupoPuerto)
//        {
//            int result = 0;

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {
//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();

//                parametrosIn.Add("@CodigoGrupoPuerto", codigoGrupoPuerto);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_VALIDAR_GRUPOPUERTOEXTERNO", conexion, parametrosIn, true))
//                {
//                    result = Convert.ToInt32(cmd.ExecuteScalar());
//                }
//                SqlHelper.CloseConnection(conexion);
//            }

//            return result;
//        }

//        public int ValidarTipoContenedorExterno(int codigoTipoContenedorExterno)
//        {
//            int result = 0;

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {
//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();

//                parametrosIn.Add("@CodigoTipoContenedorExterno", codigoTipoContenedorExterno);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_VALIDAR_TIPOCONTENEDOREXTERNO", conexion, parametrosIn, true))
//                {
//                    result = Convert.ToInt32(cmd.ExecuteScalar());

//                    SqlHelper.CloseConnection(conexion);
//                }
//            }

//            return result;
//        }

//        public int ModificarDetalleTipoContenedorExterno(List<DetalleTipoContenedorExternoBE> request)
//        {
//            int affected = 0;

//            SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB"));

//            Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//            var detalleTipoContenedorExternoDataTable = request.ToDataTable();
//            parametrosIn.Add("@dtDetalleTipoContenedorExterno", detalleTipoContenedorExternoDataTable);

//            using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_MODIFICAR_DETALLETIPOCONTENEDOREXTERNO", conexion, parametrosIn, true))
//            {
//                affected = cmd.ExecuteNonQuery();

//                SqlHelper.CloseConnection(conexion);
//            }

//            return affected;
//        }

//        public List<DetalleTipoContenedorExternoBE> ConsultarDetalleTipoContenedorExterno(int codigoTipoContenedorExterno)
//        {
//            List<DetalleTipoContenedorExternoBE> DetalleTipoContenedorExternoList = new List<DetalleTipoContenedorExternoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {
//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//                parametrosIn.Add("@CodigoTipoContenedorExterno", codigoTipoContenedorExterno);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_DETALLETIPOCONTENEDOREXTERNO", conexion, parametrosIn, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            DetalleTipoContenedorExternoBE detalleTipoContenedorExterno = new DetalleTipoContenedorExternoBE();

//                            detalleTipoContenedorExterno.CodigoTipoContenedorExternoDetalle = dr.IsDBNull(dr.GetOrdinal("CodigoTipoContenedorExternoDetalle")) ? 0 : dr.GetInt32(dr.GetOrdinal("CodigoTipoContenedorExternoDetalle"));
//                            detalleTipoContenedorExterno.CodigoTipoContenedorExterno = dr.IsDBNull(dr.GetOrdinal("CodigoTipoContenedorExterno")) ? 0 : dr.GetInt32(dr.GetOrdinal("CodigoTipoContenedorExterno"));
//                            detalleTipoContenedorExterno.CodigoClaseContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoClaseContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodigoClaseContenedor"));
//                            detalleTipoContenedorExterno.CodigoTipoContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoTipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodigoTipoContenedor"));
//                            detalleTipoContenedorExterno.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioRegistro")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioRegistro"));
//                            detalleTipoContenedorExterno.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraRegistro")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraRegistro"));
//                            detalleTipoContenedorExterno.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion"));
//                            detalleTipoContenedorExterno.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));
//                            detalleTipoContenedorExterno.EstadoRegistro = dr.IsDBNull(dr.GetOrdinal("EstadoRegistro")) ? false : dr.GetBoolean(dr.GetOrdinal("EstadoRegistro"));

//                            DetalleTipoContenedorExternoList.Add(detalleTipoContenedorExterno);
//                        }
//                    }

//                    SqlHelper.CloseConnection(conexion);
//                }
//            }
//            return DetalleTipoContenedorExternoList;
//        }

//        public List<DetalleTipoContenedorExternoBE> ConsultarDetalleDetalleTipoContenedorExterno(int codigoTipoContenedorExternoDetalle)
//        {
//            List<DetalleTipoContenedorExternoBE> DetalleTipoContenedorExternoList = new List<DetalleTipoContenedorExternoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {
//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//                parametrosIn.Add("@CodigoTipoContenedorExterno", codigoTipoContenedorExternoDetalle);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_DETALLE_DETALLETIPOCONTENEDOREXTERNO", conexion, parametrosIn, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            DetalleTipoContenedorExternoBE detalleTipoContenedorExterno = new DetalleTipoContenedorExternoBE();

//                            detalleTipoContenedorExterno.CodigoTipoContenedorExternoDetalle = dr.IsDBNull(dr.GetOrdinal("CodigoTipoContenedorExternoDetalle")) ? 0 : dr.GetInt32(dr.GetOrdinal("CodigoTipoContenedorExternoDetalle"));
//                            detalleTipoContenedorExterno.CodigoTipoContenedorExterno = dr.IsDBNull(dr.GetOrdinal("CodigoTipoContenedorExterno")) ? 0 : dr.GetInt32(dr.GetOrdinal("CodigoTipoContenedorExterno"));
//                            detalleTipoContenedorExterno.CodigoClaseContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoClaseContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodigoClaseContenedor"));
//                            detalleTipoContenedorExterno.CodigoTipoContenedor = dr.IsDBNull(dr.GetOrdinal("CodigoTipoContenedor")) ? "" : dr.GetString(dr.GetOrdinal("CodigoTipoContenedor"));
//                            detalleTipoContenedorExterno.UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioRegistro")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioRegistro"));
//                            detalleTipoContenedorExterno.FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraRegistro")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraRegistro"));
//                            detalleTipoContenedorExterno.UsuarioActualizacion = dr.IsDBNull(dr.GetOrdinal("UsuarioActualizacion")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioActualizacion"));
//                            detalleTipoContenedorExterno.FechaHoraActualizacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraActualizacion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraActualizacion"));
//                            detalleTipoContenedorExterno.EstadoRegistro = dr.IsDBNull(dr.GetOrdinal("EstadoRegistro")) ? false : dr.GetBoolean(dr.GetOrdinal("EstadoRegistro"));

//                            DetalleTipoContenedorExternoList.Add(detalleTipoContenedorExterno);
//                        }
//                    }

//                    SqlHelper.CloseConnection(conexion);
//                }
//            }
//            return DetalleTipoContenedorExternoList;
//        }

//        public List<DetalleGrupoPuertoExternoBE> ConsultarDetalleDetalleGrupoPuertoExterno(int CodigoGrupoPuertoDetalle)
//        {
//            List<DetalleGrupoPuertoExternoBE> lstDetalleGrupoPuertoExterno = new List<DetalleGrupoPuertoExternoBE>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {

//                Dictionary<string, object> parametros = new Dictionary<string, object>();
//                parametros.Add("@CodigoGrupoPuertoDetalle", CodigoGrupoPuertoDetalle);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTA_DETALLE_DETALLEGRUPOPUERTOEXTERNO", conexion, parametros, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            DetalleGrupoPuertoExternoBE detgrupopuertoexterno = new DetalleGrupoPuertoExternoBE()
//                            {
//                                CodigoGrupoPuertoDetalle = dr.IsDBNull(dr.GetOrdinal("CodigoGrupoPuertoDetalle")) ? 0 : dr.GetInt32(dr.GetOrdinal("CodigoGrupoPuertoDetalle")),
//                                CodigoGrupoPuerto = dr.IsDBNull(dr.GetOrdinal("CodigoGrupoPuerto")) ? 0 : dr.GetInt32(dr.GetOrdinal("CodigoGrupoPuerto")),
//                                CodigoPuerto = dr.IsDBNull(dr.GetOrdinal("CodigoPuerto")) ? "" : dr.GetString(dr.GetOrdinal("CodigoPuerto")).Trim(),
//                                UsuarioCreacion = dr.IsDBNull(dr.GetOrdinal("UsuarioRegistro")) ? "" : dr.GetString(dr.GetOrdinal("UsuarioRegistro")),
//                                FechaHoraCreacion = dr.IsDBNull(dr.GetOrdinal("FechaHoraRegistro")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaHoraRegistro")),
//                                EstadoRegistro = dr.GetBoolean(dr.GetOrdinal("EstadoRegistro"))
//                            };

//                            lstDetalleGrupoPuertoExterno.Add(detgrupopuertoexterno);
//                        }

//                        SqlHelper.CloseConnection(conexion);
//                    }
//                }
//            }

//            return lstDetalleGrupoPuertoExterno;
//        }

//        public List<DatoGeneralVBBL> ConsultarDatoGeneralVBBL(ConsultaDatoGeneralVBBL request)
//        {
//            List<DatoGeneralVBBL> lstDatoGeneralVBBL = new List<DatoGeneralVBBL>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("TRAMARSA")))
//            {
//                using (SqlCommand cmd = SqlHelper.CreateCommand("USP_CONSULTAR_DATOGENERALVBBL", conexion, true))
//                {
//                    SqlParameterCollection parametrosIn = cmd.Parameters;

//                    parametrosIn.Add("@CodigoNave", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.CodigoNave) ? string.Empty : request.CodigoNave;
//                    parametrosIn.Add("@NumeroViaje", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.NumeroViaje) ? string.Empty : request.NumeroViaje;
//                    parametrosIn.Add("@NumeroBL", SqlDbType.VarChar).Value = string.IsNullOrEmpty(request.NumeroBL) ? string.Empty : request.NumeroBL;

//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            DatoGeneralVBBL datoGeneral = new DatoGeneralVBBL();

//                            datoGeneral.FechaTransaccion = dr.IsDBNull(dr.GetOrdinal("FechaTransaccion")) ? new Nullable<DateTime>() : dr.GetDateTime(dr.GetOrdinal("FechaTransaccion"));
//                            datoGeneral.NumeroTransaccion = dr.IsDBNull(dr.GetOrdinal("NumeroTransaccion")) ? 0 : dr.GetInt32(dr.GetOrdinal("NumeroTransaccion"));
//                            datoGeneral.Concepto = dr.IsDBNull(dr.GetOrdinal("Concepto")) ? "" : dr.GetString(dr.GetOrdinal("Concepto")).Trim();
//                            datoGeneral.Monto = dr.IsDBNull(dr.GetOrdinal("Monto")) ? 0 : dr.GetDecimal(dr.GetOrdinal("Monto"));
//                            datoGeneral.Moneda = dr.IsDBNull(dr.GetOrdinal("Moneda")) ? "" : dr.GetString(dr.GetOrdinal("Moneda")).Trim();
//                            datoGeneral.Cantidad = dr.IsDBNull(dr.GetOrdinal("Cantidad")) ? new Nullable<decimal>() : Convert.ToDecimal(dr.GetValue(dr.GetOrdinal("Cantidad")));
//                            datoGeneral.IGV = dr.IsDBNull(dr.GetOrdinal("IGV")) ? new Nullable<decimal>() : Convert.ToDecimal(dr.GetValue(dr.GetOrdinal("IGV")));
//                            //datoGeneral.TotalCobro = dr.IsDBNull(dr.GetOrdinal("EstadoRegistro")) ? new Nullable<decimal>() : Convert.ToDecimal(dr.GetValue(dr.GetOrdinal("EstadoRegistro")));
//                            datoGeneral.TotalCobro = dr.IsDBNull(dr.GetOrdinal("TotalCobro")) ? new Nullable<decimal>() : Convert.ToDecimal(dr.GetValue(dr.GetOrdinal("TotalCobro")));
//                            lstDatoGeneralVBBL.Add(datoGeneral);
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }

//                }
//            }

//            return lstDatoGeneralVBBL;

//        }

//        public List<int> ObtenerACEscalonadoRAPT(string codigoRA, string locString, string serviceID, DateTime inicioVigencia, DateTime finVigencia)
//        {
//            List<int> codigoACList = new List<int>();

//            using (SqlConnection conexion = new SqlConnection(ContextoParaBaseDatos.DecryptedConnectionString("AcuerdoComercialAGMADB")))
//            {

//                Dictionary<string, object> parametrosIn = new Dictionary<string, object>();
//                parametrosIn.Add("@codigoRA", codigoRA);
//                parametrosIn.Add("@locString", locString);
//                parametrosIn.Add("@serviceID", serviceID);
//                parametrosIn.Add("@inicioVigencia", inicioVigencia);
//                parametrosIn.Add("@finVigencia", finVigencia);

//                using (SqlCommand cmd = SqlHelper.CreateCommandWithParameters("USP_CONSULTAR_ACESCALONADO_INDICERAPT", conexion, parametrosIn, true))
//                {
//                    using (IDataReader dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            codigoACList.Add(dr.IsDBNull(dr.GetOrdinal("CodigoAcuerdoComercialEscalonado")) ? 0 : dr.GetInt32(dr.GetOrdinal("CodigoAcuerdoComercialEscalonado")));
//                        }
//                        SqlHelper.CloseConnection(conexion);
//                    }

//                }
//            }

//            return codigoACList;
//        }


//        //Demos yo - 1
//    }

//}

