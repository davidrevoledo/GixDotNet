using Newtonsoft.Json;

namespace GixDotnet.Entities
{
    public partial class Unload
    {
        public class AuxiliaryData
        {
            [JsonProperty(PropertyName = "datosAuxiliares")]
            public Complex ComplexData { get; set; }

            [JsonProperty(PropertyName = "datosAuxiliares")]
            public string SimpleData { get; set; }

            public class Complex
            {
                [JsonProperty(PropertyName = "codigo")]
                public int Code { get; set; }

                [JsonProperty(PropertyName = "descripcion")]
                public string Description { get; set; }
            }
        }
    }
}