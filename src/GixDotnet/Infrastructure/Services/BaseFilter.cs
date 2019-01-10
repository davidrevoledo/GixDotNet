namespace GixDotnet.Infrastructure.Services
{
    /// <summary>
    ///     Base request params for whole endpoints.
    /// </summary>
    public abstract class BaseFilter
    {
        /// <summary>
        ///     Current sdk version.
        /// </summary>
        public int Version => Versioning.MayorVersion;

        /// <summary>
        ///     Specific minor version, default 4
        /// </summary>
        public Versioning.MinorVersion MinorVersion { get; set; } = Versioning.MinorVersion._4;
    }
}