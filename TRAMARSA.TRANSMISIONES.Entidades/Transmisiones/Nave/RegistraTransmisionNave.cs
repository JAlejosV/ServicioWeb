using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Nave
{
    public class RegistraTransmisionNave
    {
        public RegistraTransmisionNave()
        {
            this.ListaItinerarios = new List<DetalleTransmisionNave>();
        }

        public string TipoTransmision { get; set; }
        public List<DetalleTransmisionNave> ListaItinerarios { get; set; }
    }
}
