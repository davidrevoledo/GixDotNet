using System.Threading.Tasks;
using GixDotnet.Infrastructure.Http;

namespace GixDotnet.Services.Abstractions
{
    /// <summary>
    ///     Gix Login Services.
    /// </summary>
    public interface ILoginServices
    {
        /// <summary>
        ///     Perform an authentication within.
        /// </summary>
        /// <param name="apiKey">secret key to consume api resources.</param>
        /// <param name="hash">Hash encrypted with SHA256.</param>
        /// <param name="timestamp">time in ticks.</param>
        /// <param name="options">request options.</param>
        /// <returns>Token to consume api resources.</returns>
        Task<string> Login(string apiKey, string hash, int timestamp, GixRequestOptions options = null);
    }
}