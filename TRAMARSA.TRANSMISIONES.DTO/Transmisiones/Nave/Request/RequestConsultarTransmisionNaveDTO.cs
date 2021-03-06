﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave.Request
{
    [DataContract]
    public class RequestConsultarTransmisionNaveDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoItinerario { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoNave { get; set; }
        [DataMember(Order = 2)]
        public Int64? CodigoAduana { get; set; }
        [DataMember(Order = 3)]
        public Int64? CodigoTipoOperacion { get; set; }
        [DataMember(Order = 4)]
        public string NumeroViajeItinerario { get; set; }
        [DataMember(Order = 5)]
        public string NumeroManifiestoItinerario { get; set; }
        [DataMember(Order = 6)]
        public Int32? AnioManifiestoItinerario { get; set; }
        [DataMember(Order = 7)]
        public bool? EstadoEnvioAduanas { get; set; }
        [DataMember(Order = 8)]
        public bool? EstadoTransmision { get; set; }
        [DataMember(Order = 9)]
        public DateTime? FechaInicio { get; set; }
        [DataMember(Order = 10)]
        public DateTime? FechaFin { get; set; }
    }
}
