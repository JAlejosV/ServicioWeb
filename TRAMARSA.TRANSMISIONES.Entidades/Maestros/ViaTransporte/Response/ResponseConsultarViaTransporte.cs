using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.ViaTransporte.Response
{
    public class ResponseConsultarViaTransporte : PaginacionResponseBase
    {
        public ResponseConsultarViaTransporte() {

            ListaViaTransporte = new List<ViaTransporte>();
       }

        public List<ViaTransporte> ListaViaTransporte { get; set; }
    }
}
