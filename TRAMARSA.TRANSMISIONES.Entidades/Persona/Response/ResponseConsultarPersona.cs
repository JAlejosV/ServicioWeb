using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Persona.Response
{
    public class ResponseConsultarPersona : PaginacionResponseBase
    {
        public ResponseConsultarPersona()
        {
            ListaPersona = new List<Persona>();
        }
        public List<Persona> ListaPersona { get; set; }
    }
}
