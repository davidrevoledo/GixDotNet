using System.Threading.Tasks;
using GixDotnet.Infrastructure;
using GixDotnet.Infrastructure.Http;
using GixDotnet.Infrastructure.Services;
using GixDotnet.Services.Abstractions;

namespace GixDotnet.Services
{
    /// <inheritdoc cref="ILoginServices" />
    internal class LoginServices : BaseServices, ILoginServices
    {
        public LoginServices()
        {
        }

        public LoginServices(GixRequestOptions defaultOptions) : base(defaultOptions)
        {

        }

        /// <inheritdoc cref="ILoginServices" />
        public async Task<string> Login(string apiKey, string hash, int timestamp, GixRequestOptions options = null)
        {
            var configs = SetupRequestOptions(options);

            var urlBuilder = new GixUrlBuilder()
                .CompanyUrl(configs.BaseUrl)
                .MayorVersion(configs.Version)
                .Resource(Urls.Login);

            var url = urlBuilder.ToString();

            var response = await Requestor.PostStringAsync<string>(
                    url,
                    configs)
                .ConfigureAwait(false);

            return response.Data;
        }
    }
}