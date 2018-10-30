﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.Entidades.Documento
{
    public class DocumentoDetalleFlete
    {
        public Int64? CodigoDocumentoDetalleFlete { get; set; }
        public Int64? CodigoDocumento { get; set; }
        public Int64? CodigoTipoFlete { get; set; }
        public Int64? CodigoMoneda { get; set; }
        public Int64? CodigoModoPago { get; set; }
        public Decimal? MontoDocumentoDetalleFlete { get; set; }
        //public bool EstadoRegistro { get; set; }
        //public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }

    public class DocumentoDetalleFleteConsulta
    {
        public Int64? CodigoDocumentoDetalleFlete { get; set; }
        public Int64? CodigoDocumento { get; set; }
        public Int64? CodigoTipoFlete { get; set; }
        public string NombreTipoFlete { get; set; }
        public Int64? CodigoMoneda { get; set; }
        public string NombreMoneda { get; set; }
        public Int64? CodigoModoPago { get; set; }
        public string NombreModoPago { get; set; }
        public Decimal? MontoDocumentoDetalleFlete { get; set; }
        //public bool EstadoRegistro { get; set; }
        //public string UsuarioRegistro { get; set; }
        public string Accion { get; set; }
    }
}
