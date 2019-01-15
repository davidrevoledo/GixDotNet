using Newtonsoft.Json;

namespace GixDotnet.Infrastructure.Response
{
    internal class ResponseStatus
    {
        [JsonProperty(PropertyName = "code")]
        public GixHttpResponses Code { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }
    }
}