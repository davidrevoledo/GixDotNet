using Newtonsoft.Json;

namespace GixDotnet.Infrastructure.Http
{
    public class Metadata
    {
        [JsonProperty(PropertyName = "pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }

        [JsonProperty(PropertyName = "totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty(PropertyName = "totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty(PropertyName = "nextPageLink")]
        public string NextPageLink { get; set; }

        [JsonProperty(PropertyName = "lastPageLink")]
        public string LastPageLink { get; set; }
    }
}