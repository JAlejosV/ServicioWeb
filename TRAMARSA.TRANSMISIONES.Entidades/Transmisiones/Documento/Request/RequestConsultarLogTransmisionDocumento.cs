﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Transmisiones.Documento.Request
{
    public class RequestConsultarLogTransmisionDocumento : PaginacionBase
    {
        public Int64? CodigoDocumento { get; set; }
    }
}
