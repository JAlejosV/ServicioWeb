﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Precinto.Request
{
    public class RequestRegistroPrecinto
    {
        public Int64 CodigoPrecinto { get; set; }
        public Int64 CodigoCondicionPrecinto { get; set; }
        public Int64 CodigoEntidadPrecinto { get; set; }
        public string NumeroPrecinto { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
