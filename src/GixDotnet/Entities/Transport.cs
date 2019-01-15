using Newtonsoft.Json;

namespace GixDotnet.Entities
{
    public class Transport
    {
        [JsonProperty(PropertyName = "incisoCTG")]
        public string CGTClause { get; set; }

        [JsonProperty(PropertyName = "codigoMedioTransporte")]
        public string TransportationCode { get; set; }

        [JsonProperty(PropertyName = "patenteCamion")]
        public string TruckPlateNumber { get; set; }

        [JsonProperty(PropertyName = "patenteAcoplado")]
        public string TrailerPlateNumber { get; set; }

        [JsonProperty(PropertyName = "numeroVagonOBarcaza")]
        public int WagonOrBargeNumber { get; set; }

        [JsonProperty(PropertyName = "nombreOperativoOConvoy")]
        public string OperativeOrConvoyNumber { get; set; }
    }
}