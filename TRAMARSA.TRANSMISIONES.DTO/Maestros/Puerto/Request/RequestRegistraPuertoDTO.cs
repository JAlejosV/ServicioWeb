﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Puerto.Request
{
    [DataContract]
    public class RequestRegistraPuertoDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoPuerto { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoPais { get; set; }
        [DataMember(Order = 2)]
        public string CodigoPuertoSunat { get; set; }
        [DataMember(Order = 3)]
        public string NombrePuerto { get; set; }
        [DataMember(Order = 4)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 5)]
        public string Accion { get; set; }
    }
}
