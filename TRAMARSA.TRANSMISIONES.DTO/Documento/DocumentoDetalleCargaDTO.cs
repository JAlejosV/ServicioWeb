using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Documento
{
    [DataContract]
    public class DocumentoDetalleCargaDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoDocumento { get; set; }
        [DataMember(Order = 2)]
        public Int64? CodigoContenedor { get; set; }
        [DataMember(Order = 3)]
        public string NumeroContenedor { get; set; }
        [DataMember(Order = 4)]
        public string NombreTipoContenedor { get; set; }
        [DataMember(Order = 5)]
        public string TamanioTipoContenedor { get; set; }
        [DataMember(Order = 6)]
        public Int64? CodigoCondicionTransporte { get; set; }
        [DataMember(Order = 7)]
        public string NombreCondicionTransporte { get; set; }
        [DataMember(Order = 8)]
        public Int64? CodigoTipoMovimiento { get; set; }
        [DataMember(Order = 9)]
        public string NombreTipoMovimiento { get; set; }
        [DataMember(Order = 10)]
        public Int64? CodigoUnidadMercancia { get; set; }
        [DataMember(Order = 11)]
        public string NombreUnidadMercancia { get; set; }
        [DataMember(Order = 12)]
        public Int64? CodigoNaturalezaCarga { get; set; }
        [DataMember(Order = 13)]
        public string NombreNaturalezaCarga { get; set; }
        [DataMember(Order = 14)]
        public Int64? CodigoCondicionCarga { get; set; }
        [DataMember(Order = 15)]
        public string NombreCondicionCarga { get; set; }
        [DataMember(Order = 16)]
        public Int64? CodigoTemperatura { get; set; }
        [DataMember(Order = 17)]
        public string NombreTemperatura { get; set; }
        [DataMember(Order = 18)]
        public Int64? CodigoClaseIMO { get; set; }
        [DataMember(Order = 19)]
        public string NombreClaseIMO { get; set; }
        [DataMember(Order = 20)]
        public Int64? CodigoNumeroIMO { get; set; }
        [DataMember(Order = 21)]
        public string NombreNumeroIMO { get; set; }
        [DataMember(Order = 22)]
        public Int64? CodigoAlmacenDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 23)]
        public string NombreAlmacen { get; set; }
        [DataMember(Order = 24)]
        public Int64? CodigoDepositoDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 25)]
        public string NombreDeposito { get; set; }
        [DataMember(Order = 26)]
        public Int64? CodigoPrecinto { get; set; }
        [DataMember(Order = 27)]
        public string NumeroPrecinto { get; set; }
        [DataMember(Order = 28)]
        public int? ItemDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 29)]
        public int? CantidadBultoDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 30)]
        public Decimal? PesoBrutoDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 31)]
        public Decimal? VolumenBrutoDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 32)]
        public Decimal? TemperaturaMinimaDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 33)]
        public Decimal? TemperaturaMaximaDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 34)]
        public bool PropietarioDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 35)]
        public string ObservacionDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 36)]
        public string DescripcionDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 37)]
        public string MarcasNumerosDocumentoDetalleCarga { get; set; }
        [DataMember(Order = 38)]
        public bool FaltoDocumentoDetalleCarga { get; set; }
        //[DataMember(Order = 25)]
        //public bool EstadoRegistro { get; set; }
        //[DataMember(Order = 26)]
        //public string UsuarioRegistro { get; set; }
        [DataMember(Order = 39)]
        public string Accion { get; set; }
    }
}
