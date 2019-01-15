using Newtonsoft.Json;

namespace GixDotnet.Entities
{
    public class Product
    {
        [JsonProperty(PropertyName = "procedencia")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "codigoCosecha")]
        public int HarvestCode { get; set; }
    }
}