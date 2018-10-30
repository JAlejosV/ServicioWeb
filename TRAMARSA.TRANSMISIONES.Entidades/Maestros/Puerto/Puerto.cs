﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Puerto
{
    public class Puerto
    {
        public Int64 CodigoPuerto { get; set; }
        public Int64 CodigoPais { get; set; }
        public string CodigoPuertoSunat { get; set; }
        public string NombrePuerto { get; set; }
        public string NombrePais { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
