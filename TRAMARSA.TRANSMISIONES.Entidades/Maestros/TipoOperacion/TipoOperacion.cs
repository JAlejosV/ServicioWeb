﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoOperacion
{
    public class TipoOperacion
    {
        public Int64 CodigoTipoOperacion { get; set; }
        public Byte CodigoTipoOperacionSunat { get; set; }
        public string NombreTipoOperacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
