using GixDotnet.Infrastructure.Http;
using GixDotnet.Infrastructure.Services;

namespace GixDotnet.Services
{
    internal class DepositServices : BaseServices
    {
        public DepositServices()
        {
        }

        public DepositServices(GixRequestOptions defaultOptions) : base(defaultOptions)
        {
        }
    }
}