using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Documento
{
    public class RegistraTransmisionDocumento
    {
        public RegistraTransmisionDocumento()
        {
            this.ListaDocumentos = new List<DetalleTransmisionDocumento>();
        }

        public string TipoTransmision { get; set; }
        public List<DetalleTransmisionDocumento> ListaDocumentos { get; set; }
    }
}
