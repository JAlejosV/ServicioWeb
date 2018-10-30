using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace TRAMARSA.TRANSMISIONES.Entidades
{
    /// <summary>
    /// clase para Maestro Base
    /// </summary>
    //[Serializable]
    //[DataContract]
    public class PaginacionResponseBase
    {
        public int? TotalRegistros { get; set; }
        public int? CantidadPaginas { get; set; }
    }
}

