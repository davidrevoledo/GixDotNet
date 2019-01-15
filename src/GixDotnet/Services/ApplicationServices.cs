using GixDotnet.Infrastructure.Http;
using GixDotnet.Infrastructure.Services;

namespace GixDotnet.Services
{
    internal class ApplicationServices : BaseServices
    {
        public ApplicationServices()
        {
        }

        public ApplicationServices(GixRequestOptions defaultOptions) : base(defaultOptions)
        {
        }
    }
}