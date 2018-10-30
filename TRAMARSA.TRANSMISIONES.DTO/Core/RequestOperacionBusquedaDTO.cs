using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAMARSA.TRANSMISIONES.Entidades.DTO;

namespace TRAMARSA.TRANSMISIONES.DTO.Core
{
    /// <summary>
    /// Clase para Request Operacion Busqueda
    /// </summary>
    public class RequestOperacionBusquedaDTO : RequestBaseDTO
    {
        public RequestOperacionBusquedaDTO()
        {
            this.PaginacionDTO = new PaginacionDTO();
        }
        /// <summary>
        /// Paginacion
        /// <br/><b>Tipo:</b> PaginacionDTO 
        /// </summary>
        public PaginacionDTO PaginacionDTO { get; set; }


    }
}
