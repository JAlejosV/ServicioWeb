﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.TipoBL.Response
{
    [DataContract]
    public class ResponseConsultaTipoBLDTO : ResponseBaseDTO
    {
        public ResponseConsultaTipoBLDTO()
        {
            this.ListaTipoBL = new List<TipoBLDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<TipoBLDTO> ListaTipoBL { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
