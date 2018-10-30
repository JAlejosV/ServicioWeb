USE TransmisionesDB
GO

-- SELECT * FROM sys.procedures p WHERE p.name = 'USP_PROCESAR_ARCHIVO_MANIFIESTO'
 -- SELECT am.Voyage,* FROM dbo.ArchivoManifiesto am
 -- SELECT Voyage,* FROM dbo.Itinerario i

 --update dbo.ArchivoManifiesto SET dbo.ArchivoManifiesto.Voyage = '123456'
 --update dbo.Itinerario SET dbo.Itinerario.Voyage = '123456' WHERE dbo.Itinerario.CodigoItinerario = 1

 --SELECT * FROM dbo.Puerto p WHERE p.CodigoPuertoSunat = 'BRIOA'
 --SELECT * FROM dbo.Pais p WHERE p.CodigoPaisSunat = 'BR'
-- UPDATE dbo.LineaNaviera SET dbo.LineaNaviera.CodigoEquivalencia = 'HLCU' WHERE NombreLineaNaviera LIKE '%HAPAG%'

/****** Object:  StoredProcedure [dbo].[USP_PROCESAR_ARCHIVO_MANIFIESTO]    Script Date: 10/29/2017 09:10:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[USP_PROCESAR_ARCHIVO_MANIFIESTO] -- USP_PROCESAR_ARCHIVO_MANIFIESTO 1          
(                                                                                                                                                                                                      
 --@CodigoArchivoManifiesto BIGINT
 @ContenidoArchivoManifiesto NTEXT
                   
)                                                                                                                                                                                                      
AS                  
DECLARE @li_contador INT                                                                                                                                                                                                      
DECLARE @Nro INT                                                                                                                                                 
DECLARE @ls_linea varchar(255)                                                                                                                                                                                                      
DECLARE @ptrval binary(16)                                                                                                                                                                                                      
DECLARE @Lin_Carrier VARCHAR(4)                                                                                                                                                                                                      
DECLARE @ls_segmento_ant VARCHAR(6)                                                                                                                                                                                                      
DECLARE @NomNav VARCHAR(255)                                                                                                                                                                                                      
DECLARE @NumVia VARCHAR(6)                                                                                                                                                                                                      
DECLARE @ls_parrafo varchar(255)                                                                                                                                                                                                      
DECLARE @ls_nave_nom varchar(255)                                                                                                                                                                                                      
DECLARE @ls_nave VARCHAR(10)                                                                                                                                                                                                      
DECLARE @PaisNave VARCHAR(2)                                                                                                                                                                                                      
DECLARE @ls_puerto_emb varchar(5)                                  
DECLARE @ls_puerto_des varchar(5)                                                  
DECLARE @ls_puerto varchar(5)                                                
DECLARE @ls_tipo varchar(3)                                       
DECLARE @ls_contenedor varchar(15)                                            
DECLARE @ls_tip_ctn varchar(4)                                                                             
DECLARE @ls_shipperown varchar(1)                                                                           
DECLARE @ls_regimen varchar(1)                                                                                       
DECLARE @ls_condicion varchar(1)                      
DECLARE @ls_temperatura varchar(6)                                                                     
DECLARE @ls_uni_temp varchar(3)                                               
DECLARE @ls_peso_carga varchar(15)                  
DECLARE @ls_peso_tara varchar(15)                                                                                             
DECLARE @ls_cod_prec varchar(25) --MOD MCAR 03/08/2016 Cambio en la longitud del precinto de 15 caracteres a 25                                                                                                                                     
DECLARE @ls_ent_prec varchar(2)                                                                                                                                                        
DECLARE @ls_cond_prec varchar(1)                                                                                                                                                              
DECLARE @ls_cod_prec2 varchar(25)--MOD MCAR 03/08/2016 Cambio en la longitud del precinto de 15 caracteres a 25                                                                                                                                                           
DECLARE @ls_ent_prec2 varchar(2)                                                                                                                          
DECLARE @ls_cond_prec2 varchar(1)                                                                                                                      
DECLARE @ls_cod_prec3 varchar(25)--MOD MCAR 03/08/2016 Cambio en la longitud del precinto de 15 caracteres a 25                                                                                                                                                             
DECLARE @ls_ent_prec3 varchar(2)                                                                                                                                 
DECLARE @ls_cond_prec3 varchar(1)                                                                                                                                                    
DECLARE @ls_cod_prec4 varchar(25)--MOD MCAR 03/08/2016 Cambio en la longitud del precinto de 15 caracteres a 25                                                                                                                                                                         
DECLARE @ls_ent_prec4 varchar(2)                                                                                                                                                                                                              
DECLARE @ls_cond_prec4 varchar(1)                                                                                                                                                                                                              
DECLARE @ls_cod_prec5 varchar(25)--MOD MCAR 03/08/2016 Cambio en la longitud del precinto de 15 caracteres a 25                                                                                                                                                 
DECLARE @ls_ent_prec5 varchar(2)                                                                                                                                                             
DECLARE @ls_cond_prec5 varchar(1)                                                                                                                                                             
DECLARE @TipoPeso VARCHAR(2)                                                                                                                                                                                                      
DECLARE @ls_tipdoc varchar(3)                                                        
DECLARE @ls_nrodoc varchar(35)                                                                                                
DECLARE @ls_nrobooking varchar(35)                                               
DECLARE @ls_nrocontrato varchar(35)                 
DECLARE @ls_codrecargo VARCHAR(10)                                                      
DECLARE @ls_montorecargo VARCHAR(10)                                                                                                   
DECLARE @ls_mondeda VARCHAR(6)                                                            
DECLARE @ls_condpago VARCHAR(1)                                                              
DECLARE @ls_ptoori VARCHAR(6)                                                  
DECLARE @ls_ptoemb VARCHAR(6)                                                                                                            
DECLARE @ls_ptodes VARCHAR(6)                                                              
DECLARE @ls_ptofin VARCHAR(6)                                                                                             
DECLARE @ls_oriptoemb VARCHAR(6)                                                                                                                                              
DECLARE @ls_ptoentrega VARCHAR(6)                                                                                                            
DECLARE @ls_rolcliente VARCHAR(2)                                                                                                                                                                                                                                             
DECLARE @ls_ConsigHALO VARCHAR(20)                                                                                                                                    
DECLARE @ls_Noti1HALO VARCHAR(20)                                                                                                                                   
DECLARE @ls_Noti2HALO VARCHAR(20)                                                                                                                                                           
DECLARE @ls_EmbarHALO VARCHAR(20)                                                                                                                                                                                                      
DECLARE @ls_MarketHALO VARCHAR(20)                                                                                                                                                     
DECLARE @Consig VARCHAR(255)                                                                                                                                           
DECLARE @DirConsig VARCHAR(255)                                                                                                                                                                                
DECLARE @Noti1 VARCHAR(255)                                                                                                                                                                 
DECLARE @DirNoti1 VARCHAR(255)                                                                                                                                                                                          
DECLARE @Noti2 VARCHAR(255)                                                                                                                                                               
DECLARE @DirNoti2 VARCHAR(255)                                                                                                                              
DECLARE @Exportador VARCHAR(255)                                                                                                                                                                             
DECLARE @DirExportador VARCHAR(255)                                                                                                                 
DECLARE @Market VARCHAR(255)                                  
DECLARE @DirMarket VARCHAR(255)                                             
DECLARE @FechaEmisionBL VARCHAR(20)              
DECLARE @FechaEmbarqueBL VARCHAR(20)          
DECLARE @ItmCtn VARCHAR(4)                                                                                                                                                                  
DECLARE @CanBul VARCHAR(10)                                                                                             
DECLARE @UnidadBasicaCarga VARCHAR(6)                                                        
DECLARE @DescripcionMercaderia VARCHAR(4000)                                                                                                                                                                                                                           
DECLARE @ls_peso_carga2 varchar(15)                                                                                                     
DECLARE @ls_volumenctn varchar(15)                                                                                                                                                                        
DECLARE @ContenedorBL VARCHAR(15)                                                                                                                                                                                             
DECLARE @NumPaquetesCtn VARCHAR(10)                                                                                      
DECLARE @MarcasyNumeros VARCHAR(255)                                                                                                             
DECLARE @CodNavHawk VARCHAR(3)                                                                                                                                                                                                     
DECLARE @NumViaHawk VARCHAR(6)                                                                                                                                                                                    
DECLARE @CodSucHawk VARCHAR(2)                                                                                                                                    
DECLARE @LineaHawk VARCHAR(3)                                                                                                                    
DECLARE @PtoOriHawk VARCHAR(3)                                                                                                                                                                                                   
DECLARE @PtoEmbHawk VARCHAR(3)                                                                                                                                                                                    
DECLARE @PtoDesHawk VARCHAR(3)                                                                                                                                                                     
DECLARE @PtoFinHawk VARCHAR(3)                                                                                        
DECLARE @CodSrvNavHawk VARCHAR(3)                                                                                    
DECLARE @CodTrpHawk VARCHAR(3)                                              
DECLARE @CodUBCHawk VARCHAR(4)                         
DECLARE @OpeDesHawk VARCHAR(6)             
DECLARE @CodAlmHawk VARCHAR(2)                                                                                                            
DECLARE @CodDepHawk VARCHAR(2)                                                                                                  
DECLARE @CodRecargoHawk VARCHAR(2)                                                
DECLARE @TipTamCtn VARCHAR(6)                                                 
DECLARE @TamCtn VARCHAR(3)                                                                 
DECLARE @TaraCtn VARCHAR(10)                                                                                                         
DECLARE @MonedaHawk VARCHAR(4)                                         
DECLARE @ClaseImo VARCHAR(3)                                                                                                  
DECLARE @NroImo VARCHAR(10)                                                                                       
DECLARE @nrodescrip INTEGER                                                                                                                                           
DECLARE @isctnvacio varchar(50)                                                                                    
DECLARE @RegimenHALO_BL varchar(1)                                                                                                                                                                                         
DECLARE @size INTEGER                                                                                                                                         
DECLARE @cont INTEGER                                                                                                                                                                                          
DECLARE @cantreg INTEGER                                                                      
DECLARE @contValores INTEGER                                                                                                    
DECLARE @NomPto VARCHAR(40)                                                                                                                                                                                      
DECLARE @contBl INT                                                                                                     
DECLARE @CantRegbl INT                                                                                                                                             
DECLARE @CodNav VARCHAR(3)                                                                                  
DECLARE @NumViab VARCHAR(6)                                                                                                                                                                      
DECLARE @PtoOri VARCHAR(3)                                                                                                                                                               
DECLARE @PtoEmb VARCHAR(3)                                                                                                                                                                                      
DECLARE @PtoDes VARCHAR(3)                                                                                                         
DECLARE @DesFin VARCHAR(3)                                                                                                                                                                                      
DECLARE @CodLin VARCHAR(3)                                                                                                     
DECLARE @Nro_BL VARCHAR(20)                                                                                                                                 
DECLARE @ConCtn VARCHAR(11)                                                
DECLARE @Maxid INTEGER                                                          
DECLARE @contCtn SMALLINT                                                                                                                                                                        
DECLARE @IsPCI SMALLINT                                                                                                                   
DECLARE @CodRec VARCHAR(2)                                                                                         
DECLARE @cust_type VARCHAR(2)                                                                                                                               
DECLARE @cust_id VARCHAR(17)                                                           
DECLARE @IdProceso FLOAT                                          
DECLARE @TipoEDI VARCHAR(10)                                  
DECLARE @ls_error VARCHAR(255)                                                                                                        
DECLARE @NroVersionBL SMALLINT                                                                        
DECLARE @Tmp_Precinto VARCHAR(16)                                                               
DECLARE @Codeyc_cn VARCHAR(15)                                                                            
DECLARE @Codeyc_n1 VARCHAR(15)                                                                                                                                                       
DECLARE @Codeyc_n2 VARCHAR(15)                                                                                                                                 
DECLARE @Codeyc_cz VARCHAR(15)                                                                        
DECLARE @Codeyc_rp VARCHAR(15)                                                                                                                                          
DECLARE @CodDepOld VARCHAR(2)                                                                                                                                       
DECLARE @l_codalm_dir VARCHAR(4)                                                                                                               
DECLARE @flg_DirEsp char(1)   --                                                                                                                                                                                                                                             
DECLARE @p_Bloques VARCHAR(50)                                                                  
DECLARE @p_cnt_old VARCHAR(15)                                                                         
DECLARE @p_cnt_new VARCHAR(15)                                                                                                                            
DECLARE @p_bloque_old VARCHAR(100)                                                                                                                            
DECLARE @ls_condicion_old VARCHAR(10)                                                                                                                            
DECLARE @ls_bls_old VARCHAR(50)                                                                                          
DECLARE @ls_bls_new VARCHAR(50)                                                                                                                        
DECLARE @TipTamCtn_old VARCHAR(6)                                                                                                                                                
DECLARE @TamCtn_old VARCHAR(3)                                                                                                                                                                                     
DECLARE @ls_regimen_old VARCHAR(1)                                                                                                       
DECLARE @Coddep_shipperown VARCHAR(2)                                                    
DECLARE @RECA_C_NUMERO CHAR(10)                           
DECLARE @CanBulNoPCI VARCHAR(10) -- ADD JAV 28/09/2015, Almacena CanBul de CTN que no tengan PCI (MyN)                                
DECLARE @CodUBCHawkNoPCI VARCHAR(6)   -- ADD JAV 28/09/2015, Almacena Unidad Basica Carga de CTN que no tengan PCI (MyN)                                                      
DECLARE @tableHTML  NVARCHAR(MAX)  -- ADD JAV 03/11/2015, O.C: 35922, Solicitado por DPACORA                                              
DECLARE @Asunto VARCHAR(255) -- ADD JAV 03/11/2015, O.C: 35922, Solicitado por DPACORA                                                      
DECLARE @NomSuc VARCHAR(40)                                            
DECLARE @Correos VARCHAR(500)                                   
DECLARE @FecArrHawk DATETIME              
DECLARE @ShipperOwnTanqueCtn CHAR(1)   
DECLARE @ID_PART_ARAN INT       
DECLARE @CodigoPartidaArancelaria VARCHAR(10) --ADD MCAR 05/01/2016 ARANCELARIO      
DECLARE @CTNTMP VARCHAR(25)     --ADD MCAR 05/01/2016 ARANCELARIO      
DECLARE @CodPartAran VARCHAR(20)--ADD MCAR 05/01/2016 ARANCELARIO    
DECLARE @RUC VARCHAR(11)         -- ADD JAV BLRUC 08/05/17
DECLARE @RolClienteRUC  VARCHAR(6)  --ADD JAV BLRUC 08/05/17   
DECLARE @p_BloqueConsig VARCHAR(50)               
DECLARE @p_BloqueRoles VARCHAR(50) 
DECLARE @EstadoRUC BIT 
DECLARE @Voyage VARCHAR(10)            
                  
--PRINT 'FECHA HORA INICIO PROCESO ACTUAL: ' + CONVERT(VARCHAR,GETDATE(),108)                  
                  
/*CODIGOCLIENTE**/                    
DECLARE @CODIGOCLIENTE CHAR(6)                    
/*Variables Cursor Vacios*/                                        
DECLARE                                         
 @P_CodNav  CHAR(3),                                        
 @P_Numvia  CHAR(6),                                        
 @P_PtoOri CHAR(3),                                        
 @P_Ptoemb CHAR(3),                                        
 @P_PtoDes CHAR(3),                                  
 @P_DesFin CHAR(3),                                        
 @P_CodLinea CHAR(3),                                        
 @P_Nro_BL VARCHAR(25),                                        
 @P_CodCtn VARCHAR(20),                                        
 @P_TipCtn VARCHAR(6),                                        
 @P_CodCns VARCHAR(10),                                        
 @P_CodSrv VARCHAR(6),                                        
 @P_CodNot VARCHAR(10),                                        
 @P_Nor CHAR(1)                                                    
                                                                                                                            
SET @flg_DirEsp='0'                                               
SET @IsPCI = 0                                                                                      
                                                                                                                                                                                                                                                                                                                                                                                                                                
DECLARE @Containers TABLE                                                            
(                                            
 id INT IDENTITY(1,1),                                                        
 CodCtn VARCHAR(11),                                               
 TipTamCtn VARCHAR(6),                                                                                                                                                                   
 TamCtn VARCHAR(2),                                                                                                                                                                                                    
 Tara VARCHAR(6)                                                                                                            
)                                               
                                                         
DECLARE @TmpCarga TABLE                                                                                                                                                                                                
 (                                                                                                                                                                             
  id INT IDENTITY(1,1),                                                                                                                                              
  NroBL VARCHAR(20),                                                                                                                                           
  CodCtn VARCHAR(11),                            
  CantCtn INTEGER                                                                                                                                           
 ) 
 
DECLARE @Temporal_Contenedor TABLE                                                                                                                                                                             
(                                                                                                             
 PK_Contenedor INT IDENTITY(1,1),                                                                                                                                   
 NumeroContenedor VARCHAR(11),                                                                                                                                                                                           
 CodigoTipoContenedor bigint, 
 PropietarioContenedor bit,                                              
 CodigoCondicionTransporte bigint,                                                                                                                                               
 PesoCarga VARCHAR(15),                                                                   
 PesoTara VARCHAR(15),                                                   
 Precinto1 VARCHAR(25),
 EntidadPrecinto1 VARCHAR(2),                                                                                                                         
 Temperatura VARCHAR(6),                                                                                                        
 UnidadTemperatura VARCHAR(3)                                                                                                                                                                                                                                                                                                                                          
)                                                                           
              
DECLARE @Temporal_Documento TABLE                                                               
(                                                                                                                               
 PK_Documento INT IDENTITY(1,1),                                                                                                                                                                                                                                                                                                                                                                                                                        
 CodigoPuertoOrigenDocumento BIGINT,                                                                                                                                                            
 CodigoPuertoEmbarqueDocumento BIGINT,                                                                                                     
 CodigoPuertoDescargaDocumento BIGINT,                                                                                                                                                                     
 CodigoPuertoFinalDocumento BIGINT,                                                                                                                                           
 CodigoAduana BIGINT, 
 CodigoTipoBL BIGINT, 
 CodigoTipoEnvio BIGINT, 
 CodigoCondicionContrato BIGINT, 
 CodigoRequerimientoServicio BIGINT, 
 NumeroDocumento VARCHAR(25), 
 FechaEmisionDocumento VARCHAR(20),                                                                                                                                                    
 FechaEmbarqueDocumento VARCHAR(20)                                                                                                                                                                                                                                                                                   
)                                                               
                                                                                                              
DECLARE @Temporal_DocumentoDetalleCarga TABLE                                                          
(                                                                                                                                                         
 PK_DocumentoCarga INT IDENTITY(1,1),                                                                                                                                                                                                                                                                                                                                                                                                          
 NumeroDocumento VARCHAR(25),                                                                                                                                                                                                                                                                                                            
 NumeroContenedor VARCHAR(11),  
 CodigoCondicionTransporte bigint,
 CodigoTipoMovimiento bigint,
 CodigoUnidadMercancia bigint,
 CodigoNaturalezaCarga bigint,
 CodigoCondicionCarga bigint,
 CodigoTemperatura bigint,
 CodigoClaseIMO bigint,
 CodigoNumeroIMO bigint,
 CodigoAlmacen bigint,
 CodigoDeposito bigint,
 CodigoPrecinto bigint,                                                                                                                                                                                                   
 ItemDocumento int,
 CantidadBulto int,                                                                                                                                                                                                                                                                                                                                                                                                                                     
 PesoBruto decimal(15,2),                                                                                                               
 VolumenBruto decimal(15,2), 
 TemperaturaMinima decimal(15,2),                                              
 TemperaturaMaxima decimal(15,2),
 Propietario bigint,
 Observacion VARCHAR(150),
 DescripcionMercaderia VARCHAR(4000),                                                                                                                                      
 MarcasNumeros VARCHAR(4000), 
 Falto bit
 )                                                                                                                                                                                                                                                                                                           
                                                                                                                                                                                            
DECLARE @Temporal_DocumentoDetalleFlete TABLE                                                
(                                                                                                                                                                                        
 PK_DocumentoFlete INT IDENTITY(1,1),                                                                                                                                                                                                                     
 NumeroDocumento VARCHAR(25),                                                                                                                                                                                                  
 CodigoTipoFlete BIGINT,                                                                                                                                                                                                      
 CodigoMoneda BIGINT, 
 CodigoModoPago BIGINT, 
 MontoFlete decimal(15,2)                                                                                                                                                                           
)                                                                                                                                                                                  
                                                                     
DECLARE @Temporal_DocumentoDetalleCliente TABLE                                                                                                                                              
(                                                                      
  PK_DocumentoCliente INT IDENTITY(1,1),                                                                                                                   
  NumeroDocumento VARCHAR(25),                                                          
  CodigoRol BIGINT, 
  CodigoPersona BIGINT
)                                                                                                                                             
                                                                                                                                                                                                                                                                                                                                                                    
DECLARE	@CodigoLineaNaviera BIGINT   
DECLARE	@CodigoItinerario BIGINT
DECLARE	@CodigoTipoOperacion BIGINT
DECLARE	@CodigoAduana BIGINT
DECLARE	@CodigoTipoContenedor BIGINT 
DECLARE	@CodigoCondicionTransporte BIGINT 
DECLARE	@CodigoTipoFlete BIGINT 
DECLARE	@ModoPago BIGINT 
DECLARE	@CodigoMoneda BIGINT 
DECLARE	@CodigoModoPago BIGINT 
DECLARE	@CodigoPuertoOrigen BIGINT 
DECLARE	@CodigoPuertoEmbarque BIGINT 
DECLARE	@CodigoPuertoDescarga BIGINT 
DECLARE	@CodigoPuertoFinal BIGINT 
DECLARE	@CodigoUnidadMercancia BIGINT 
DECLARE @CodigoTipoEnvio BIGINT
DECLARE @CodigoClaseIMO BIGINT
DECLARE @CodigoNumeroIMO BIGINT
DECLARE @CodigoPersona BIGINT
DECLARE @CodigoRol BIGINT
DECLARE @Min_PK_Contenedor int = 1
DECLARE @Max_PK_Contenedor int = 0
DECLARE @NumeroContenedor varchar(11)
DECLARE @TCodigoTipoContenedor bigint
DECLARE @Precinto1 varchar(25)
DECLARE @EntidadPrecinto1 varchar(2)
DECLARE @Temperatura decimal(15,2)
DECLARE @UnidadTemperatura varchar(3)
DECLARE @CodigoEntidadPrecinto bigint
DECLARE @CodigoPrecinto bigint
DECLARE @PesoTara decimal(15,2)
DECLARE @CodigoContenedor bigint 

SET NOCOUNT ON                                                                                                                                                                               
                                                                                                                                   
/*INICIO DE LA TRANSACCION SQL (MANEJO DE ERRORES)*/                                                                            
--BEGIN TRANSACTION                                                           
--BEGIN TRY                                                      
                                                                                                                                                                                  
--DELETE FROM Tmp_BLs_HALO                                                                                                                               
--DELETE FROM Tmp_BLItemscarga_HALO                        
--DELETE FROM Tmp_BLRecargos_HALO                                                                                               
--DELETE FROM Tmp_BLAudit_HALO                                                                                                                                                                                                   
--DELETE FROM Tmp_bl_cust_HALO                                         
--DELETE FROM Tmp_BLs_Transito_HALO     
-- DELETE from @Temporal_DocumentoDetalleCargaCarga_PartidaArancelaria  --ADD MCAR 05/01/2016 ARANCELARIO                                                                                                                             
-- DELETE FROM Tmp_BLTextos_HALO      
-- DELETE FROM @Tmp_BLRUC -- ADD BLRUC JAV 08/05/17                                                                                                
                                                                                                                                                                           
CREATE TABLE #TEXTO(                                                                                                          
BAPI_C_TEXTO TEXT)                                                                                                                                                                                 
                   
--SELECT * FROM ArchivoManifiesto (NOLOCK) WHERE CodigoArchivoManifiesto = @CodigoArchivoManifiesto 				   
				                           
INSERT INTO #TEXTO                                                                                                                                         
SELECT ContenidoArchivoManifiesto FROM ArchivoManifiesto (NOLOCK) WHERE CodigoArchivoManifiesto = @CodigoArchivoManifiesto  

--SELECT * FROM #TEXTO                                                           
                                                                                                                                
/*Reemplazando los caracteres especiales*/                                                                                                                                
  UPDATE #TEXTO                                                                                                                                                                                                
  SET BAPI_C_TEXTO = CAST(REPLACE(CAST(BAPI_C_TEXTO AS NVARCHAR(MAX)),'?''','') AS TEXT)                                                                   
                                                                                                                                                                                   
    UPDATE #TEXTO                                                                                                                      
  SET BAPI_C_TEXTO = CAST(REPLACE(CAST(BAPI_C_TEXTO AS NVARCHAR(MAX)),'?+','') AS TEXT)                                                                                                                                                                       
                             
    UPDATE #TEXTO                                                           
  SET BAPI_C_TEXTO = CAST(REPLACE(CAST(BAPI_C_TEXTO AS NVARCHAR(MAX)),'?:','') AS TEXT)                                                                                                                                                                       
/*******/                                                                                         
                                                                                                                        
 SET @p_Bloques=''                                                                                                                                
 SET @p_bloque_old=''
 SET @p_BloqueConsig = ''                                                  
 SET @p_BloqueRoles = '' 
 SET @EstadoRUC = 0                                                       
                                                                                                                                                                                                
/***************************************/                                                                                                             
                                                                                                                  
WHILE NOT (SELECT PATINDEX('%''%', BAPI_C_TEXTO) FROM #TEXTO) = 0                                                                                                                                                            
BEGIN                                                                                           
 SELECT @Nro = PATINDEX('%''%', BAPI_C_TEXTO) FROM #TEXTO                                                                                                                                
 SELECT @ls_linea = SUBSTRING(BAPI_C_TEXTO,1,@Nro - 1) FROM #TEXTO                                                                                                      
                 
 SELECT @ptrval = TEXTPTR(BAPI_C_TEXTO) From #TEXTO                                                       
                                      
 UPDATETEXT #TEXTO.BAPI_C_TEXTO @ptrval 0 @Nro ''                                                  
                                                                             
/***************************** CABECERA ***********************************/                                                                                  
-- Tipo de Archivo  
IF @ls_linea LIKE 'UNH+%'                                                                                                                                                                                                       
BEGIN                                                                         
    IF CHARINDEX('+',@ls_linea) > 0                                                                                                             
	BEGIN                                                                                                                                                                                       
		SELECT @ls_linea = SUBSTRING(@ls_linea,charindex('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                                                         
	END
	IF CHARINDEX('+',@ls_linea)>0                                                                                                                                                       
	BEGIN                                                                                                                                              
		SELECT @TipoEDI = SUBSTRING(@ls_linea,charindex('+',@ls_linea,1)+1,charindex(':',@ls_linea,1)-3)                       
	END                                                                                               
        
    IF @TipoEDI<>'CUSCAR'                                  
    BEGIN   
		PRINT 'No es Archivo Cuscar'
		BREAK                                                                                                                                                                                                                                                                           
		--SELECT @ls_error = 'El Archivo Seleccionado no tiene Formato CUSCAR'                                                                             
		--RaisError 30002 @ls_error                                                                                                     
		--Return                                                                                                                                                                     
	END                                                                                                                                              
	SET @ls_segmento_ant = 'UNH'                                                                                                                                                       
END                                                                                                                                         

--SELECT * FROM LineaNaviera WHERE dbo.LineaNaviera.NombreLineaNaviera LIKE '%hapag%'
--update LineaNaviera SET LineaNaviera.CodigoEquivalencia='HLCU' WHERE dbo.LineaNaviera.NombreLineaNaviera LIKE '%hapag%'
                                                                                                                                          
-- Linea Naviera                                               
IF @ls_linea LIKE 'RFF+AAZ%'                                                                                                                                      
BEGIN                                                        
	IF CHARINDEX(':',@ls_linea) > 0            
	BEGIN                                                                                                                                        
		SELECT @Lin_Carrier = SUBSTRING(@ls_linea,charindex(':',@ls_linea,1)+1,LEN(@ls_linea))   
		                                                                                                              
		IF NOT EXISTS(SELECT CodigoLineaNaviera FROM dbo.LineaNaviera (NOLOCK) 
			WHERE CodigoEquivalencia = @Lin_Carrier)  
		BEGIN
			PRINT 'Equivalencia Linea Naviera no Existe '+@Lin_Carrier  
			BREAK 
		END
		ELSE
		BEGIN
			SELECT @CodigoLineaNaviera=CodigoLineaNaviera FROM dbo.LineaNaviera (NOLOCK) 
			WHERE CodigoEquivalencia = @Lin_Carrier
		END		                   
	END                                                                                                                                                                                                                                                                                                                          
  SET @ls_segmento_ant = 'RFF+AAZ'                                                                                                                                                             
END  

-- Voyage 
IF @ls_linea LIKE 'RFF+VON%'  
BEGIN 
   SET @Voyage = SUBSTRING(@ls_linea,9,LEN(@ls_linea)) 
   
   IF LEN(ISNULL(@Voyage,''))=0
   BEGIN
	   PRINT 'No está enviando Voyage en el Archivo' 
	   BREAK
   END
   ELSE
   BEGIN
		IF NOT EXISTS(SELECT CodigoItinerario FROM dbo.Itinerario (NOLOCK) WHERE Voyage = @Voyage AND EstadoRegistro = 1)
		BEGIN
			PRINT 'No existe Itinerario con Voyage '+@Voyage 
			BREAK
		END
		ELSE
		BEGIN 
		SELECT @CodigoItinerario=ISNULL(CodigoItinerario,0),@CodigoTipoOperacion=ISNULL(CodigoTipoOperacion,0),@CodigoAduana=ISNULL(CodigoAduana,0) 
		FROM dbo.Itinerario (NOLOCK) WHERE Voyage = @Voyage AND EstadoRegistro = 1
		END
   END
   SET @ls_segmento_ant = 'RFF+VON' 
END           
                                                                                                                                      
/************************ EQD ****************************/  
-- Contenedor                                                                                                                              
IF @ls_linea LIKE 'EQD%'                                                                                                                                                                                                             
BEGIN                                                                              
	SELECT @ls_linea = substring(@ls_linea,5, LEN(@ls_linea))                                                 
                                                                                                                        
	IF CHARINDEX('+',@ls_linea,1) > 0                                                                                                                                      
	BEGIN                                                                              
		SELECT @ls_linea = substring(@ls_linea,CHARINDEX('+',@ls_linea,1)+1, LEN(@ls_linea))                                                                        
                                                                                                                                              
	IF CHARINDEX('+',@ls_linea,1) = 0                                                                                                         
	BEGIN                                           
		IF CHARINDEX(':',@ls_linea,1) = 0                                                                                                                                                                 
			SELECT @ls_contenedor = @ls_linea                                                          
		ELSE                                                                                                       
			SELECT @ls_contenedor = SUBSTRING(@ls_linea,1, CHARINDEX(':',@ls_linea,1)-1)                                                                                                                                               
	END                                                                 
	ELSE                                                                                                                                                                                                              
	BEGIN                                                                                                                                                                                                   
		SELECT @ls_contenedor = SUBSTRING(@ls_linea,1, CHARINDEX('+',@ls_linea,1)-1)                                                                                                      
		SELECT @ls_linea = SUBSTRING(@ls_linea, CHARINDEX('+',@ls_linea,1)+1, LEN(@ls_linea))                                                                        
                                                                                                                                              
    IF CHARINDEX('+',@ls_linea,1)=0                                                                                                                                  
    BEGIN                                                                                                                                                                                                              
		IF CHARINDEX(':',@ls_linea,1) = 0                                           
			SELECT @ls_tip_ctn = @ls_linea                                                                                                                                   
		ELSE                                                                                                             
		SELECT @ls_tip_ctn = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                           
		END                            
    ELSE                                                             
    BEGIN                                                                                                                                             
		SELECT @ls_parrafo = SUBSTRING(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                             
                                                                                    
		IF CHARINDEX(':',@ls_parrafo,1) = 0                                           
			SELECT @ls_tip_ctn = @ls_parrafo                                                                               
		ELSE                                                                                                                         
			SELECT @ls_tip_ctn = SUBSTRING(@ls_parrafo,1,CHARINDEX(':',@ls_parrafo,1)-1)                                         
		BEGIN                                                                                                    
			SELECT @ls_linea = @ls_linea                                                                                                         
		IF CHARINDEX('+',@ls_linea,1)>0                                                                                                                      
		BEGIN                                                                       
			SELECT @ls_linea = SUBSTRING(@ls_linea,charindex('+',@ls_linea,1)+1, len(@ls_linea))                                                                                                                                                                      
			SELECT @ls_shipperown = SUBSTRING(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                 
                                      
		IF CHARINDEX('+',@ls_linea,1)>0                                           
		BEGIN                                                                                                                                                                                                              
			SELECT @ls_linea = SUBSTRING(@ls_linea,charindex('+',@ls_linea,1)+1, len(@ls_linea))                                                                                                                                                                         
                                             
        IF CHARINDEX('+',@ls_linea,1)=0                                                   
			SELECT @ls_regimen = @ls_linea                                                                                                                                                                
        ELSE       
        BEGIN                                                                                     
			SELECT @ls_regimen = SUBSTRING(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                                                                                                                                 
			SELECT @ls_linea = SUBSTRING(@ls_linea,charindex('+',@ls_linea,1)+1, len(@ls_linea))                                                                                                  
			SELECT @ls_condicion = @ls_linea                                                                                                                                                       
        END                                                                    
       END                                                     
      END                                                                                                                             
     END                                                                                                                                                                                                        
    END                                                           
   END                                                                                                                                                      
  END

	IF ISNULL(@ls_contenedor,'')=''
	BEGIN
		PRINT 'No se esta enviando Contenedor'
	END 

	IF NOT EXISTS(SELECT CodigoTipoContenedor FROM TipoContenedor (NOLOCK) WHERE CodigoIsoGrupoTipoContenedor = @ls_tip_ctn)
	BEGIN
		PRINT 'Tipo de Contenedor no registrado '+@ls_tip_ctn
	END
	ELSE 
	BEGIN
		SELECT @CodigoTipoContenedor=CodigoTipoContenedor FROM TipoContenedor (NOLOCK) WHERE CodigoIsoGrupoTipoContenedor = @ls_tip_ctn
	END

	IF NOT EXISTS(SELECT CodigoTipoEnvio FROM TipoEnvio (NOLOCK) WHERE CodigoEquivalencia = @ls_regimen)
	BEGIN
		PRINT 'Tipo de envio no registrado '+@ls_regimen
	END
	ELSE  
	BEGIN
		SELECT @CodigoTipoEnvio=CodigoTipoEnvio FROM TipoEnvio (NOLOCK) WHERE CodigoEquivalencia = @ls_regimen
	END                                                                                                                                                                                 

	IF NOT EXISTS(SELECT CodigoCondicionTransporte FROM CondicionTransporte (NOLOCK) WHERE CodigoAduanaCondicionTransporte = @ls_condicion)
	BEGIN
		PRINT 'Condicion de Transporte no registrado '+@ls_condicion
	END 
	ELSE  
	BEGIN
		SELECT @CodigoCondicionTransporte=CodigoCondicionTransporte FROM dbo.CondicionTransporte (NOLOCK) WHERE CodigoAduanaCondicionTransporte = @ls_condicion
	END                                                                                                    
                                                                                                                                                                                                                                                                                      
	SET @p_Bloques=@p_Bloques + 'EQD-'                                                                       
	SET @p_cnt_old = @p_cnt_new                                                                                                                                                             
	SET @p_cnt_new = @ls_contenedor                                                                                        
                                                                                                                                                     
	SELECT @ls_segmento_ant = 'EQD'                                                                                         
END                                                                                                                             
                                                                                                                                             
 /************************ MEA PESO CARGA ****************************/                                                  
IF @ls_linea LIKE 'MEA+WT+G%'                                                                                                                                                                                                               
BEGIN                                                                                                                
	SELECT @ls_linea = SUBSTRING(@ls_linea,5, LEN(@ls_linea))                                                                                                
                                                                                                                                      
	IF CHARINDEX('+',@ls_linea,1)>0                                                                                                                                                                      
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                      
		BEGIN                                                        
		IF CHARINDEX('+',@ls_linea,1)>0                                                 
			SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                         
                                                                                                          
	    IF CHARINDEX('+',@ls_linea,1)=0                                                                                                                                          
			SELECT @ls_parrafo = @ls_linea                                                                             
		ELSE                                            
			SELECT @ls_parrafo = substring(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                                                                         
		BEGIN                                                                                         
		IF CHARINDEX(':',@ls_parrafo,1) > 0                                                              
		BEGIN                                                                                                                      
			SELECT @ls_parrafo = SUBSTRING(@ls_parrafo,CHARINDEX(':',@ls_parrafo,1)+1, LEN(@ls_parrafo))                              
                                                                                        
		IF CHARINDEX(':',@ls_parrafo,1) = 0                                                                                                        
			SELECT @ls_peso_carga = @ls_parrafo                                                                                                                                                  
		ELSE                                                                                                                                                                                          
			SELECT @ls_peso_carga = SUBSTRING(@ls_parrafo,1,CHARINDEX(':',@ls_parrafo,1)-1)                                       
		END                                                                                                                                                                                                              
	END                                                                            
  END                                                                                                                                      
/* Codigo Anterior */                                                                                                 
  SELECT @ls_segmento_ant = 'MEA+WT+G'                                                                                
END                                                                                                                                                                              
                                                                                                                                                         
/************************ MEA PESO TARA ****************************/                                                                                                                       
IF @ls_linea LIKE 'MEA+WT+T%'                                                                                                                            
BEGIN                                                                                                                                                                                   
	SELECT @ls_linea = SUBSTRING(@ls_linea,5, LEN(@ls_linea))                                                                               
                                                                                                                                                                          
	IF CHARINDEX('+',@ls_linea,1)>0                                                                                                       
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                           
	BEGIN                                   
		IF CHARINDEX('+',@ls_linea,1)>0                                                                                                                                                             
			SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                                                        
		IF CHARINDEX('+',@ls_linea,1)=0                                                                                                              
			SELECT @ls_parrafo = @ls_linea                                                       
		ELSE                                                                                                                                                                                                              
			SELECT @ls_parrafo = substring(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                                                                                                            
		BEGIN                                                                                                                                          
		IF CHARINDEX(':',@ls_parrafo,1) > 0                                                                                                          
		BEGIN                                                                                                                                         
			SELECT @ls_parrafo = SUBSTRING(@ls_parrafo,CHARINDEX(':',@ls_parrafo,1)+1, LEN(@ls_parrafo))                                                                                                                                               
		IF CHARINDEX(':',@ls_parrafo,1) = 0                                                                            
			SELECT @ls_peso_tara = @ls_parrafo                                                      
		ELSE                                                                      
			SELECT @ls_peso_tara = SUBSTRING(@ls_parrafo,1,CHARINDEX(':',@ls_parrafo,1)-1)                                                                                                                                  
		END                                                                                                                                        
	  END                                                                                                                                          
	END                                                                                                                                                                                   
                                                                                       
IF @ls_condicion = '4' -- CTN VACIO                                                            
   BEGIN                     
	   INSERT @Temporal_Contenedor(                                                                                                                                                                                                      
	   NumeroContenedor,                                                                                                   
	   CodigoTipoContenedor,   
	   PropietarioContenedor,                                                                                                                                                                                                                                                                                              
	   CodigoCondicionTransporte,                                                                                            
	   PesoCarga,                                                                                                                               
	   PesoTara,                                                                                    
	   Precinto1,                                                                   
	   EntidadPrecinto1,                                                                                                                                                                                           
	   Temperatura,                                          
	   UnidadTemperatura                                                                                  
	   )                                                                                                                                     
	   VALUES (                                                                                         
	   @ls_contenedor,                                                                                                                                                                                                              
	   @CodigoTipoContenedor, 
	   CASE @ls_shipperown WHEN '1' THEN 1 ELSE 0 END,                                                                                                                                                                                                                                                                                         
	   @CodigoCondicionTransporte,                                                                                                                                                                                                  
	   0,                                                                                                       
	   @ls_peso_tara,                                                                                                                                                                                                      
	   @ls_cod_prec,                                                                                     
	   @ls_ent_prec,                                                                                                                                                                                                                                                                                                          
	   @ls_temperatura,                                                                                                                                           
	   @ls_uni_temp                                                                                                   
	   )                                                                                                                                 
   /*Limpiar Variables*/                          
   SELECT --@ls_contenedor = NULL,                                                                                       
   @ls_tip_ctn = NULL, @ls_condicion = NULL, @ls_peso_carga = NULL, @ls_peso_tara = NULL,                                                                                                                                
   @ls_cod_prec = NULL, @ls_ent_prec = NULL, @ls_temperatura = NULL, @ls_uni_temp = NULL,@CodigoTipoContenedor=NULL,
   @ls_shipperown = NULL, @CodigoCondicionTransporte=NULL                                         
   END                                                                                                              
   
	SET @p_Bloques=@p_Bloques +'MEA+WT+T-'                                                                                                     
               
	SELECT @ls_segmento_ant = 'MEA+WT+T'                                      
END         
                                                                                                                                                                                                                                                                                                                                                                
 /************************ SEL 1****************************/                                                                                                                                                                            
IF @ls_linea LIKE 'SEL%'                                                                                                                                                                                                           
BEGIN                                                                                                                 
	SELECT @ls_linea = SUBSTRING(@ls_linea,5,len(@ls_linea))                                                               
                                                                                                                                                   
	IF CHARINDEX('+',@ls_linea,1)=0                                                                                                                                                                                    
		SELECT @ls_cod_prec = @ls_linea                                                                                                                                     
	ELSE                                                                   
	BEGIN                                                                                              
		SELECT @ls_cod_prec = SUBSTRING(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                                                                                                                                            
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1, LEN(@ls_linea))                                                                    
                                              
		IF CHARINDEX('+',@ls_linea,1)=0                                                                                                                                                                                                              
			SELECT @ls_ent_prec = @ls_linea              
		ELSE                                                                                                                        
		BEGIN                                                                                      
			SELECT @ls_ent_prec = SUBSTRING(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                                                                                                                                        
	       
			SELECT @ls_linea = SUBSTRING(@ls_linea, CHARINDEX('+',@ls_linea,1)+1, LEN(@ls_linea))                                                                                                                                                                      
			SELECT @ls_cond_prec = @ls_linea                                                             
		END                                                                                                                                                            
	END                
                                                                                                                                     
  /* Codigo Anterior */                                                                         
  SET @p_Bloques=@p_Bloques +'SEL-'                                                                                                                                           
  SELECT @ls_segmento_ant = 'SEL'                                                                                         
                                  
  -- INICIO 48696 JAV 23/02/2016, ATAMAYO, Quita los espacios en blanco de los precintos                                  
  SET @ls_cod_prec = REPLACE(RTRIM(LTRIM(@ls_cod_prec)),' ', '')                                  
  -- FIN 48696                                  
                                                                                      
  -- INICIO JALEJOSV 19/08/2015, Solicitado por ATAMAYO, No debe ingresar precintos que vengan con este nombre: DOBLE - DOCUMENTAL - DBL  
--  INTACT - TANKER - TANKCONTAI - NCB - TANK - TP - MSA - HLXU; ADD JAV 03/11/16 - 92933 Precintos ATB  
                                                                                  
IF UPPER(RTRIM(LTRIM(@ls_cod_prec))) = 'DOBLE' OR UPPER(RTRIM(LTRIM(@ls_cod_prec))) = 'DOCUMENTAL'   
  OR UPPER(RTRIM(LTRIM(@ls_cod_prec))) = 'DBL' OR UPPER(RTRIM(LTRIM(@ls_cod_prec))) = 'INTACT'                                                                                                                          
  OR UPPER(RTRIM(LTRIM(@ls_cod_prec))) = 'TANKER' OR UPPER(RTRIM(LTRIM(@ls_cod_prec))) = 'TANKCONTAI'     
  OR UPPER(RTRIM(LTRIM(@ls_cod_prec))) = 'NCB' OR UPPER(RTRIM(LTRIM(@ls_cod_prec))) = 'TANK'     
  OR UPPER(RTRIM(LTRIM(@ls_cod_prec))) = 'TP' OR UPPER(RTRIM(LTRIM(@ls_cod_prec))) = 'MSA'     
  OR UPPER(RTRIM(LTRIM(@ls_cod_prec))) = 'HLXU'  
BEGIN                                                                                        
	SET @ls_cod_prec = ''                                                                                        
END                                                                       
-- FIN                                                                                           
                                                                                 
	IF @ls_linea NOT LIKE 'TMP%'                                                                                                                                                                                                      
		BEGIN                                                                 
		IF NOT EXISTS(SELECT NumeroContenedor FROM @Temporal_Contenedor WHERE NumeroContenedor = @ls_contenedor)                                                                                                 
		BEGIN                                                                             
			 INSERT @Temporal_Contenedor(                                                                                                                                                                     
			 NumeroContenedor,                                                                       
			 CodigoTipoContenedor,
			 PropietarioContenedor,                                                                                            		                                                                                  
			 CodigoCondicionTransporte,                                                      
			 PesoCarga,                                                                                                                                                  
			 PesoTara,                                                                                        
			 Precinto1,                                                
			 EntidadPrecinto1,                                                                                                                                                                                                                        
			 Temperatura,                                                                                                                                
			 UnidadTemperatura                                                                           
			 )                                                                                                                                                                                                      
			VALUES(                                                                                           
			 @ls_contenedor,                                                                                                                                                                        
			 @CodigoTipoContenedor,
			 CASE @ls_shipperown WHEN '1' THEN 1 ELSE 0 END,                                                                                                                        
			 @CodigoCondicionTransporte,                                                                                                                                                                                                      
			 @ls_peso_carga,                                                                                                                                                                                                      
			 @ls_peso_tara,                                                                                                                        
			 @ls_cod_prec,                                                                                                                                                                                    
			 @ls_ent_prec,                                                                                                                                                                                    
			 @ls_temperatura,                                                                             
			 @ls_uni_temp                                                                                                
			 )                                                                                                                  
		END                                                                                                                  
		ELSE                                                                                             
		BEGIN                                                                                  
		  UPDATE @Temporal_Contenedor SET                                                                                                                 
		  Precinto1 = CASE WHEN ISNULL(Precinto1,'')='' THEN @ls_cod_prec ELSE Precinto1 END                                                                                                                
		  WHERE NumeroContenedor = @ls_contenedor                                                                                                                   
		END                                                                                                                
	END                                                                            
   /*Limpiar Variables*/                                                                                                                             
   SELECT --@ls_contenedor = NULL,                                                                                                                                                                                                   
   @ls_tip_ctn = NULL, @ls_condicion = NULL, @ls_peso_carga = NULL, @ls_peso_tara = NULL,                                                                                                                                  
   @ls_cod_prec = NULL, @ls_ent_prec = NULL, @ls_temperatura = NULL, @ls_uni_temp = NULL, 
   @CodigoTipoContenedor=NULL, @ls_shipperown = NULL, @CodigoCondicionTransporte=NULL                                                                                                                                          
END                                                                                                           
                                                                                                                                                    
 /************************ TMP ****************************/                    
IF @ls_linea LIKE 'TMP%'                                                              
BEGIN                                                                                                                       
	SELECT @ls_linea = SUBSTRING(@ls_linea,5,LEN(@ls_linea))                                                                                                                                                                             
	IF CHARINDEX('+',@ls_linea,1)>0                                                                                              
	BEGIN                                                                                                                                                                                                              
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                              
		IF CHARINDEX(':',@ls_linea,1)=0                                                                                                                             
			SELECT @ls_temperatura = @ls_linea                                                             
		ELSE                                                                       
		BEGIN                                                                         
			SELECT @ls_temperatura = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                                                                                                                  
			SELECT @ls_uni_temp = SUBSTRING(@ls_linea, CHARINDEX(':',@ls_linea,1)+1, LEN(@ls_linea))                                                                                                     
		END                                                                                                                                    
	END                                                                                                                                                                                                                                 
                                                                                                                  
	  UPDATE @Temporal_Contenedor SET                                                                     
	  Temperatura=@ls_temperatura,                                                                                                                
	  UnidadTemperatura=@ls_uni_temp                                         
	  WHERE NumeroContenedor = @ls_contenedor                                                                                                                
                                           
  /*Limpiar Variables*/                                                                               
  SELECT --@ls_contenedor = NULL,                                                                                                                                                                                                       
  @ls_tip_ctn = NULL,@ls_regimen = NULL, @ls_condicion = NULL, @ls_peso_carga = NULL, @ls_peso_tara = NULL,                                          
  @ls_cod_prec = NULL, @ls_ent_prec = NULL, 
  @ls_temperatura = NULL, @ls_uni_temp = NULL, @TipTamCtn=NULL, @TamCtn=NULL, @ls_shipperown = NULL, @CodigoCondicionTransporte=NULL                                                           
                                                        
  SELECT @ls_segmento_ant = 'TMP'                                                                                                                                                                     
END                                                                                                                                                                   
                                                                                                                            
 /*************Validacion Si el contenedor no tiene Precinto**************/                                                  
IF @p_cnt_old<>@p_cnt_new                                                                                                                                
BEGIN                                                                                         
	SET @p_bloque_old=@p_Bloques                                                                                                                                                                                            
	IF (@p_bloque_old NOT LIKE '%SEL%') AND (ISNULL(@ls_condicion_old,@ls_condicion)= 8 OR ISNULL(@ls_condicion_old,@ls_condicion)=7)  
	-- JAV 22/10/2015, Se modifico ya que le primer EQD no capturaba las variables.                                       
    BEGIN  
		IF NOT EXISTS(SELECT NumeroContenedor FROM @Temporal_Contenedor WHERE NumeroContenedor = @p_cnt_old)                                                                                         
		BEGIN                                                                                                                              
		   INSERT @Temporal_Contenedor(                                                                                                                 
		   NumeroContenedor,                                                                                           
		   CodigoTipoContenedor, 
		   PropietarioContenedor,                                                                                                                                                             
		   CodigoCondicionTransporte,                                                                          
		   PesoCarga,                                                                                                                  
		   PesoTara,                                                                                                                                                                                                          
		   Precinto1,                                                                                                                                                      
		   EntidadPrecinto1,                                                                                
		   Temperatura,                                                                                                                   
		   UnidadTemperatura                                                                                   
		   )                                                                                                                                       
		   VALUES(                                                                                     
		   @p_cnt_old,                                                                                               
		   @CodigoTipoContenedor,
		   CASE @ls_shipperown WHEN '1' THEN 1 ELSE 0 END,
		   @CodigoCondicionTransporte,                                                                                                                                                                                                                                                                             
		   --ISNULL(@ls_condicion_old,@ls_condicion),
		   @ls_peso_carga,                                                                             
		   @ls_peso_tara,                                                                                                                                                 
		   @ls_cod_prec,                                                                                                                                          
		   @ls_ent_prec,                                                                                             
		   @ls_temperatura,                                                                                                                                                          
		   @ls_uni_temp                                                                                                                       		                                                                                         
           )
           
          PRINT 'El Contenedor Full no tiene Precinto '+@p_cnt_old                                                                                                                                                                                                                                                                                            
      END                           
 END
 
 SET @p_Bloques=''                                                                                                                               
 SET @p_cnt_old=@p_cnt_new                                                                                                                            
 SET @ls_condicion_old=@ls_condicion                                                                                                                        
 SET @TipTamCtn_old = @TipTamCtn                                                                                                                                                            
 SET @TamCtn_old =  @TamCtn                                   
 SET @ls_regimen_old = @ls_regimen                                                                           
                                                           
 END                                                                           
 -- ADD JAV 30/10/2015, Si el Ultimo Contenedor (EQD) no tiene Precinto, lo inserta Acá                                                                          
 --If @ls_linea like 'RFF+BM%' AND @p_cnt_new <> '' AND @p_bloque_old NOT LIKE '%SEL%' -  
 -- 371431 JAV 11/01/2016, Ultimo Contenedor sin Precinto, La linea linea anterior se comenta y se coloca la de linea abajo                                                                                                                         
IF @ls_linea LIKE 'RFF+BM%' AND @p_cnt_new <> '' AND @p_Bloques NOT LIKE '%SEL%'   
BEGIN                                                                         
	IF NOT EXISTS(SELECT NumeroContenedor FROM @Temporal_Contenedor WHERE NumeroContenedor = @p_cnt_new)                                                                          
	BEGIN                                                                          
		   INSERT @Temporal_Contenedor(                                                                                                                                                                                                   
		   NumeroContenedor,                                                                                                    
		   CodigoTipoContenedor, 
		   PropietarioContenedor,                                                                                                                                                  
		   CodigoCondicionTransporte,                                                                                                                     
		   PesoCarga,                                                                                                                                                                                                          
		   PesoTara,                                                                                                                                                                                                          
		   Precinto1,                                                                                  
		   EntidadPrecinto1,                              
		   Temperatura,                                                      
		   UnidadTemperatura                                                                                                                                                                                                          
		   )                                            
		   VALUES(                                                   
		   @p_cnt_new,                                                                                                                                                    
		   @CodigoTipoContenedor,
		   CASE @ls_shipperown WHEN '1' THEN 1 ELSE 0 END,                                                                                                                                                                                                                                                                                               
		   @CodigoCondicionTransporte,                    
		   @ls_peso_carga,                                                      
		   @ls_peso_tara,                                                                                      
		   @ls_cod_prec,                                                 
		   @ls_ent_prec,                                                                                                                                                                                                  
		   @ls_temperatura,                  
		   @ls_uni_temp                                                                                                            
		   )                                                                                      
		                                        
		   PRINT 'El Contenedor Full no tiene Precinto '+@p_cnt_old                                     
	END                                                                           
		 SET @p_cnt_new = ''                                                                                
END                                                                       
 -- FIN                                                                                                                       
                                                                                                             
 /************************ RFF BM: Nro de BL ****************************/                                                                                                                                                                                    
IF @ls_linea LIKE 'RFF+BM%'                                                                                                                                            
BEGIN                                                                              
	SET @ls_contenedor = ''    
	SET @p_BloqueConsig = ''  
	SET @p_BloqueRoles = ''  
	SET @EstadoRUC = 0 
                                                                                                                
	IF CHARINDEX('+',@ls_linea) = 0                                                                                                                  
		SELECT @ls_linea = SUBSTRING(@ls_linea,1,LEN(@ls_linea))                                                                               
	ELSE                                                         
		SELECT @ls_linea = SUBSTRING(@ls_linea,charindex('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                                                              
	BEGIN                                                                                                
		SELECT @ls_tipdoc = SUBSTRING(@ls_linea,1,charindex(':',@ls_linea,1)-1)                                                                                                                  
		SELECT @ls_nrodoc = SUBSTRING(@ls_linea, (CHARINDEX(':',@ls_linea)+1), LEN(@ls_linea))                                                
	END                                                                                                                                                                                                          
	
	IF ISNULL(@ls_nrodoc,'')=''                                                                                                                                                                                   
    BEGIN 
		PRINT 'En el Segmento RFF+BM no estan enviando el Numero de Documento'                                                                                                                                                                                                
	END                                                        
	SET @ls_bls_old =@ls_bls_new                         
	SET @ls_bls_new =@ls_nrodoc                                                                                                                    
                                               
	SET @ls_segmento_ant = 'RFF+BM'                                                                                 
END                                                
                                                                                                                                                                                                                                                                                                                                                                                                                                   
 /************************ MOA -(Fletes Collect) ****************************/                    
IF @ls_linea LIKE 'MOA%'                                                                                                                                                                                                             
BEGIN                                                                 
	SELECT @ls_linea = SUBSTRING(@ls_linea,5,LEN(@ls_linea))                                                                                                              
    IF CHARINDEX('+',@ls_linea,1) = 0                                                                                                                                                           
		SELECT @ls_parrafo = SUBSTRING(@ls_linea,1,LEN(@ls_linea))                                                                            
    ELSE                                                                                                                                                                       
		SELECT @ls_parrafo = SUBSTRING(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                                                                                                                                                    
                      
	IF CHARINDEX(':',@ls_parrafo,1) = 0                                                                             
		SELECT @ls_codrecargo = @ls_parrafo                                       
	ELSE                                                                                              
	BEGIN                                                                   
		SELECT @ls_codrecargo = SUBSTRING(@ls_parrafo,1,CHARINDEX(':',@ls_parrafo,1)-1)                                                                                                                                                        
		SELECT @ls_parrafo = SUBSTRING(@ls_parrafo,CHARINDEX(':',@ls_parrafo,1)+1,len(@ls_parrafo))                                                                                           
	END

	IF NOT EXISTS(SELECT CodigoTipoFlete FROM dbo.TipoFlete (NOLOCK) WHERE CodigoEquivalencia = @ls_codrecargo AND EstadoRegistro = 1)
	BEGIN
		PRINT 'Equivalencia de Flete no Existe '+@ls_codrecargo +' para el Documento '+@ls_nrodoc
	END
	ELSE 
	BEGIN
		SELECT @CodigoTipoFlete = ISNULL(CodigoTipoFlete,0) FROM dbo.TipoFlete (NOLOCK) WHERE CodigoEquivalencia = @ls_codrecargo
	END
	                                                                                                                                                                                                       
	IF CHARINDEX(':',@ls_parrafo,1) > 0                                                                                                                                                                                               
	BEGIN                                                                                                                                          
		SELECT @ls_montorecargo = SUBSTRING(@ls_parrafo,1,CHARINDEX(':',@ls_parrafo,1)-1)                                                                                                                                                          
		SELECT @ls_parrafo = SUBSTRING(@ls_parrafo, CHARINDEX(':',@ls_parrafo,1)+1, LEN(@ls_parrafo))                                                                             
	END                                                                                                                       
	IF CHARINDEX(':',@ls_parrafo,1) > 0                                         
    BEGIN                                                                                                                                                               
		SELECT @ls_mondeda = SUBSTRING(@ls_parrafo,1,CHARINDEX(':',@ls_parrafo,1)-1)                                                                                            
		SELECT @ls_parrafo = SUBSTRING(@ls_parrafo, CHARINDEX(':',@ls_parrafo,1)+1, LEN(@ls_parrafo))                                                                                                                              
		
		IF NOT EXISTS(SELECT CodigoMoneda FROM dbo.Moneda (NOLOCK) WHERE CodigoMonedaSunat = @ls_mondeda AND EstadoRegistro = 1)
		BEGIN
			PRINT 'Equivalencia de Moneda no Existe '+@ls_mondeda +' para el Documento '+@ls_nrodoc
		END
		ELSE 
		BEGIN
			SELECT @CodigoMoneda=CodigoMoneda FROM dbo.Moneda (NOLOCK) WHERE CodigoMonedaSunat = @ls_mondeda AND EstadoRegistro = 1
		END           
    END                                                                                                                                                                                                      
    IF CHARINDEX(':',@ls_parrafo,1) > 0                                                                         
    BEGIN                                                                
		SELECT @ls_condpago = SUBSTRING(@ls_parrafo, CHARINDEX(':',@ls_parrafo,1)+1, LEN(@ls_parrafo))

		IF NOT EXISTS(SELECT CodigoModoPago FROM dbo.ModoPago (NOLOCK) WHERE CodigoEquivalencia = @ls_condpago AND EstadoRegistro = 1)
		BEGIN
			SELECT @CodigoModoPago=CodigoModoPago FROM dbo.ModoPago (NOLOCK) WHERE CodigoModoPago = 3 AND EstadoRegistro = 1
		END
		ELSE 
		BEGIN
			SELECT @CodigoModoPago=CodigoModoPago FROM dbo.ModoPago (NOLOCK) WHERE CodigoEquivalencia = @ls_condpago  AND EstadoRegistro = 1
		END                                                                                                                                                                                                       
    END                                                        
                                                                                                                                                                                                                                                                                                                                                   
    /*Valida Recargos Duplicados*/                                                                                                                                                  
    IF EXISTS(SELECT PK_DocumentoFlete FROM @Temporal_DocumentoDetalleFlete WHERE NumeroDocumento = @ls_nrodoc AND CodigoTipoFlete = @CodigoTipoFlete)                                                                                                                                                            
    BEGIN                                                                             
		SELECT @ls_montorecargo=CAST(MontoFlete AS decimal(15,2))+CAST(@ls_montorecargo AS decimal(15,2)) FROM @Temporal_DocumentoDetalleFlete                                                
		WHERE NumeroDocumento = @ls_nrodoc AND CodigoTipoFlete = @CodigoTipoFlete                           
	                                                            
		UPDATE @Temporal_DocumentoDetalleFlete                                                                                                                                                                       
		SET MontoFlete = CAST(@ls_montorecargo AS decimal(15,2))                                                                                              
		WHERE NumeroDocumento = @ls_nrodoc AND CodigoTipoFlete = @CodigoTipoFlete                               
    END                                           
    /*Fin Recargos Duplicados*/              
	ELSE                                                                                  
    BEGIN                                                              
		INSERT @Temporal_DocumentoDetalleFlete                                                                                                                                                    
		(                                                                                                                                                                                                                                                         
		NumeroDocumento,                                                                                                                                                                                                                                                 
		CodigoTipoFlete,                                                                                                              
		CodigoMoneda,                                                                                                                                                              
		CodigoModoPago,                                                                                                             
		MontoFlete                                                                                                                                
		)                                                                               
		VALUES                                                                                  
		(                                                                                                                                                                                                                                                                                                                                 
		@ls_nrodoc,                                                                                                                                                                                                                                                                                             
		@CodigoTipoFlete,                                                                                                                                                                                    
		@CodigoMoneda,                                                                                                        
		@CodigoModoPago,
		CAST(@ls_montorecargo AS decimal(15,2))                                                                                                                                                  
		)                                                                                                                      
	                                         
	  SELECT @CodigoTipoFlete=NULL,                                                                                                                                                                                              
		 @ls_montorecargo=NULL,                                                                               
		 @CodigoMoneda=NULL,                                                                                          
		 @CodigoModoPago=NULL                                                                                                                                                                                  
                                                          
  END                                                                
  SET @ls_segmento_ant = 'MOA'                                                    
 END                                             
                                    
 /************************ LOC+9 / Puerto de Embarque ****************************/                                                                                                        
IF @ls_linea LIKE 'LOC+9%'                                                                                  
BEGIN                                                                                                                                                                                       
	SET @CodigoPuertoEmbarque = NULL                                                                                                                          
	SET @NomPto = ''                                                                                                                               
	SELECT @ls_linea = SUBSTRING(@ls_linea,5,LEN(@ls_linea))                                                                                                                                     
                                                                                             
	IF CHARINDEX('+',@ls_linea,1) > 0                                                                                                                             
	BEGIN                                                                                                                                                                              
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@LS_LINEA,1)+1,LEN(@ls_linea))                                                                                                                                                                       
	                                                                            
		IF CHARINDEX(':',@ls_linea,1) = 0                                                                                 
		BEGIN                                                                                                                 
			SELECT @ls_ptoemb = @ls_linea                                                                                                                                 
		END                                                                                                                           
		ELSE                                                     
		BEGIN                                 
			SELECT @ls_ptoemb = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                                                                                                                                                      
		END                                                                                                                                                                             
	                                           
		/*Busca Nombre de Puerto*/                                                                                                                                                                               
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                                                         
	  
		IF (CHARINDEX(':',@ls_linea,1) = 0)                                                         
		BEGIN                                                                                                                             
			SELECT @NomPto = @ls_linea                                                                                                                                                                     
		END                   
		
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                            
	    
		IF (CHARINDEX(':',@ls_linea,1) = 0)                                                     
		BEGIN                                                                                                            
			SELECT @NomPto = @ls_linea                                                                              
		END                                                                                 
		ELSE                                                                                      
		BEGIN                                                                                         
			SELECT @NomPto= SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                
		END                                                                                                                                                                                     
	  /*Busca Nombre de Puerto*/                                                                                                                                                                         
	END

	IF NOT EXISTS(SELECT CodigoPuerto FROM dbo.Puerto (NOLOCK) WHERE CodigoPuertoSunat = @ls_ptoemb AND EstadoRegistro = 1)
	BEGIN
		PRINT 'Puerto Embarque no registrado '+@ls_ptoemb+ ' - '+@NomPto                    
	END
	ELSE
	BEGIN
		SELECT @CodigoPuertoEmbarque = CodigoPuerto FROM dbo.Puerto (NOLOCK) WHERE CodigoPuertoSunat = @ls_ptoemb AND EstadoRegistro = 1                 
	END
                                                                                                                                                                                
	SET @ls_segmento_ant = 'LOC+9'                                                                                                                                                                                           
END                                                                                          
                                                                       
/************************ LOC+11 / Puerto de Descarga ****************************/                                                                            
 IF @ls_linea LIKE 'LOC+11%'                                                                                           
 BEGIN      
  SET @CodigoPuertoDescarga = NULL                                                
  SET @NomPto = ''                                                                                                                                                        
  select @ls_linea = SUBSTRING(@ls_linea,5,LEN(@ls_linea))                                                                                                                                                                                                    
                                                                                                       
  IF CHARINDEX('+',@ls_linea,1) > 0                                                                                                                                                                                                              
  BEGIN                                                                                            
  SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@LS_LINEA,1)+1,LEN(@ls_linea))                                                                                                             
                                                                                   
  IF CHARINDEX(':',@ls_linea,1) = 0                                          
    BEGIN                                                                                                                                
		SELECT @ls_ptodes = @ls_linea                                     
    END                                                                                                  
   ELSE                                                                                                                                                                                   
   BEGIN                                                                                                                                                                            
		SELECT @ls_ptodes = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                                                          
   END                                                                                                                                                                                       
                                                         
      /*Busca Nombre de Puerto*/                                                                          
   SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                                                         
                               
   IF (CHARINDEX(':',@ls_linea,1) = 0)                                                                                     
      BEGIN                        
         SELECT @NomPto = @ls_linea                                                                     
	  END                                                                                                                                      
   SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                  
   IF (CHARINDEX(':',@ls_linea,1) = 0)                                                                                                                                                                    
      BEGIN                                                                 
         SELECT @NomPto = @ls_linea                                                                                                                                                  
	  END                                                                                           
      ELSE                                                                                            
      BEGIN                                                                                                                                 
         SELECT @NomPto= SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                                                     
      END                                                                                                                                                                                      
    /*Busca Nombre de Puerto*/                                                                    
                                                                                                                          
  END                                    
	IF NOT EXISTS(SELECT CodigoPuerto FROM dbo.Puerto (NOLOCK) WHERE CodigoPuertoSunat = @ls_ptodes AND EstadoRegistro = 1)
	BEGIN
		PRINT 'Puerto Descarga no registrado '+@ls_ptodes+ ' - '+@NomPto                    
	END
	ELSE
	BEGIN
		SELECT @CodigoPuertoDescarga = CodigoPuerto FROM dbo.Puerto (NOLOCK) WHERE CodigoPuertoSunat = @ls_ptodes AND EstadoRegistro = 1                 
	END                                  
                                                                                 
 SET @ls_segmento_ant = 'LOC+11'                                                                                                                                                                                 
 END                                                                        
                                                                                                                                     
/************************ LOC+88 / Puerto de Origen ****************************/                                                                                                                 
 If @ls_linea LIKE 'LOC+88%'                                                
 BEGIN                                                                                                                                                                        
  select @ls_linea = SUBSTRING(@ls_linea,5,LEN(@ls_linea))                                                                                                                                                                                                   
  SET @CodigoPuertoOrigen = NULL                                                                    
  SET @NomPto = ''  
                                                                                    
  if CHARINDEX('+',@ls_linea,1) > 0                                  
  BEGIN                                                                                                                                                                                    
    
  select @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@LS_LINEA,1)+1,LEN(@ls_linea))                                                                                                 
                                                                
   if CHARINDEX(':',@ls_linea,1) = 0                                                                                                                                                  
   BEGIN                                                                                                                              
    select @ls_ptoori = @ls_linea       
   END                                                                                                 
   else                                                                                                             
   BEGIN                                                                                                  
    select @ls_ptoori = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                                              
   END                                                                       
                                                                                            
       /*Busca Nombre de Puerto*/                                                                                                   
   SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                                                         
                                 
   IF (CHARINDEX(':',@ls_linea,1) = 0)                                                                  
 BEGIN                                                                               
         select @NomPto = @ls_linea                                                                                            
      END                           
   SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                            
    IF (CHARINDEX(':',@ls_linea,1) = 0)                                                                                                                                                                     
      BEGIN                                                                                                                                                              
         SELECT @NomPto = @ls_linea                                                                          
      END                                               
      ELSE                                                                                                                                                                               
      BEGIN                                                                       
         SELECT @NomPto= SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                                                             
      END                                                                                                                                             
    /*Busca Nombre de Puerto*/                                                                                                             
END                                                                                                                                                     
    
	IF NOT EXISTS(SELECT CodigoPuerto FROM dbo.Puerto (NOLOCK) WHERE CodigoPuertoSunat = @ls_ptoori AND EstadoRegistro = 1)
	BEGIN
		PRINT 'Puerto Origen no registrado '+@ls_ptoori+ ' - '+@NomPto                    
	END
	ELSE
	BEGIN
		SELECT @CodigoPuertoOrigen = CodigoPuerto FROM dbo.Puerto (NOLOCK) WHERE CodigoPuertoSunat = @ls_ptoori AND EstadoRegistro = 1                 
	END                                                
                                                                                                                               
  SET @ls_segmento_ant = 'LOC+88'                                                                                                                                                                                                   
END                               
                                                                                                                                  
  /************************ LOC+7 / Place of delivery (Puerto de Destino Final) ****************************/                                                                 
                            
 If @ls_linea LIKE 'LOC+7%'                                     
 BEGIN                  
 SET @CodigoPuertoFinal = NULL                                                                                         
 SET @NomPto = ''                                                                                
  SELECT @ls_linea = SUBSTRING(@ls_linea,5,LEN(@ls_linea))                                                                                                 
                                                                       
  if CHARINDEX('+',@ls_linea,1) > 0                                                     
 BEGIN                                                                                                                                                                   
  select @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@LS_LINEA,1)+1,LEN(@ls_linea))                                                                                                                           
                                                                                          
   if CHARINDEX(':',@ls_linea,1) = 0                                                                                                                       
   BEGIN                                                                                                                                                                     
		SELECT @ls_ptofin = @ls_linea                                                                                          
   END                                                                                                                                                                           
   else                                                                   
   BEGIN                                                      
    select @ls_ptofin = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                                                                                             
   END                             
       /*Busca Nombre de Puerto*/                                                                                                          
   SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                           
                                           
   IF (CHARINDEX(':',@ls_linea,1) = 0)                                                                                                                            
      BEGIN                                                                                                                                                                                       
         select @NomPto = @ls_linea                               
      END                                                            
   SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                                                         
 
   
    IF (CHARINDEX(':',@ls_linea,1) = 0)                                                                                                                                                
      BEGIN                                                                                                                       
   SELECT @NomPto = @ls_linea                                                                                                                               
      END                                                                                                                         
      ELSE                                                                                                                                                            
      BEGIN     
         SELECT @NomPto= SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                                                      
      END                                                                                             
      /*Busca Nombre de Puerto*/                                                                                
                                        
 END                                                                            

	IF NOT EXISTS(SELECT CodigoPuerto FROM dbo.Puerto (NOLOCK) WHERE CodigoPuertoSunat = @ls_ptofin AND EstadoRegistro = 1)
	BEGIN
		PRINT 'Puerto Final no registrado '+@ls_ptofin+ ' - '+@NomPto                    
	END
	ELSE
	BEGIN
		SELECT @CodigoPuertoFinal = CodigoPuerto FROM dbo.Puerto (NOLOCK) WHERE CodigoPuertoSunat = @ls_ptofin AND EstadoRegistro = 1                 
	END
	        
 SET @ls_segmento_ant = 'LOC+7'                                                                                                                       
 END                                                                                                                         
                                                                                                                                                                                     
/************************ Clientes del Documento****************************/                                         
                                                                                                                                                                                                                                                                     
IF (@ls_linea LIKE 'NAD%' OR @ls_linea LIKE 'RFF+AHP%')
BEGIN  
	IF (@ls_linea LIKE 'NAD%')
	BEGIN                                                                                                                                                                                                            
		SELECT @ls_linea = SUBSTRING(@ls_linea,5, LEN(@ls_linea))                                                                                                                                                               
		SELECT @ls_rolcliente= SUBSTRING(@ls_linea,1, CHARINDEX('+',@ls_linea,1)-1)                                                                  
                                                                                                          
	--IF CHARINDEX('+',@ls_linea,1)>0                                                                                                                                                                         
	--	SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                                                                                                                           
                                                                                                                        
	--IF CHARINDEX('+',@ls_linea,1)>0                                                                                                 
	--	SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                             
    
 --   IF @ls_rolcliente = 'CN'                                                                                                            
 --   BEGIN                                              
	--	SET  @p_BloqueConsig=@p_BloqueConsig + 'NAD-'+@ls_rolcliente+'-'                            
                                                                                                                                                                                                                                                                  
	--	  IF CHARINDEX('+',@ls_linea,1)=0                                                      
	--	  BEGIN                                                                                                                                                                 
	--		IF CHARINDEX(':',@ls_linea,1) > 0                                                                 
	--		BEGIN                                                                                        
	--			SELECT @Consig = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                                                                 
	--			SELECT @DirConsig = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                            
	--		END                                                                                                                                                                         
	--	  ELSE                                                                                                      
	--	  BEGIN                                                                                        
	--		SELECT @Consig = @ls_linea                                                                                                                                                                              
	--		SELECT @DirConsig = ''                                                                                                                                                                             
	--	  END                                                                                                                                                                                                            
	--	 END                                                                                               
	                                                 
	--	 IF CHARINDEX('+',@ls_linea,1) > 0                                                                                                                                      
	--	 BEGIN                                                             
	--	 IF CHARINDEX(':',@ls_linea,1) > 0                                                              
	--	 BEGIN                                     
	--		SELECT @Consig = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                                             
	--		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                               
	--		SELECT @DirConsig = SUBSTRING(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                
	--	 END                  
	--	 ELSE                                                                                                                              
	--	 BEGIN                                                                                                                                                                   
	--		SELECT @Consig = @ls_linea                                                                                                                                                     
	--		SELECT @DirConsig=''                                                                          
	--	 END                                                                                                                          
	--	END                                                                                                                                                                                                                                  
	--END                                                                                 
                                                                                                
 --  IF @ls_rolcliente = 'N1'                                                                                                     
 --  BEGIN
	--	SET @p_BloqueRoles='NAD-'+@ls_rolcliente+'-' 
	--	SET @ls_rolcliente='NI'                                                                                                                                                                                                                                                                                          
                                                                                    
	--IF CHARINDEX('+',@ls_linea,1)=0                         
	--BEGIN                                                                                                
 --   IF CHARINDEX(':',@ls_linea,1) > 0                                                                                                                                                                               
 --   BEGIN                                 
	--	SELECT @Noti1 = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                                                                                                                                                    
	--	SELECT @DirNoti1 = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                           
 --   END                                                                                                                 
 --   ELSE                                                                                                                                                                              
 --   BEGIN                                                                                                      
 --      SELECT @Noti1 = @ls_linea                                      
 --      SELECT @DirNoti1 = ''                                                                                                                                 
 --   END                                                                                                                                                                                                            
 --   END                                                                                      
                                                    
 --     IF CHARINDEX('+',@ls_linea,1) > 0                     
 --      BEGIN                                                                     
	--	   IF CHARINDEX(':',@ls_linea,1) > 0                                                                                                                                                                               
	--	   BEGIN                                                                                                       
	--		   SELECT @Noti1 = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                                                
	--					  SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                             
	--					  SELECT @DirNoti1 = SUBSTRING(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                                                                                                                           
	--	   END                                              
	--		 ELSE                                                                                                                                                                              
	--	   BEGIN                                                                                       
	--		  SELECT @Noti1 = @ls_linea                                                                                                                            
	--		  SELECT @DirNoti1=''                                                                 
	--	   END                                                                                        
	--   END                                                                                                                                                                                                                           
	--END                    
                                                                                                            

 --   IF @ls_rolcliente = 'CZ'                                                                            
 --   BEGIN     
	--	SET @p_BloqueRoles= 'NAD-'+@ls_rolcliente+'-' 
	--	SET @ls_rolcliente='SF'                                                                                                                                                                                                                                                                           
                                                                                                                                                                                                 
 --   IF CHARINDEX('+',@ls_linea,1)=0                                                                                                                                      
	--BEGIN                                                                                             
 --   IF CHARINDEX(':',@ls_linea,1) > 0                                                                                                    
 --   BEGIN                                                                                                                                                                            
 --      SELECT @Exportador = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                                                
 --      SELECT @DirExportador = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                
 --   END                                                                                                                       
 --   ELSE                                                         
 --   BEGIN                                                                                                                                                       
 --      SELECT @Exportador = @ls_linea                                         
 --      SELECT @DirExportador = ''                                                                                                                                                                              
 --   END                                                                                                              
 --   END                                                                                                                                         
                                              
 -- IF CHARINDEX('+',@ls_linea,1) > 0                                                                                                                                   
 --      BEGIN                                                                                                                                                         
 --      IF CHARINDEX(':',@ls_linea,1) > 0                                                                                                                                                                               
	--   BEGIN                                                        
 --                 SELECT @Exportador = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                       
 --                 SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                                         
 --                 SELECT @DirExportador = SUBSTRING(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                                                                                
	--   END                                                                                                                                               
 --        ELSE                                                                                                                                                                        
	--  BEGIN                
	--   SELECT @Exportador = @ls_linea                                                                                   
	--   SELECT @DirExportador = ''                                                                                                                       
	--  END                                                                                                                                      
	--END                                                                                                                                                                            
 --END   
                                                                                                                                                                                                                                                                                                                                                                         
 SET @RolClienteRUC = @ls_rolcliente                                                             
 SET @ls_rolcliente=NULL 
 SET @CodigoRol=NULL                                                                
                                                                                           
  SELECT @ls_segmento_ant = 'NAD'                                                                                                                      
END
 
---------RUC DEL CLIENTE-----------
	 IF @ls_linea LIKE 'RFF+AHP%'      
	 BEGIN    
	 SET  @p_BloqueConsig=@p_BloqueConsig + 'RFF+AHP-'     
	 SELECT @RUC = SUBSTRING(@ls_linea,9,11)  
	 
		 IF @RUC = '' AND @RolClienteRUC = 'CN' AND @CodigoTipoOperacion = 1 -- 1: Importacion 
			AND @CodigoPuertoDescarga IN (SELECT CodigoPuerto FROM dbo.Puerto (NOLOCK) WHERE CodigoPais = 174) -- Peru (174) 
			AND @CodigoPuertoFinal IN (SELECT CodigoPuerto FROM dbo.Puerto (NOLOCK) WHERE CodigoPais = 174)
		 BEGIN 
			SET @EstadoRUC = 1
			PRINT 'RUC en Blanco para el Consignatario para el Documento '+@ls_nrodoc                                         
		 END
		  
		 IF ((LEN(@RUC) <> 11 AND LEN(@RUC) > 0) OR (ISNUMERIC(@RUC)<>1 AND LEN(@RUC) > 0)) AND @RolClienteRUC = 'CN' AND @RegimenHALO_BL = 'I' 
			AND @CodigoPuertoDescarga IN (SELECT CodigoPuerto FROM dbo.Puerto (NOLOCK) WHERE CodigoPais = 174) -- Peru (174) 
			AND @CodigoPuertoFinal IN (SELECT CodigoPuerto FROM dbo.Puerto (NOLOCK) WHERE CodigoPais = 174)
		 BEGIN 
			SET @EstadoRUC = 1
			PRINT 'RUC Incorrecto para el Consignatario para el Documento '+@ls_nrodoc                                                                                                                                                                                                                         
		 END 
     
       IF @EstadoRUC = 0
       BEGIN
	   SELECT @CodigoRol=CodigoRol FROM dbo.Rol (NOLOCK) WHERE CodigoEquivalencia=@RolClienteRUC
	   SELECT @CodigoPersona=p.CodigoPersona FROM dbo.Persona p (NOLOCK) WHERE NumeroDocumentoPersona = @RUC
                                                         
	   INSERT @Temporal_DocumentoDetalleCliente                                                                                              
	   (                                                                                                                                      
		NumeroDocumento,                                                                                                                                                                                
		CodigoRol, 
		CodigoPersona                                                                                                              
	   )                                                                     
	   VALUES                                                                                                                                                                                        
	   (                                                                                                                                                                             
	   @ls_nrodoc,                                                                                                                                                                                                
	   @CodigoRol,
	   @CodigoPersona                                                                              
	   )                                                                         
	  
	   END    
	SET @RolClienteRUC = NULL      
	      
	END                                                                                                               
END                                                                                                                                              
                                                                                                        
  /************************ DTM - Fecha de Embarque del BL  ****************************/                                                           
                                         
IF @ls_linea LIKE 'DTM+136%'                                                                                                                                                  
BEGIN                                                                                                    
	SELECT @ls_linea = SUBSTRING(@ls_linea,8,LEN(@ls_linea))                                                                     
                   
	IF CHARINDEX(':',@ls_linea,1) > 0                                                                                                               
	BEGIN                                                                         
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                          
                                                                                                                                                                       
	IF CHARINDEX(':',@ls_linea,1) = 0                                                
		SELECT @FechaEmbarqueBL = @ls_linea                                                                                                                                                                                      
	ELSE                                                                                                     
		SELECT @FechaEmbarqueBL = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                                                                              
	END                                                                                                
                                                                                                                            
	IF ISNULL(@FechaEmbarqueBL,'')=''                                                                                                                                               
    BEGIN                                               
		PRINT 'En el Segmento DTM+136 No esta enviando Fecha Embarque del BL '+@ls_nrodoc                                                                                         
    END                                                                                                                        
                                                                                                                         
    IF ISDATE(@FechaEmbarqueBL)<>1                                                                                
    BEGIN                                                       
		PRINT 'La Fecha de Embarque: '+@FechaEmbarqueBL+ ' no tiene Formato Fecha '+@ls_nrodoc                                                                                                                                                                                                                      
		SET @FechaEmbarqueBL = ''                                                                                                                          
    END                                                                                                                                                                                                 
                                                                                                       
	SELECT @ls_segmento_ant = 'DTM+136'                                                                                  
END                                                
                                                                                
   /************************ DTM - Fecha de Emision del BL  ****************************/                                                                                                                                              
IF @ls_linea LIKE 'DTM+182%'                                                                                                                                                                                                           
BEGIN                                                                                                                                                                                                             
	SELECT @ls_linea = SUBSTRING(@ls_linea,8,LEN(@ls_linea))                                                                                
                                                          
	IF CHARINDEX(':',@ls_linea,1) > 0                                           
	BEGIN                                                                                                
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                    
	                                                                                                          
		IF CHARINDEX(':',@ls_linea,1) = 0                                                                                                                                  
			SELECT @FechaEmisionBL = @ls_linea                                                                                                                              
		ELSE                                                                                                                                                                                                              
			SELECT @FechaEmisionBL = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                  
	                                                                            
		IF ISNULL(@FechaEmisionBL,'')=''                                                             
		BEGIN                                 
			PRINT 'En el Segmento DTM+182 No esta enviando Fecha Emision '+@ls_nrodoc                                                                                                                                                                                                                                                            
		END                                                                                     
	                                            
		IF ISDATE(@FechaEmisionBL)<>1                                                                                                                                          
		BEGIN                                                                                                                                    
			PRINT 'La Fecha de Emision: ' +@FechaEmisionBL+ ' no tiene Formato Fecha '+@ls_nrodoc                                                                                                                                                 
			SET @FechaEmisionBL = ''                                                                                                                                 
		END                                	                                                                                                                                                                                                                                                                    
	END                                                                                                                               
                                                                                                                                                                          
/*Inserto @Temporal_Documento, asegurandome que siempre haya Fecha de Emision*/   
-- SELECT * FROM dbo.Documento d                                                                                                       
  INSERT @Temporal_Documento                                                                                                                                                                                                       
	(                                                                                                                                                                                                                                                                                                                                                                                                               
	 CodigoPuertoOrigenDocumento,                                                                                                                                                            
	 CodigoPuertoEmbarqueDocumento,                                                                                                     
	 CodigoPuertoDescargaDocumento,                                                                                                                                                                     
	 CodigoPuertoFinalDocumento,                                                                                                                                           
	 CodigoAduana, 
	 CodigoTipoBL, 
	 CodigoTipoEnvio, 
	 CodigoCondicionContrato, 
	 CodigoRequerimientoServicio, 
	 NumeroDocumento, 
	 FechaEmisionDocumento,                                                                                                                                                    
	 FechaEmbarqueDocumento                                                                                                               
	)                                                                                                                                    
  VALUES                                                                   
  (                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
	@CodigoPuertoOrigen,                                                                                                                                                            
	@CodigoPuertoEmbarque,                                                                                                     
	@CodigoPuertoDescarga,                                                                                                                                                                     
	@CodigoPuertoFinal,                                                                                                                                           
	@CodigoAduana, 
	1,-- 1: 705 Bill of Lading -- CodigoTipoBL, Por Defecto BL
	@CodigoTipoOperacion,--CodigoTipoEnvio, 
	3,-- CodigoCondicionContrato 3: -- 99: Sin Condicion Contrato, No envian este Dato. 
	61, --CodigoRequerimientoServicio,-- 61	-- 99: Sin Requerimiento Servicio, No envian este Dato. 
	@ls_nrodoc, 
	@FechaEmisionBL,                                                                                                                                                    
	@FechaEmbarqueBL                                                                                          
  )                                                                                                                                                  
                                    
  SELECT 
   @CodigoPuertoOrigen=NULL,
   @CodigoPuertoEmbarque=NULL,
   @CodigoPuertoDescarga=NULL,
   @CodigoPuertoFinal=NULL,
   @Consig=NULL,                                                                                                                                                                    
   @DirConsig=NULL,                                                                                                                                
   @ls_ConsigHALO=NULL,                                                                                     
   @Noti1=NULL,                                                                                      
   @DirNoti1=NULL,                                           
   @ls_Noti1HALO=NULL,                                                                                                                                                                                                                                                                                                           
   @Exportador=NULL,                                                                                                                                                                      
   @DirExportador=NULL,                                                                                       
   @ls_EmbarHALO=NULL,                                                                                                                    
   @Market=NULL,                                                            
   @DirMarket=NULL,                                                                                                                 
   @ls_MarketHALO=NULL,                                                                            
   @FechaEmisionBL=NULL,                                                                                                            
   @FechaEmbarqueBL=NULL,                                                                                                                                                      
   @Codeyc_cn = NULL,                                                                                                                  
   @Codeyc_n1 = NULL,                                                                                                                                                                                                                 
   @Codeyc_cz = NULL                                                                                                                                                                                                
                                                                                                                                                                           
  SELECT @ls_segmento_ant = 'DTM+182'                                                                                                                                                                                        
                                                                                                                            
END                                                 
                                                        
/************************ GID - Item ,Bultos del CTN y Unidad Basica de Carga x BL   ****************************/                                                                                                                             
IF @ls_linea like 'GID%'                                                                                                   
BEGIN                                                                                                 
	SELECT @ls_linea = SUBSTRING(@ls_linea,5,LEN(@ls_linea))                                                                                                                                                         
	SELECT @ItmCtn =  SUBSTRING(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                                                                    
	IF CHARINDEX('+',@ls_linea,1) > 0                                                                                                                     
	BEGIN                                                                                                                    
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                        
	IF CHARINDEX(':',@ls_linea,1) = 0                                                 
		SELECT @CanBul = @ls_linea                     
	ELSE                                
		SELECT @CanBul = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                             
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                       
	END                                                                                                                                                                                                      
    
    IF CHARINDEX(':',@ls_linea,1) = 0                                                                                                                                          
    BEGIN                                                                                                  
		SELECT @UnidadBasicaCarga = @ls_linea                                                          
    END                                                                       
	ELSE                                                                    
	BEGIN                                                                                                   
		SELECT @UnidadBasicaCarga = SUBSTRING(@ls_linea,1,CHARINDEX(':',@ls_linea,1)-1)                                                                                           
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX(':',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                         
	END                                                                                                                                                       
                                                        
	SET @isctnvacio=''                                                                                                   
	SET @isctnvacio= substring(@ls_linea,2,len(@ls_linea))                                                            
                                                                                                                                    
	IF NOT EXISTS(SELECT CodigoUnidadMercancia FROM dbo.UnidadMercancia (NOLOCK) WHERE CodigoUnidadMercanciaSunat = @UnidadBasicaCarga) 
	 AND (@isctnvacio NOT LIKE '%EMPTY CONTAINER%')               
	BEGIN                                               
		PRINT 'En el Segmento GID No se esta enviando Unidad de Mercancia de la Carga'                                                                                                                                                                                                                                                                                                                  
    END 
	ELSE
	BEGIN 
		SELECT @CodigoUnidadMercancia=CodigoUnidadMercancia FROM dbo.UnidadMercancia (NOLOCK) WHERE CodigoUnidadMercanciaSunat = @UnidadBasicaCarga    
	END                                                                                                                                                                                                                                                                                                                                                                                                                    
                                                                                
  SELECT @ls_segmento_ant = 'GID'                                                                                                                                                                                                                                  
 END                                   
                                                                                       
/************************ FTX 1 - Descripcion de la Mercaderia por CTN  ****************************/                                                                                                                                                           
IF @ls_linea like 'FTX%'                                 
BEGIN                                                                                 
	SELECT @ls_linea = SUBSTRING(@ls_linea,5,LEN(@ls_linea))                                                                                                 
                                                                                                                                                                                                           
	IF CHARINDEX('+',@ls_linea,1) > 0                                        
	BEGIN                                                                                                                                                                                                          
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                         
                                                                                                                          
	IF CHARINDEX('+',@ls_linea,1) > 0                                                                                                                             
	BEGIN                                                                                                                                                       
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                           
	IF CHARINDEX('+',@ls_linea,1) > 0                                                                                                  
	BEGIN                               
	
	IF ISNULL(@DescripcionMercaderia,'')=''                                                                                                                                   
	BEGIN                                                                                                                    
		SET @DescripcionMercaderia = ''                                                                                           
	END                                                                                                                                                                                                
                                                                                                                                                                
/*Algoritmo para partir contenedores con descripcion larga*/                                       
	                                                                                   
	SET @DescripcionMercaderia = @DescripcionMercaderia  + (SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea)))                                                                                                               
                                            
   END                                                                                                    
  END                                                                                                                                                    
 END                                                       
	SELECT @ls_segmento_ant = 'FTX'                                                                       
END                                                                                                              
                                                                                                                  
  /************************ MEA PESO CARGA FISICA****************************/                                                                                                                                                                                 
                        
IF @ls_linea like 'MEA+AAY+G%'                                                                                                       
BEGIN                                                                                                                                            
	SELECT @ls_linea = SUBSTRING(@ls_linea,5, LEN(@ls_linea))                                                                                                                                
                                                                                      
	IF CHARINDEX('+',@ls_linea,1)>0                                                                                                                             
	SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                            
	BEGIN                                                                
	IF CHARINDEX('+',@ls_linea,1)>0                                                                                                                                            
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                        
                                                                                                         
	IF CHARINDEX('+',@ls_linea,1)=0                                                
		SELECT @ls_parrafo = @ls_linea                                                
	ELSE                                                                                                                                                 
		SELECT @ls_parrafo = substring(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                                                                                                                                                                 
	BEGIN                                                                        
    IF CHARINDEX(':',@ls_parrafo,1) > 0                                                                                         
    BEGIN                                                                                                                                                                                                   
		SELECT @ls_parrafo = SUBSTRING(@ls_parrafo,CHARINDEX(':',@ls_parrafo,1)+1, LEN(@ls_parrafo))                                                                                                                                                   
    IF CHARINDEX(':',@ls_parrafo,1) = 0                            
		SELECT @ls_peso_carga2 = @ls_parrafo                                                                                                                          
    ELSE                                                                                           
		SELECT @ls_peso_carga2 = SUBSTRING(@ls_parrafo,1,CHARINDEX(':',@ls_parrafo,1)-1)                                                                                                                       
    END                                                                             
   END                                                                                         
  END                                                                               
/* Codigo Anterior */                                                                                                                                                    
	SELECT @ls_segmento_ant = 'MEA+AAY+G'                                                                                                                                                                              
END                                                                                                                                                                                               
                                                                                                                                    
   /************************ MEA VOLUMEN DEL CONTENEDOR ****************************/                                                                                                                  
IF @ls_linea like 'MEA+VOL+AAW%'                                                             
BEGIN                                                                            
	SELECT @ls_linea = SUBSTRING(@ls_linea,5, LEN(@ls_linea))                                                                  
                                                                                                                                                                                              
	IF CHARINDEX('+',@ls_linea,1)>0                                                                                                         
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                           
	BEGIN                                                                                                                        
	IF CHARINDEX('+',@ls_linea,1)>0                          
		SELECT @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                 
                                                                                                                                                       
	IF CHARINDEX('+',@ls_linea,1)=0                                                                                
		SELECT @ls_parrafo = @ls_linea                                                                                                                           
	ELSE                                                                                                  
		SELECT @ls_parrafo = substring(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                                                                                  
	BEGIN                                                              
    
    IF CHARINDEX(':',@ls_parrafo,1) > 0                                                                                                                                          
    BEGIN                                                                                                                                                                                                              
		SELECT @ls_parrafo = SUBSTRING(@ls_parrafo,CHARINDEX(':',@ls_parrafo,1)+1, LEN(@ls_parrafo))                                                                                                                             
                                      
    IF CHARINDEX(':',@ls_parrafo,1) = 0                                                                                               
		SELECT @ls_volumenctn = @ls_parrafo                                                                                                                                                 
	ELSE                                                                  
        SELECT @ls_volumenctn = SUBSTRING(@ls_parrafo,1,CHARINDEX(':',@ls_parrafo,1)-1)                                                                                       
    END                                                                                                                                                          
   END                                                               
  END                                                                                                                                                                                                                                  
/* Codigo Anterior */                     
	SELECT @ls_segmento_ant = 'MEA+VOL+AAW'                                                                                                                                               
END                                                                                                  
                                                                                                                                         
/************************ SGP - Numero de Contenedor  ****************************/                                                                                
                             
IF @ls_linea like 'SGP%'                                                                           
BEGIN                                                                                                                                                                                
	SELECT @ls_linea = SUBSTRING(@ls_linea,5,LEN(@ls_linea))                                                                                                                                                                          
	IF CHARINDEX('+',@ls_linea,1) = 0                                                                             
	BEGIN                                                                                                                  
		SELECT @ContenedorBL = SUBSTRING(@ls_linea,1,LEN(@ls_linea))   
	END                                                                                                                      
	ELSE                                                                                                                                                                                      
	BEGIN                                                                                                                                    
		SELECT @NumPaquetesCtn = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                  
	END                                                      

	IF @isctnvacio=':EMPTY CONTAINERS'                                                                                                                                                                   
	BEGIN                                                                                                                    
		SET @ContenedorBL=SUBSTRING(@ls_linea,1,LEN(@ls_linea)-2)                                                                                     
		-- Inserta en SGP cuando son Contenedores Vacios                                                                            
	  INSERT @Temporal_DocumentoDetalleCarga (                                                                                                           
		NumeroDocumento,                                                                                                                                                                                                                                                                                                            
		NumeroContenedor,  
		CodigoCondicionTransporte,
		CodigoTipoMovimiento,
		CodigoUnidadMercancia,
		CodigoNaturalezaCarga,
		CodigoCondicionCarga,
		CodigoTemperatura,
		CodigoClaseIMO,
		CodigoNumeroIMO,
		CodigoAlmacen,
		CodigoDeposito,
		CodigoPrecinto,                                                                                                                                                                                                   
		ItemDocumento,
		CantidadBulto,                                                                                                                                                                                                                                                                                                                                                                                                                                     
		PesoBruto,                                                                                                               
		VolumenBruto, 
		TemperaturaMinima,                                              
		TemperaturaMaxima,
		Propietario,
		Observacion,
		DescripcionMercaderia,                                                                                                                                      
		MarcasNumeros, 
		Falto                                                                                                                                
	)                                                        
	   VALUES(                                                                                                                                                                              
	   @ls_nrodoc,                                                                                                                                                                                                                                                                                      
	   @ContenedorBL,                                                                                                                                                                                               
	   NULL, -- CodigoCondicionTransporte, esta en Containers
	   4, -- CodigoTipoMovimiento, sera 4 (FCL/LCL)  
	   @CodigoUnidadMercancia, 
	   6, -- CodigoNaturalezaCarga, sera 6 (Contenerizada)      
	   4, -- CodigoCondicionCarga, sera 4 (Carga General)
	   NULL, -- CodigoTemperatura, esta en Containers (hay que trar del FK)
	   NULL, -- CodigoClaseIMO, Los Vacios no tiene IMO,
	   NULL, -- CodigoNumeroIMO, Los Vacios no tiene IMO,
	   NULL, -- CodigoAlmacen, Por Definir	                                                                                                                                                        
	   NULL, -- CodigoDeposito, Por Definir,
	   NULL, -- CodigoPrecinto, esta en Containers,
	   CAST(@ItmCtn AS int),                                                                                                                                                                      
	   1, -- CantidadBulto, Por ser Vacio se envia 1   
	   0, -- PesoBruto, Por ser Vacio se envia 0                                                                                
	   0, -- VolumenBruto, Por ser Vacio se envia 0  
	   NULL, -- TemperaturaMinima, esta en Containers                                                                                                                     
	   NULL, -- TemperaturaMaxima, esta en Containers
	   NULL, -- Propietario, esta en Containers
	   NULL, -- Observacion, no Tiene Observacion
	   'EMPTY CONTAINER', -- DescripcionMercaderia, por ser Vacio
	   'SMyN',-- MarcasNumeros, Sin Marcas y Numeros por ser Vacio 
	   0 -- Falto, 0: No es Falto                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
	 )                                                  
	 /*Limpio Variables*/                                                                                                                                                                                
	  SELECT                                                                                                                          
		--@ls_nrodoc = NULL,                                                                                         
		--@ls_nrobooking = NULL,                                
	   @ContenedorBL= NULL,                                                                                                                
	   @UnidadBasicaCarga= NULL,                                                                                                                                                                                                 
	   @ItmCtn= NULL,                                                                                       
	   @CanBul= NULL,                                                                                                                                                                                                  
	   @CodUBCHawk= NULL,                                                
	   @ls_peso_carga2= NULL,                                                                                                                                                                                     
	   @DescripcionMercaderia= NULL,                                                                 
	   @MarcasyNumeros= NULL,                                                                                          
	   @ls_regimen= NULL,                                                                                       
	   @ls_condicion= NULL,                                                                                                            
	   @ls_condicion= NULL,                                       
	   @ClaseImo = NULL,                                                                     
	   @NroImo = NULL,                                       
	   @ls_volumenctn = NULL,
	   @CodigoCondicionTransporte = NULL,
	   @CodigoUnidadMercancia=NULL,
	   @CodigoClaseIMO=NULL,
	   @CodigoNumeroIMO=NULL                                                                              
	  END                                                                                          
                                                                                                                         
  SET  @p_Bloques= @p_Bloques +'SGP-'                                                                              
  SELECT @ls_segmento_ant = 'SGP'                                                                                                                                                                                   
 END                                                               
                                                                  
  /************************ DGS - IMO - Indicador de Peligrosidad  ****************************/                                                                                                                                     
 IF @ls_linea like 'DGS+IMD%'                                                                         
 BEGIN                                                                                                                                                      
  select @ls_linea = SUBSTRING(@ls_linea,5, LEN(@ls_linea))                                                                                                           
                                                                                                                                                  
  if CHARINDEX('+',@ls_linea,1)>0                                                                                                                                                                         
  BEGIN                                               
   select @ls_linea = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                          
                                                                                                         
   if CHARINDEX('+',@ls_linea,1)>0                                                                                                                                  
    BEGIN                                                           
  select @ClaseImo = SUBSTRING(@ls_linea,1,CHARINDEX('+',@ls_linea,1)-1)                                                                                                                                
 END                                                                              
   ELSE                                                                                                                                
 BEGIN                                                                                              
  select @ClaseImo = SUBSTRING(@ls_linea,1,LEN(@ls_linea))                                                                                                                 
 END                                                                                                                                
                                                                                                                      
    if CHARINDEX('+',@ls_linea,1)>0                                                                                              
    BEGIN                                                                 
  select @NroImo = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                     
                 
    END                                                                        
  END   
                                        
-- SI EL IMO NO EXISTE EN HAWK, INSERTO CON DESCRIPCION .. (Enviar Como Inconsistencia)                                                                      
  IF NOT EXISTS (SELECT CodigoClaseIMO FROM dbo.ClaseIMO (NOLOCK) WHERE CodigoClaseIMOSunat = @ClaseImo)                                                                                                                                          
   BEGIN                                                                                                                                                                   
   INSERT dbo.ClaseIMO
   (
       --CodigoClaseIMO - this column value is auto-generated
       CodigoClaseIMOSunat,
       NombreClaseIMO,
       EstadoRegistro,
       UsuarioCreacion,
       FechaHoraCreacion
   )
   VALUES
   (
       -- CodigoClaseIMO - bigint
       @ClaseImo, -- CodigoClaseIMOSunat - varchar
       'IMO '+@ClaseImo, -- NombreClaseIMO - varchar
       1, -- EstadoRegistro - bit
       'JAV', -- UsuarioCreacion - varchar
       getdate()
   )   

   SET @CodigoClaseIMO=@@Identity 

   INSERT dbo.NumeroIMO
   (
       --CodigoNumeroIMO - this column value is auto-generated
       CodigoClaseIMO,
       NumberIMO,
       NombreNumeroIMO,
       PaginaNumeroIMO,
       EstadoRegistro,
       UsuarioCreacion,
       FechaHoraCreacion
   )
   VALUES
   (
       -- CodigoNumeroIMO - bigint
       @CodigoClaseIMO, -- CodigoClaseIMO - bigint
       isnull(@NroImo,''), -- NumberIMO - varchar
       'Numero IMO '+isnull(@NroImo,''), -- NombreNumeroIMO - varchar
       NULL, -- PaginaNumeroIMO - int
       1, -- EstadoRegistro - bit,
	   USER_NAME(),
     getdate()
   ) 
   
   SET @CodigoNumeroIMO=@@Identity                                       
                                                                                                                                 
	PRINT 'Se Insertó la ClaseIMO '+@ClaseImo+' debes registrar su Descripcion'                                                                                                                                                                                                                                                                                                                                               
   END
   ELSE 
	BEGIN
		SELECT @CodigoClaseIMO=CodigoClaseIMO FROM dbo.ClaseIMO (NOLOCK) WHERE CodigoClaseIMOSunat = @ClaseImo
		SELECT @CodigoNumeroIMO=CodigoNumeroIMO FROM dbo.NumeroIMO (NOLOCK) WHERE CodigoClaseIMO = @CodigoClaseIMO AND NumberIMO = @NroImo 
	END  
	                                                                              
  SELECT @ls_segmento_ant = 'DGS+IMD'                                                                                                                                                                            
 END                                                                                                                                                            
                                                          
/********PCI - MARCAS Y NUMEROS******/                                          
IF @ls_linea like 'PCI%'                                                                                            
BEGIN                                          
  SET @IsPCI = 1                                                                                                                        
  SELECT @ls_linea = SUBSTRING(@ls_linea,5,LEN(@ls_linea))                                                    
                                                                                                                                      
  IF CHARINDEX('+',@ls_linea,1) > 0                                                                                                                    
  BEGIN                                                                                                                                                                     
  IF CHARINDEX('+',@ls_linea,1) > 0                                                                                                       
     BEGIN                                                                                                                                                         
      SELECT @MarcasyNumeros = SUBSTRING(@ls_linea,CHARINDEX('+',@ls_linea,1)+1,LEN(@ls_linea))                                                                                                                                   
     END                     
   END                                                                                                                                         
/*Valida que las descripciones largas del contenedor estens separadas por ItemCtn*/                                                                                                                                                                                                                                                                                                                                               
   INSERT @Temporal_DocumentoDetalleCarga                                                                                                                    
   (                                                                                                                                                                                                                             
		NumeroDocumento,                                                                                                                                                                                                                                                                                                            
		NumeroContenedor,  
		CodigoCondicionTransporte,
		CodigoTipoMovimiento,
		CodigoUnidadMercancia,
		CodigoNaturalezaCarga,
		CodigoCondicionCarga,
		CodigoTemperatura,
		CodigoClaseIMO,
		CodigoNumeroIMO,
		CodigoAlmacen,
		CodigoDeposito,
		CodigoPrecinto,                                                                                                                                                                                                   
		ItemDocumento,
		CantidadBulto,                                                                                                                                                                                                                                                                                                                                                                                                                                     
		PesoBruto,                                                                                                               
		VolumenBruto, 
		TemperaturaMinima,                                              
		TemperaturaMaxima,
		Propietario,
		Observacion,
		DescripcionMercaderia,                                                                                                                                      
		MarcasNumeros, 
		Falto                                                                                                                                                                                  
   )  
   SELECT
	   @ls_nrodoc,                                                                                                                                                                                                                                                                                      
	   @ContenedorBL,                                                                                                                                                                                               
	   NULL, -- CodigoCondicionTransporte, esta en Containers
	   4, -- CodigoTipoMovimiento, sera 4 (FCL/LCL)  
	   @CodigoUnidadMercancia, 
	   6, -- CodigoNaturalezaCarga, sera 6 (Contenerizada)      
	   4, -- CodigoCondicionCarga, sera 4 (Carga General)
	   NULL, -- CodigoTemperatura, esta en Containers (hay que trar del FK)
	   @CodigoClaseIMO, -- CodigoClaseIMO, Los Vacios no tiene IMO,
	   @CodigoNumeroIMO, -- CodigoNumeroIMO, Los Vacios no tiene IMO,
	   NULL, -- CodigoAlmacen, Por Definir	                                                                                                                                                        
	   NULL, -- CodigoDeposito, Por Definir,
	   NULL, -- CodigoPrecinto, esta en Containers,
	   CAST(@ItmCtn AS int),                                                                                                                                                                      
	   CAST(@CanBul AS int), -- CantidadBulto, Por ser Vacio se envia 1   
	   CAST(@ls_peso_carga2 AS decimal(15,2)), -- PesoBruto
	   CAST(@ls_volumenctn AS decimal(15,2)), -- VolumenBruto
	   NULL, -- TemperaturaMinima, esta en Containers                                                                                                                     
	   NULL, -- TemperaturaMaxima, esta en Containers
	   NULL, -- Propietario, esta en Containers
	   NULL, -- Observacion, no Tiene Observacion
	   @DescripcionMercaderia, -- DescripcionMercaderia, por ser Vacio
	   @MarcasyNumeros,-- MarcasNumeros, Sin Marcas y Numeros por ser Vacio 
	   0 -- Falto, 0: No es Falto                                                                                                                                                                                                                                                                                                                                                 
                                                                         
 /*Limpio Variables*/                                                                                                                    
    SELECT                                                       
   --@ls_nrodoc = NULL,                                                                                                                                     
   --@ls_nrobooking = NULL,                                                                                
      @ContenedorBL= NULL,                             
     @UnidadBasicaCarga= NULL,                                                         
	 @ItmCtn= NULL,                                                                                 
     @CanBul= NULL,                                                                                
     @CodUBCHawk= NULL,                                                                                                                                                                                                  
     @ls_peso_carga2= NULL,                                       
     @DescripcionMercaderia= NULL,                                                                                                                                                                                                  
     @MarcasyNumeros= NULL,                                                                                
     @ls_regimen= NULL,                                                 
     @ls_condicion= NULL,                                                                      
     @ls_condicion= NULL,                                                    
     @ClaseImo = NULL,                                                                                                                                                                                              
     @NroImo = NULL,                                                                                                  
     @ls_volumenctn = NULL,
	 @CodigoCondicionTransporte = NULL,
	 @CodigoUnidadMercancia=NULL,
	 @CodigoClaseIMO=NULL,
	 @CodigoNumeroIMO=NULL                                                                                                              
	                                                                                                                 
    SET @DescripcionMercaderia = ''                                                                                                                                                                                                                             
    SET @p_Bloques = @p_Bloques +'PCI-'                                                                                                                                                            
    SELECT @ls_segmento_ant = 'PCI'                                
END                                                                          
                                                                
 /*MIGUEL, Contador de Ctn si llega @contCtn = 3, indica que no tiene PCI (Se fue hasta el Segmento GID Siguiente)*/                                                                                                                                           
                          
  IF ISNULL(@ContenedorBL,'')<>''                                                                     
    BEGIN                                                                                                                                                     
       SET @contCtn=@contCtn+1                                                                                                                                          
    END                                                    
 ELSE                                                                                                                                           
    BEGIN                                                                                                                    
       SET @contCtn=0                                                                                                                                                                  
    END                                                                                            
                                                                                                                    
  -- ADD JAV 28/09/2015, Si PCI = 0 (No tiene PCI) y @contCtn=2, se suma un valor mas para que inserte (@contCtn=3)                                                                          
  IF (@isPCI = 0) AND (ISNULL(@ContenedorBL,'')<>'') AND @contCtn=2                                   
    BEGIN                                                                            
  SET @CanBulNoPCI = @CanBul                                                                          
  SET @CodUBCHawkNoPCI = @CodUBCHawk                                                                
 END                                                                                                                                                                       
   --FIN                                                                            
                                                                                                                                                                                       
 IF (@isPCI = 0) AND (@contCtn=3) AND (ISNULL(@ContenedorBL,'')<>'')                                                   
 BEGIN                                                                                                                                                                                                   
   INSERT @Temporal_DocumentoDetalleCarga                                                                                                                    
   (                                                                                                                                                                                                                             
		NumeroDocumento,                                                                                                                                                                                                                                                                                                            
		NumeroContenedor,  
		CodigoCondicionTransporte,
		CodigoTipoMovimiento,
		CodigoUnidadMercancia,
		CodigoNaturalezaCarga,
		CodigoCondicionCarga,
		CodigoTemperatura,
		CodigoClaseIMO,
		CodigoNumeroIMO,
		CodigoAlmacen,
		CodigoDeposito,
		CodigoPrecinto,                                                                                                                                                                                                   
		ItemDocumento,
		CantidadBulto,                                                                                                                                                                                                                                                                                                                                                                                                                                     
		PesoBruto,                                                                                                               
		VolumenBruto, 
		TemperaturaMinima,                                              
		TemperaturaMaxima,
		Propietario,
		Observacion,
		DescripcionMercaderia,                                                                                                                                      
		MarcasNumeros, 
		Falto                                                                                                                                                                                  
   )  
   SELECT
	   @ls_nrodoc,                                                                                                                                                                                                                                                                                      
	   @ContenedorBL,                                                                                                                                                                                               
	   NULL, -- CodigoCondicionTransporte, esta en Containers
	   4, -- CodigoTipoMovimiento, sera 4 (FCL/LCL)  
	   @CodigoUnidadMercancia, 
	   6, -- CodigoNaturalezaCarga, sera 6 (Contenerizada)      
	   4, -- CodigoCondicionCarga, sera 4 (Carga General)
	   NULL, -- CodigoTemperatura, esta en Containers (hay que trar del FK)
	   @CodigoClaseIMO, -- CodigoClaseIMO, Los Vacios no tiene IMO,
	   @CodigoNumeroIMO, -- CodigoNumeroIMO, Los Vacios no tiene IMO,
	   NULL, -- CodigoAlmacen, Por Definir	                                                                                                                                                        
	   NULL, -- CodigoDeposito, Por Definir,
	   NULL, -- CodigoPrecinto, esta en Containers,
	   CAST(@ItmCtn AS int),                                                                                                                                                                      
	   CAST(@CanBul AS int), -- CantidadBulto, Por ser Vacio se envia 1   
	   CAST(@ls_peso_carga2 AS decimal(15,2)), -- PesoBruto
	   CAST(@ls_volumenctn AS decimal(15,2)), -- VolumenBruto
	   NULL, -- TemperaturaMinima, esta en Containers                                                                                                                     
	   NULL, -- TemperaturaMaxima, esta en Containers
	   NULL, -- Propietario, esta en Containers
	   NULL, -- Observacion, no Tiene Observacion
	   @DescripcionMercaderia, -- DescripcionMercaderia, por ser Vacio
	   @MarcasyNumeros,-- MarcasNumeros, Sin Marcas y Numeros por ser Vacio 
	   0 -- Falto, 0: No es Falto                                                                                                                                                                                                                                                                                                                                                 
                                                                         
 /*Limpio Variables*/                                                                                                                    
    SELECT                                                       
   --@ls_nrodoc = NULL,                                                                                                                                     
   --@ls_nrobooking = NULL,                                                                                
     @ContenedorBL= NULL,                             
     @UnidadBasicaCarga= NULL,                                                         
	 @ItmCtn= NULL,                                                                                 
     @CanBul= NULL,                                                                                
     @CodUBCHawk= NULL,                                                                                                                                                                                                  
     @ls_peso_carga2= NULL,                                       
     @DescripcionMercaderia= NULL,                                                                                                                                                                                                  
     @MarcasyNumeros= NULL,                                                                                
     @ls_regimen= NULL,                                                 
     @ls_condicion= NULL,                                                                      
     @ls_condicion= NULL,                                                    
     @ClaseImo = NULL,                                                                                                                                                                                              
     @NroImo = NULL,                                                                                                  
     @ls_volumenctn = NULL,
	 @CodigoCondicionTransporte = NULL,
	 @CodigoUnidadMercancia=NULL,
	 @CodigoClaseIMO=NULL,
	 @CodigoNumeroIMO=NULL                                                                                                                                                                                                                                                                                               
                            
   SET @DescripcionMercaderia = ''                                                                                                                                                                                                                                                                                                                                                                                                                 
  END                            
                                                                         
  SET @isPCI = 0  -- Reinicia el @isPCI a 0                                                     
                                                                                                    
  IF  @ls_bls_old<>@ls_bls_new                                                 
  BEGIN                                                                                         
	IF @p_Bloques NOT LIKE '%SGP%'                                                                                                   
    BEGIN    
		PRINT 'El BL ' + @ls_bls_old + ' no tiene carga '                                                                                                                                  
                                                                      
		DELETE FROM @Temporal_Documento WHERE NumeroDocumento=@ls_bls_old                                                                        
		DELETE FROM @TmpCarga WHERE NroBL=@ls_bls_old                                                                                                                            
		DELETE FROM @Temporal_DocumentoDetalleFlete WHERE NumeroDocumento=@ls_bls_old                                                                                                                            
		DELETE FROM @Temporal_DocumentoDetalleCliente WHERE NumeroDocumento=@ls_bls_old                                   
    END                                                                                                          
	SET @p_Bloques=''                                                                           
	SET @ls_bls_old=@ls_bls_new                                                                                                                                               
  END 
                                                                                                                                                                        
END -- FIN DEL BUCLE de TEXTO      

 DELETE FROM @Temporal_Documento WHERE ISNULL(NumeroDocumento,'')=''                                                                                                                    
 DELETE FROM @Temporal_DocumentoDetalleCarga WHERE ISNULL(NumeroContenedor,'')=''  
 DELETE FROM @Temporal_DocumentoDetalleCliente WHERE ISNULL(NumeroDocumento,'')=''
 DELETE FROM @Temporal_DocumentoDetalleFlete WHERE (ISNULL(NumeroDocumento,'')='' OR ISNULL(CodigoTipoFlete,0)=0)  

 --SELECT * FROM @Temporal_Contenedor
 --SELECT * FROM @Temporal_Documento
 --SELECT * FROM @Temporal_DocumentoDetalleCarga
 --SELECT * FROM @Temporal_DocumentoDetalleCliente
 --SELECT * FROM @Temporal_DocumentoDetalleFlete

-- Migracion Contenedores, Precintos, Entidad Precinto, Temperaturas
SELECT @Max_PK_Contenedor=Max(PK_Contenedor) FROM @Temporal_Contenedor

WHILE (@Min_PK_Contenedor<=@Max_PK_Contenedor)
BEGIN
	SELECT @NumeroContenedor=NumeroContenedor,@TCodigoTipoContenedor=CodigoTipoContenedor,@PesoTara=cast(PesoTara AS decimal(15,2)),@Precinto1=Precinto1,
	@EntidadPrecinto1=EntidadPrecinto1,@UnidadTemperatura=UnidadTemperatura
	FROM @Temporal_Contenedor WHERE PK_Contenedor = @Min_PK_Contenedor

	-- Entidad Precinto
	IF NOT EXISTS(SELECT CodigoEntidadPrecinto FROM dbo.EntidadPrecinto ep (NOLOCK) WHERE ep.CodigoEntidadPrecintoSunat = @EntidadPrecinto1 AND ep.EstadoRegistro = 1)
	BEGIN
		SELECT @CodigoEntidadPrecinto=CodigoEntidadPrecinto FROM dbo.EntidadPrecinto ep (NOLOCK) WHERE ep.CodigoEntidadPrecintoSunat = 'AB' AND ep.EstadoRegistro = 1
	END 
	ELSE
	BEGIN
		SELECT @CodigoEntidadPrecinto=CodigoEntidadPrecinto FROM dbo.EntidadPrecinto ep (NOLOCK) WHERE ep.CodigoEntidadPrecintoSunat = @EntidadPrecinto1 AND ep.EstadoRegistro = 1
	END
	
	-- Precinto
	IF NOT EXISTS(SELECT CodigoPrecinto FROM dbo.Precinto p (NOLOCK) WHERE p.NumeroPrecinto = @Precinto1 AND p.EstadoRegistro = 1)
	BEGIN
		INSERT dbo.Precinto
		(
		    --CodigoPrecinto - this column value is auto-generated
		    CodigoCondicionPrecinto,
		    CodigoEntidadPrecinto,
		    NumeroPrecinto,
		    EstadoRegistro,
		    UsuarioCreacion,
		    FechaHoraCreacion
		)
		VALUES
		(
		    -- CodigoPrecinto - bigint
		    1, -- CodigoCondicionPrecinto - bigint -- BUENO
		    @CodigoEntidadPrecinto, -- CodigoEntidadPrecinto - bigint
		    @Precinto1, -- NumeroPrecinto - varchar
		    1, -- EstadoRegistro - bit
		    USER_NAME(), -- UsuarioCreacion - varchar
		    GETDATE()
		)

		SET @CodigoPrecinto = @@IDENTITY
	END 
	ELSE
	BEGIN
		SELECT @CodigoPrecinto=CodigoPrecinto FROM dbo.Precinto p (NOLOCK) WHERE p.NumeroPrecinto = @Precinto1 AND p.EstadoRegistro = 1

		UPDATE dbo.Precinto
		SET
		    CodigoEntidadPrecinto = @CodigoEntidadPrecinto, 
		    UsuarioActualizacion = USER_NAME(),
		    FechaHoraActualizacion = GETDATE()
		WHERE NumeroPrecinto = @Precinto1
	END  

	-- Contenedor
	IF NOT EXISTS(SELECT c.CodigoContenedor FROM dbo.Contenedor c (NOLOCK) WHERE c.NumeroContenedor = @NumeroContenedor AND c.EstadoRegistro = 1)
	BEGIN
		INSERT dbo.Contenedor
		(
		    CodigoTipoContenedor,
		    NumeroContenedor,
		    TaraContenedor,
		    EstadoRegistro,
		    UsuarioCreacion,
		    FechaHoraCreacion
		)
		VALUES
		(
		    @TCodigoTipoContenedor, 
		    @NumeroContenedor, 
		    @PesoTara, 
		    1,
		    USER_NAME(), 
		    GETDATE()
		)

		SET @CodigoContenedor = @@IDENTITY
	END 
	ELSE
	BEGIN
		UPDATE dbo.Contenedor
		SET
		    CodigoTipoContenedor = @TCodigoTipoContenedor, 
		    TaraContenedor = @PesoTara,
		    UsuarioActualizacion = USER_NAME(), 
		    FechaHoraActualizacion = GETDATE()
		WHERE NumeroContenedor = @NumeroContenedor

		SELECT @CodigoContenedor=c.CodigoContenedor FROM dbo.Contenedor c (NOLOCK) WHERE c.NumeroContenedor = @NumeroContenedor AND c.EstadoRegistro = 1
	END 
	SET @Min_PK_Contenedor = @Min_PK_Contenedor + 1 
END
      
UPDATE a SET 
a.CodigoCondicionTransporte = b.CodigoCondicionTransporte, 
a.CodigoTemperatura = t.CodigoTemperatura,
a.TemperaturaMinima = b.Temperatura,
a.TemperaturaMaxima = b.Temperatura,
a.Propietario = b.PropietarioContenedor,
a.CodigoPrecinto = p.CodigoPrecinto,
a.CodigoUnidadMercancia = CASE WHEN a.CodigoUnidadMercancia IS NULL THEN 1 ELSE a.CodigoUnidadMercancia END,
a.CodigoClaseIMO = CASE WHEN a.CodigoClaseIMO IS NULL THEN 20 ELSE a.CodigoClaseIMO END,
a.CodigoNumeroIMO = CASE WHEN a.CodigoNumeroIMO IS NULL THEN 1277 ELSE a.CodigoNumeroIMO END,
a.CodigoAlmacen = 136, -- TRABAJOS MARITIMOS S.A. TRAMARSA
a.CodigoDeposito = 5886 -- DP WORLD CALLAO S.R.L.
FROM @Temporal_DocumentoDetalleCarga a INNER JOIN @Temporal_Contenedor b ON a.NumeroContenedor = b.NumeroContenedor
LEFT JOIN dbo.Temperatura t ON ISNULL(b.UnidadTemperatura,'999') = t.CodigoTemperaturaSunat 
INNER JOIN dbo.Precinto p ON b.Precinto1 = p.NumeroPrecinto

-- Si el Documento Existe, se debe eliminar, para volver a registrarlo con la nueva data
DECLARE @Documentos_Eliminar TABLE
(
	CodigoDocumento bigint
)

INSERT @Documentos_Eliminar
SELECT CodigoDocumento FROM dbo.Documento (NOLOCK) d INNER JOIN @Temporal_Documento td ON d.CodigoItinerario = @CodigoItinerario AND d.CodigoPuertoOrigenDocumento=td.CodigoPuertoOrigenDocumento
AND d.CodigoPuertoEmbarqueDocumento=td.CodigoPuertoEmbarqueDocumento AND d.CodigoPuertoDescargaDocumento=td.CodigoPuertoDescargaDocumento AND 
d.CodigoPuertoFinalDocumento=td.CodigoPuertoFinalDocumento AND CodigoLineaNaviera=@CodigoLineaNaviera AND d.CodigoAduana=td.CodigoAduana

DELETE FROM DocumentoDetalleFlete WHERE CodigoDocumento IN (SELECT CodigoDocumento FROM @Documentos_Eliminar)
DELETE FROM DocumentoDetalleCliente WHERE CodigoDocumento IN (SELECT CodigoDocumento FROM @Documentos_Eliminar)
DELETE FROM DocumentoDetalleCarga WHERE CodigoDocumento IN (SELECT CodigoDocumento FROM @Documentos_Eliminar)
DELETE FROM Documento WHERE CodigoDocumento IN (SELECT CodigoDocumento FROM @Documentos_Eliminar)

INSERT dbo.Documento
(
    --CodigoDocumento - this column value is auto-generated
    CodigoItinerario,
    CodigoPuertoOrigenDocumento,
    CodigoPuertoEmbarqueDocumento,
    CodigoPuertoDescargaDocumento,
    CodigoPuertoFinalDocumento,
    CodigoLineaNaviera,
    CodigoAduana,
    CodigoTipoBL,
    CodigoTipoEnvio,
    CodigoCondicionContrato,
    CodigoRequerimientoServicio,
    NumeroDocumento,
    FechaEmisionDocumento,
    FechaEmbarqueDocumento
)
 SELECT 
	@CodigoItinerario,
    CodigoPuertoOrigenDocumento,
    CodigoPuertoEmbarqueDocumento,
    CodigoPuertoDescargaDocumento,
    CodigoPuertoFinalDocumento,
    @CodigoLineaNaviera,
    CodigoAduana,
    CodigoTipoBL,
    CodigoTipoEnvio,
    CodigoCondicionContrato,
    CodigoRequerimientoServicio,
    NumeroDocumento,
    CAST(FechaEmisionDocumento AS datetime),
    CAST(FechaEmbarqueDocumento AS datetime)
FROM @Temporal_Documento

--SELECT * FROM Documento

INSERT dbo.DocumentoDetalleCarga
(
    --CodigoDocumentoDetalleCarga - this column value is auto-generated
    CodigoDocumento,
    CodigoContenedor,
    CodigoCondicionTransporte,
    CodigoTipoMovimiento,
    CodigoUnidadMercancia,
    CodigoNaturalezaCarga,
    CodigoCondicionCarga,
    CodigoTemperatura,
    CodigoClaseIMO,
    CodigoNumeroIMO,
    CodigoAlmacenDocumentoDetalleCarga,
    CodigoDepositoDocumentoDetalleCarga,
    CodigoPrecinto,
    ItemDocumentoDetalleCarga,
    CantidadBultoDocumentoDetalleCarga,
    PesoBrutoDocumentoDetalleCarga,
    VolumenBrutoDocumentoDetalleCarga,
    TemperaturaMinimaDocumentoDetalleCarga,
    TemperaturaMaximaDocumentoDetalleCarga,
    PropietarioDocumentoDetalleCarga,
    ObservacionDocumentoDetalleCarga,
    DescripcionDocumentoDetalleCarga,
    MarcasNumerosDocumentoDetalleCarga,
    FaltoDocumentoDetalleCarga
)
SELECT
    -- CodigoDocumentoDetalleCarga - bigint
    d.CodigoDocumento,
    c.CodigoContenedor,
    tddc.CodigoCondicionTransporte,
    tddc.CodigoTipoMovimiento,
    tddc.CodigoUnidadMercancia,
    tddc.CodigoNaturalezaCarga,
    tddc.CodigoCondicionCarga,
    tddc.CodigoTemperatura,
    tddc.CodigoClaseIMO,
    tddc.CodigoNumeroIMO,
    tddc.CodigoAlmacen,
    tddc.CodigoDeposito,
    tddc.CodigoPrecinto,
    tddc.ItemDocumento,
    tddc.CantidadBulto,
    tddc.PesoBruto,
    tddc.VolumenBruto,
    tddc.TemperaturaMinima,
    tddc.TemperaturaMaxima,
    tddc.Propietario,
    tddc.Observacion,
    tddc.DescripcionMercaderia,
    tddc.MarcasNumeros,
    tddc.Falto
FROM @Temporal_DocumentoDetalleCarga tddc INNER JOIN dbo.Documento (NOLOCK) d ON tddc.NumeroDocumento=d.NumeroDocumento
INNER JOIN dbo.Contenedor (NOLOCK) c ON c.NumeroContenedor = tddc.NumeroContenedor

--SELECT * FROM DocumentoDetalleCarga

INSERT dbo.DocumentoDetalleCliente
(
    --CodigoDocumentoDetalleCliente - this column value is auto-generated
    CodigoDocumento,
    CodigoRol,
    CodigoPersona
)
SELECT
	d.CodigoDocumento,
    tddc.CodigoRol,
    tddc.CodigoPersona
FROM @Temporal_DocumentoDetalleCliente tddc INNER JOIN dbo.Documento (NOLOCK) d ON tddc.NumeroDocumento=d.NumeroDocumento

--SELECT * FROM DocumentoDetalleCliente

INSERT dbo.DocumentoDetalleFlete
(
    --CodigoDocumentoDetalleFlete - this column value is auto-generated
    CodigoDocumento,
    CodigoTipoFlete,
    CodigoMoneda,
    CodigoModoPago,
    MontoDocumentoDetalleFlete
)
SELECT
	d.CodigoDocumento,
    tddf.CodigoTipoFlete,
    tddf.CodigoMoneda,
    tddf.CodigoModoPago,
    tddf.MontoFlete
FROM @Temporal_DocumentoDetalleFlete tddf INNER JOIN dbo.Documento (NOLOCK) d ON tddf.NumeroDocumento=d.NumeroDocumento

--SELECT * FROM DocumentoDetalleFlete

-- USP_PROCESAR_ARCHIVO_MANIFIESTO 1 
                                                                                                                                 
SET NOCOUNT OFF    