﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.CondicionTransporte.Response
{
    [DataContract]
    public class ResponseConsultaCondicionTransporteDTO : ResponseBaseDTO
    {
        public ResponseConsultaCondicionTransporteDTO()
        {
            this.ListaCondicionTransporte = new List<CondicionTransporteDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<CondicionTransporteDTO> ListaCondicionTransporte { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}