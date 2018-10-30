﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.TipoDocumento
{
    public class TipoDocumento
    {
        public Int64 CodigoTipoDocumento { get; set; }
        public Int16 CodigoTipoDocumentoSunat { get; set; }
        public string NombreTipoDocumento { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
