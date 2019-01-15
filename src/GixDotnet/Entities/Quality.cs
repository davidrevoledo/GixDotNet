using Newtonsoft.Json;

namespace GixDotnet.Entities
{
    public class Quality
    {
        [JsonProperty(PropertyName = "codigoBolsa")]
        public int StockExchangeCode { get; set; }

        [JsonProperty(PropertyName = "idEnsayo")]
        public string TestId { get; set; }

        [JsonProperty(PropertyName = "codigoRubroCalidad1")]
        public string QualityItemCode1 { get; set; }

        [JsonProperty(PropertyName = "codigoRubroCalidad2")]
        public string QualityItemCode2 { get; set; }

        [JsonProperty(PropertyName = "codigoRubroCalidad3")]
        public string QualityItemCode3 { get; set; }

        [JsonProperty(PropertyName = "tipoRubroCalidad")]
        public string QualityItemType { get; set; }

        [JsonProperty(PropertyName = "kilosMermaRubroCalidad")]
        public string QualityItemDropKgs { get; set; }

        [JsonProperty(PropertyName = "camara")]
        public int? Camera { get; set; }

        [JsonProperty(PropertyName = "resultadoEnPlanta")]
        public int? PlantResult { get; set; }

        [JsonProperty(PropertyName = "factorRubroCalidad")]
        public int? QualityItemFactor { get; set; }
    }
}