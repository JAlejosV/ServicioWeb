﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Core.Response
{

    [DataContract]
    public class EliminarParametroNegocioResponseDTO : ResponseBaseDTO
	{
        public EliminarParametroNegocioResponseDTO()
        {
            this.Result = new Result();
        }
    }
}