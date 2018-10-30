using AutoMapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAMARSA.TRANSMISIONES.Framework;
namespace TRAMARSA.TRANSMISIONES.AgenteServicios.Clientes
{
    public class ClientesProxy : ProxyBaseRest
    {
        //public List<ClienteBE> ConsultarCliente(List<string> codigoClienteSAPList)
        //{
        //    var response = DeserializarJSON<List<string>, ConsultaClienteResponseDTO>(codigoClienteSAPList, WebConfigReader.ServicesHost.TramarsaConsultarCliente);
        //    if (response == null || response.Result.Satisfactorio == false)
        //    {
        //        ManejadorExcepciones.PublicarExcepcion(string.Format("El servicio: {0} no esta disponible o tiene un formato no válido", WebConfigReader.ServicesHost.TramarsaConsultarCliente));
        //        return new List<ClienteBE>();
        //    }

        //    return response.ClienteList.Select(x => { return Helper.MiMapper<ClienteDTO, ClienteBE>(x); }).ToList();
        //}
 
    }
}
