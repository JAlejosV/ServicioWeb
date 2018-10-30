using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.MedioTransporte.Response
{
    public class ResponseConsultarMedioTransporte : PaginacionResponseBase
    {
       public ResponseConsultarMedioTransporte() {

           ListaMedioTransporte = new List<MedioTransporte>();
       }
    
        public List<MedioTransporte> ListaMedioTransporte { get; set; }
    }
}
