using Newtonsoft.Json;

namespace GixDotnet.Entities
{
    public class Service
    {
        [JsonProperty(PropertyName = "codigoTipoItemServicios")]
        public int ItemCode { get; set; }

        [JsonProperty(PropertyName = "metodoDescuentoServicio")]
        public string DiscountMethod { get; set; }

        [JsonProperty(PropertyName = "kilosDescuentoPorServicio")]
        public int DiscountKgsPerService { get; set; }
    }
}