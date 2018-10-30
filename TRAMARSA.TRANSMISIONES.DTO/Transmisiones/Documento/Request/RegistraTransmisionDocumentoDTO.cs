using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Documento.Request
{
    public class RegistraTransmisionDocumentoDTO
    {
        public RegistraTransmisionDocumentoDTO()
        {
            this.ListaDocumentos = new List<DetalleTransmisionDocumentoDTO>();
        }

        public string TipoTransmision { get; set; }
        public List<DetalleTransmisionDocumentoDTO> ListaDocumentos { get; set; }
    }
}
