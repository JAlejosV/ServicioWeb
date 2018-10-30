using TRAMARSA.TRANSMISIONES.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO
{
    /// <summary>
    /// Clase para Busqueda Parametro Sistema Validacion
    /// </summary>
    public class BusquedaParametroSistemaValidacionDTO
    {
        [Required(ErrorMessage = "Valor es requerido.")]
        public string Valor { get; set; }

        [Required(ErrorMessage = "Descripción es requerido.")]
        public string Descripcion { get; set; }
    }
}
