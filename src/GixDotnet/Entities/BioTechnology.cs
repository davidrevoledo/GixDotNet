using Newtonsoft.Json;

namespace GixDotnet.Entities
{
    public class BioTechnology
    {
        [JsonProperty(PropertyName = "codigoBiotecnologia")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "Porcentaje")]
        public float? Percentage { get; set; }
    }
}