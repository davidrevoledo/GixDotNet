using Newtonsoft.Json;

namespace GixDotnet.Infrastructure.Response
{
    internal class GixResponse<TD, TM>
    {
        [JsonProperty(PropertyName = "status")]
        public ResponseStatus Status { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public TM MetaData { get; set; }

        [JsonProperty(PropertyName = "data")]
        public TD Data { get; set; }
    }
}