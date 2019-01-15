using GixDotnet.Infrastructure.Http;
using GixDotnet.Infrastructure.Services;

namespace GixDotnet.Services
{
    internal class InvoiceServices : BaseServices
    {
        public InvoiceServices()
        {
        }

        public InvoiceServices(GixRequestOptions defaultOptions) : base(defaultOptions)
        {
        }
    }
}