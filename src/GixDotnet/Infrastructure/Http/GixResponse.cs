using GixDotnet.Infrastructure.Http;
using Newtonsoft.Json;

namespace GixDotnet.Infrastructure.Response
{
    internal class GixResponse
    {
        [JsonProperty(PropertyName = "status")]
        public ResponseStatus Status { get; set; }
    }

    internal class GixResponse<TD> : GixResponse
    {
        [JsonProperty(PropertyName = "metadata")]
        public Metadata MetaData { get; set; }

        [JsonProperty(PropertyName = "data")]
        public TD Data { get; set; }
    }
}