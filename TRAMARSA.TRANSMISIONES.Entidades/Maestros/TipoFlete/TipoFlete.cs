﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoFlete
{
    public class TipoFlete
    {
        public Int64 CodigoTipoFlete { get; set; }
        public string NombreTipoFlete { get; set; }
        public string CodigoAduanaTipoFlete { get; set; }
        public string CodigoEquivalencia { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}