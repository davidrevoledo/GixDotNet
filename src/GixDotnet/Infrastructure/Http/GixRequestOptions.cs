namespace GixDotnet.Infrastructure.Http
{
    /// <summary>
    ///     GIX request options.
    /// </summary>
    public class GixRequestOptions
    {
        /// <summary>
        ///     Base company url where go through the resources.
        /// </summary>
        public string BaseUrl { get; set; }

        /// <summary>
        ///     Indicate gix request version, default 1.
        /// </summary>
        public int Version { get; set; } = 1;

        /// <summary>
        ///     Indicate the Security Identifier for the data owner.
        /// </summary>
        public string ApiKey { get; internal set; }
    }
}