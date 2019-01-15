using Newtonsoft.Json;

namespace GixDotnet.Entities
{
    public class Actor
    {
        [JsonProperty(PropertyName = "cuit")]
        public long Identifier { get; set; }

        [JsonProperty(PropertyName = "razonSocial")]
        public string Name { get; set; }
    }
}