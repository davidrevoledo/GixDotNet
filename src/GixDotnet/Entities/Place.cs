using Newtonsoft.Json;

namespace GixDotnet.Entities
{
    public class Place
    {
        [JsonProperty(PropertyName = "establecimiento")]
        public string Establishment { get; set; }

        [JsonProperty(PropertyName = "codigoPlantaOncca")]
        public int OnccaPlantCode { get; set; }

        [JsonProperty(PropertyName = "direccion")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "codigoLocalidad")]
        public int LocationCode { get; set; }

        [JsonProperty(PropertyName = "codigoPostalLocalidad")]
        public string LocationZipCode { get; set; }

        [JsonProperty(PropertyName = "subcodigoPostalLocalidad")]
        public string LocationSubZipCode { get; set; }

        [JsonProperty(PropertyName = "codigoProvincia")]
        public string ProvinceCode { get; set; }
    }
}