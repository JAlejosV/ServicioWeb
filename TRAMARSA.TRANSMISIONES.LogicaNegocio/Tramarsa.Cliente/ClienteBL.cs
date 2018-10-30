//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TRAMARSA.TRANSMISIONES.AgenteServicios.Clientes;
//using TRAMARSA.TRANSMISIONES.DTO.Tramarsa.Cliente;
//using TRAMARSA.TRANSMISIONES.DTO.Tramarsa.Cliente.Request;
//using TRAMARSA.TRANSMISIONES.Entidades.Tramarsa.Cliente;

//namespace TRAMARSA.TRANSMISIONES.LogicaNegocio.Tramarsa.Cliente
//{
//    public class ClienteBL
//    {
//        public List<ClienteBE> ConsultarCliente(List<string> codigoClienteSAPList)
//        {
//            return (new ClientesProxy()).ConsultarCliente(codigoClienteSAPList);
//        }

//        public List<ClienteCorreoBE> ConsultarClienteCorreo(List<ConsultaClienteCorreoDTO> codigoClienteSAPList)
//        {
//            return (new ClientesProxy()).ConsultarClienteCorreo(codigoClienteSAPList);
//        }

//        public List<ClientePorMatchCodeBE> ConsultarClientePorMatchCodes(ConsultaClienteMatchCodeBE codigoClienteMatchCode)
//        {
//            return (new ClientesProxy()).ConsultarClientePorMatchCodes(codigoClienteMatchCode);
//        }

//        public List<ClienteCodigoClienteBE> ConsultarClienteXCodigoCliente(List<string> codigoClienteList)
//        {
//            return (new ClientesProxy()).ConsultarClienteXCodigoCliente(codigoClienteList);
//        }
//    }
//}
