USE TransmisionesDB
GO

-- SELECT * FROM dbo.DocumentoDetalleCarga ddc

--CodigoDocumentoDetalleCarga CodigoDocumento      CodigoContenedor     CodigoCondicionTransporte CodigoTipoMovimiento CodigoUnidadMercancia CodigoNaturalezaCarga 
----------------------------- -------------------- -------------------- ------------------------- -------------------- --------------------- --------------------- 
--1                           1                    1                    6                         3                    27                    9                     
--2                           1                    2                    6                         3                    27                    9                     
--3                           2                    3                    6                         3                    27                    9                     
--4                           2                    4                    6                         3                    27                    9                     

--CodigoCondicionCarga CodigoTemperatura    CodigoClaseIMO       CodigoNumeroIMO      CodigoAlmacenDocumentoDetalleCarga CodigoDepositoDocumentoDetalleCarga 
---------------------- -------------------- -------------------- -------------------- ---------------------------------- ----------------------------------- 
--4                    3                    20                   1277                 5886                               5886                                
--4                    1                    20                   1277                 136                                136                                 
--4                    1                    20                   1277                 5886                               5886                                
--4                    3                    1                    1                    5886                               5886                                

--CodigoPrecinto       ItemDocumentoDetalleCarga CantidadBultoDocumentoDetalleCarga PesoBrutoDocumentoDetalleCarga          VolumenBrutoDocumentoDetalleCarga      
---------------------- ------------------------- ---------------------------------- --------------------------------------- ---------------------------------------
--1                    1                         20                                 15500.000                               18000.000                              
--2                    2                         50                                 17500.000                               20000.000                              
--3                    3                         20                                 15500.000                               18000.000                              
--4                    4                         40                                 17500.000                               20000.000                              

-- TemperaturaMinimaDocumentoDetalleCarga  TemperaturaMaximaDocumentoDetalleCarga  PropietarioDocumentoDetalleCarga ObservacionDocumentoDetalleCarga  
-- --------------------------------------- --------------------------------------- -------------------------------- ----------------------------------
-- NULL                                    NULL                                    NULL                             NULL                              
-- -21.00                                  -20.00                                  NULL                             NULL                              
-- -18.00                                  -16.00                                  NULL                             NULL                              
-- NULL                                    NULL                                    NULL                             NULL                              

--DescripcionDocumentoDetalleCarga     MarcasNumerosDocumentoDetalleCarga FaltoDocumentoDetalleCarga EstadoRegistro UsuarioCreacion 
-------------------------------------- ------------------------------------------------------------- -------------- --------------- 
--20 BOXES CARGO GENERAL               SMyN                               0                          1              dbo             
--20 BOXES CARGO GENERAL REEFER        SMyN                               0                          1              dbo             
--20 BOXES CARGO GENERAL REEFER        SMyN                               0                          1              dbo             
--20 BOXES CARGA PELIGROSA CNT TANQUE  SMyN                               0                          1              dbo             

--FechaHoraCreacion       UsuarioActualizacion                                                                                 Fech
------------------------- ---------------------------------------------------------------------------------------------------- ----
--2018-09-14 20:42:41.007 NULL                                                                                                 NULL
--2018-09-14 20:42:41.027 NULL                                                                                                 NULL
--2018-09-14 20:42:41.030 NULL                                                                                                 NULL
--2018-09-14 20:42:41.030 NULL                                                                                                 NULL

USP_PROCESAR_ARCHIVO_MANIFIESTO 1 

SELECT ct.* FROM dbo.CondicionTransporte ct  
SELECT tm.* FROM dbo.TipoMovimiento tm
SELECT ct.* FROM dbo.CondicionTransporte ct
SELECT ct.* FROM dbo.UnidadMercancia ct WHERE ct.CodigoUnidadMercanciaSunat = 'CX'
SELECT ct.* FROM dbo.UnidadMercancia ct WHERE ct.CodigoUnidadMercanciaSunat = 'CT'
SELECT ct.* FROM dbo.NaturalezaCarga ct
SELECT ct.* FROM CondicionCarga ct
SELECT ct.* FROM Temperatura ct
SELECT ct.* FROM CondicionCarga ct
SELECT ct.* FROM CondicionCarga ct
SELECT ct.* FROM CondicionCarga ct
SELECT ct.* FROM CondicionCarga ct