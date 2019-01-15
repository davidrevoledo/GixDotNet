using System.Net.Http;
using System.Threading.Tasks;

namespace GixDotnet.Infrastructure.Http
{
    /// <summary>
    ///     Interface to interact over http protocol with external api resources.
    /// </summary>
    public interface IHttpEngine
    {
        /// <summary>
        ///     Process an http request message.
        ///     This allow for the external client to use the desired http client and the lifetime that suit better the
        ///     application.
        /// </summary>
        /// <returns>HttpResponse message</returns>
        Task<HttpResponseMessage> Process(HttpRequestMessage request);
    }
}