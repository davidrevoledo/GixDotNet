using GixDotnet.Infrastructure.Http;

namespace GixDotnet
{
    /// <summary>
    ///     Global context for the sdk
    /// </summary>
    public static class GitContext
    {
        internal static IHttpEngine GetHttpEngine()
        {
            return null;
        }
    }
}