using GixDotnet.Infrastructure.Http;
using GixDotnet.Infrastructure.Services;

namespace GixDotnet.Services
{
    internal class DocumentServices : BaseServices
    {
        public DocumentServices()
        {
        }

        public DocumentServices(GixRequestOptions defaultOptions) : base(defaultOptions)
        {
        }
    }
}