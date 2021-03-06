﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO
{
    public class ResultException : Exception
    {
        public ResultException()
        {
        }

        public ResultException(Result result)
        {
            this.Result = result;
        }

        public Result Result { get; set; }
    }
}
