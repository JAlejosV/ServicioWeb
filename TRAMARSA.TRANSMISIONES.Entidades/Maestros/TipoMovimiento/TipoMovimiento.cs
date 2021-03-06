﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoMovimiento
{
    public class TipoMovimiento
    {
        public Int64 CodigoTipoMovimiento { get; set; }
        public string CodigoTipoMovimientoSunat { get; set; }
        public string NombreTipoMovimiento { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
