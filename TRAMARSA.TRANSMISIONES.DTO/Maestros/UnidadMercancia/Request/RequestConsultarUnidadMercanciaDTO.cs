﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.UnidadMercancia.Request
{
    [DataContract]
    public class RequestConsultarUnidadMercanciaDTO : RequestPaginacionBaseDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoUnidadMercancia { get; set; }
        [DataMember(Order = 1)]
        public string CodigoUnidadMercanciaSunat { get; set; }
        [DataMember(Order = 2)]
        public string NombreUnidadMercancia { get; set; }
        [DataMember(Order = 3)]
        public string CodigoAduanaUnidadMercancia { get; set; }
    }
}
