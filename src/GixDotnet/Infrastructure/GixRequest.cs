namespace GixDotnet.Infrastructure
{
    /// <summary>
    ///     Indicate the structure with the information to make an Http Request within GIX structure.
    /// </summary>
    internal class GixRequest
    {
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