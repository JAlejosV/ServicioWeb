using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Maestros.PersonaxRol.Response
{
    public class ResponseConsultarPersonaxRol : PaginacionResponseBase
    {
        public ResponseConsultarPersonaxRol()
        {
            ListaPersonaxRol = new List<PersonaxRol>();
        }

        public List<PersonaxRol> ListaPersonaxRol { get; set; }
    }
}
