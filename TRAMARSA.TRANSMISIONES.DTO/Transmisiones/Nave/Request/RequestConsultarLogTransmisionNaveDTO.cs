﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Transmisiones.Nave.Request
{
    [DataContract]
    public class RequestConsultarLogTransmisionNaveDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoItinerario { get; set; }
    }
}
