using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave.Request
{
    public class RegistraTransmisionNaveDTO
    {
        public RegistraTransmisionNaveDTO()
        {
            this.ListaItinerarios = new List<DetalleTransmisionNaveDTO>();
        }

        public string TipoTransmision { get; set; }
        public List<DetalleTransmisionNaveDTO> ListaItinerarios { get; set; }
    }
}
