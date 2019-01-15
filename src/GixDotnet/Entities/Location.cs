using Newtonsoft.Json;

namespace GixDotnet.Entities
{
    public class Location
    {
        [JsonProperty(PropertyName = "codigoLocalidad")]
        public int CityCode { get; set; }

        [JsonProperty(PropertyName = "codigoPostal")]
        public string ZipCode { get; set; }

        [JsonProperty(PropertyName = "subcodigoPostal")]
        public string SubZipCode { get; set; }
    }
}