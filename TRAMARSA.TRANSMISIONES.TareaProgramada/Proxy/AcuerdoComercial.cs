using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAMARSA.TRANSMISIONES.Framework;

namespace TRAMARSA.TRANSMISIONES.TareaProgramada.Proxy
{
    public class AcuerdoComercial : ProxyBaseRest
    {
        //public NotificarContenedoresNoDevueltosResponseDTO NotificarContenedoresNoDevueltos(string codigoLinea)
        //{
        //    string url = System.Configuration.ConfigurationManager.AppSettings["urlNotificarContenedoresNoDevueltos"];
        //    var response = DeserializarJSON<string, NotificarContenedoresNoDevueltosResponseDTO>(codigoLinea, url);
        //    if (response == null || response.Result.Satisfactorio == false)
        //        throw new Exception(string.Format("El servicio: {0} no esta disponible o tiene un formato no válido", url));

        //    return response;
        //}
    }
}
