﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.RequerimientoServicio.Response
{
    [DataContract]
    public class ResponseConsultaRequerimientoServicioDTO : ResponseBaseDTO
    {
        public ResponseConsultaRequerimientoServicioDTO()
        {
            this.ListaRequerimientoServicio = new List<RequerimientoServicioDTO>();
            this.Result = new Result();
        }

        [DataMember(Order = 0)]
        public List<RequerimientoServicioDTO> ListaRequerimientoServicio { get; set; }

        [DataMember(Order = 1)]
        public int? TotalRegistros { get; set; }
        [DataMember(Order = 2)]
        public int? CantidadPaginas { get; set; }
    }
}
