using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

using AutoMapper;
using TRAMARSA.TRANSMISIONES.Entidades.Core;
using TRAMARSA.TRANSMISIONES.Framework;
using TRAMARSA.TRANSMISIONES.Entidades.Constantes;


namespace TRAMARSA.TRANSMISIONES.LogicaNegocio
{

    public class CoreBL
    {
        //public ParametroNegocio ObtenerParametroNegocio(string codigo)
        //{
        //    List<ParametroNegocio> lstParametrosNegocio = new List<ParametroNegocio>();
        //    ParametroNegocio parametroNegocio = new ParametroNegocio();
        //    try
        //    {
        //        string keyCache = Convert.ToString(KeyCache.ParametrosNegocio);

        //        ManejadorCache manejadorCache = new ManejadorCache();

        //        lstParametrosNegocio = manejadorCache.ObtenerValorCache<List<ParametroNegocio>>(keyCache);

        //        if (lstParametrosNegocio == null || lstParametrosNegocio.Count == 0)
        //        {
        //            var contextoParaBaseDatos = new ContextoParaBaseDatos(ConstantesDB.Reclamos);
        //            var repo = new RepositorioAcuerdoComercial(contextoParaBaseDatos);
        //            lstParametrosNegocio = repo.ObtenerParametrosNegocio();
        //            manejadorCache.InsertarValorCache(keyCache, lstParametrosNegocio);
        //        }

        //        if (lstParametrosNegocio.Count > 0)
        //        {
        //          parametroNegocio = lstParametrosNegocio.Where(x => x.Codigo == codigo).FirstOrDefault();
        //        }
                 
        //    }
        //    catch (Exception ex)
        //    {
        //        ManejadorExcepciones.PublicarExcepcion(ex, PoliticaExcepcion.LogicaNegocio);
        //    }

        //    return parametroNegocio;
        //}
    }
}
