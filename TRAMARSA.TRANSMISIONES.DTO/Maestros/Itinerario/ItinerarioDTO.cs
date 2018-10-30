using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Itinerario
{
    [DataContract]
    public class ItinerarioDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoItinerario { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoNave { get; set; }
        [DataMember(Order = 2)]
        public string NombreNave { get; set; }
        [DataMember(Order = 3)]
        public string NumeroViajeItinerario { get; set; }
        [DataMember(Order = 4)]
        public Int64? CodigoAduana { get; set; }
        [DataMember(Order = 5)]
        public string NombreAduana { get; set; }
        [DataMember(Order = 6)]
        public Int64? CodigoTipoOperacion { get; set; }
        [DataMember(Order = 7)]
        public string NombreTipoOperacion { get; set; }
        [DataMember(Order = 8)]
        public Int64? CodigoTipoLugarCarga { get; set; }
        [DataMember(Order = 9)]
        public string NombreTipoLugarCarga { get; set; }
        [DataMember(Order = 10)]
        public Int64? CodigoOperadorEmbarqueItinerario { get; set; }
        [DataMember(Order = 11)]
        public string NombreOperadorEmbarqueItinerario { get; set; }
        [DataMember(Order = 12)]
        public Int64? CodigoOperadorDescargaItinerario { get; set; }
        [DataMember(Order = 13)]
        public string NombreOperadorDescargaItinerario { get; set; }
        [DataMember(Order = 14)]
        public Int64? CodigoAgenteMaritimoItinerario { get; set; }
        [DataMember(Order = 15)]
        public string NombreAgenteMaritimoItinerario { get; set; }
        [DataMember(Order = 16)]
        public Int64? CodigoTipoLugarCargaPuertoIntermedio { get; set; }
        [DataMember(Order = 17)]
        public string NombreTipoLugarCargaPuertoIntermedio { get; set; }
        [DataMember(Order = 18)]
        public Int64? CodigoPuertoIntermedio { get; set; }
        [DataMember(Order = 19)]
        public string NombrePuertoIntermedio { get; set; }
        [DataMember(Order = 20)]
        public string NumeroManifiestoItinerario { get; set; }
        [DataMember(Order = 21)]
        public Int32? AnioManifiestoItinerario { get; set; }
        [DataMember(Order = 22)]
        public DateTime? FechaArriboItinerario { get; set; }
        [DataMember(Order = 23)]
        public DateTime? FechaZarpeItinerario { get; set; }
        [DataMember(Order = 24)]
        public DateTime? FechaAtraqueItinerario { get; set; }
        [DataMember(Order = 25)]
        public DateTime? FechaTerminoDescargaItinerario { get; set; }
        [DataMember(Order = 26)]
        public string DUEItinerario { get; set; }
        [DataMember(Order = 27)]
        public string CapitanNaveItinerario { get; set; }
        [DataMember(Order = 28)]
        public DateTime? FechaZarpePuertoIntermedio { get; set; }
        [DataMember(Order = 29)]
        public string Voyage { get; set; }
        [DataMember(Order = 30)]
        public string UsuarioCreacion { get; set; }
        [DataMember(Order = 31)]
        public DateTime? FechaHoraCreacion { get; set; }
        [DataMember(Order = 32)]
        public string UsuarioActualizacion { get; set; }
        [DataMember(Order = 32)]
        public DateTime? FechaHoraActualizacion { get; set; }

    }
}
