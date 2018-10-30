﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.MedioTransporte
{
    public class MedioTransporte
    {
        public Int64 CodigoMedioTransporte { get; set; }
        public Byte CodigoMedioTransporteSunat { get; set; }
        public string NombreMedioTransporte { get; set; }
        public bool EstadoRegistro { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaHoraActualizacion { get; set; }
    }
}
