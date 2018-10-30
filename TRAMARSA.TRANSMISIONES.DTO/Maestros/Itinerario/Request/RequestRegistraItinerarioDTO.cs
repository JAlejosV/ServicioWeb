using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRAMARSA.TRANSMISIONES.DTO.Itinerario.Request
{
    [DataContract]
    public class RequestRegistraItinerarioDTO
    {
        [DataMember(Order = 0)]
        public Int64? CodigoItinerario { get; set; }
        [DataMember(Order = 1)]
        public Int64? CodigoNave { get; set; }
        [DataMember(Order = 2)]
        public Int64? CodigoAduana { get; set; }
        [DataMember(Order = 3)]
        public Int64? CodigoTipoOperacion { get; set; }
        [DataMember(Order = 4)]
        public Int64? CodigoTipoLugarCarga { get; set; }
        [DataMember(Order = 5)]
        public Int64? CodigoOperadorEmbarqueItinerario { get; set; }
        [DataMember(Order = 6)]
        public Int64? CodigoOperadorDescargaItinerario { get; set; }
        [DataMember(Order = 7)]
        public Int64? CodigoAgenteMaritimoItinerario { get; set; }
        [DataMember(Order = 8)]
        public Int64? CodigoTipoLugarCargaPuertoIntermedio { get; set; }
        [DataMember(Order = 9)]
        public Int64? CodigoPuertoIntermedio { get; set; }
        [DataMember(Order = 10)]
        public string NumeroViajeItinerario { get; set; }
        [DataMember(Order = 11)]
        public string NumeroManifiestoItinerario { get; set; }
        [DataMember(Order = 12)]
        public Int32? AnioManifiestoItinerario { get; set; }
        [DataMember(Order = 13)]
        public DateTime? FechaArriboItinerario { get; set; }
        [DataMember(Order = 14)]
        public DateTime? FechaZarpeItinerario { get; set; }
        [DataMember(Order = 15)]
        public DateTime? FechaAtraqueItinerario { get; set; }
        [DataMember(Order = 16)]
        public DateTime? FechaTerminoDescargaItinerario { get; set; }
        [DataMember(Order = 17)]
        public string DUEItinerario { get; set; }
        [DataMember(Order = 18)]
        public string CapitanNaveItinerario { get; set; }
        [DataMember(Order = 19)]
        public DateTime? FechaZarpePuertoIntermedio { get; set; }
        [DataMember(Order = 20)]
        public string Voyage { get; set; }
        [DataMember(Order = 21)]
        public string UsuarioRegistro { get; set; }
        [DataMember(Order = 22)]
        public string Accion { get; set; }
    }
}
