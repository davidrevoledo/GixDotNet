using GixDotnet.Infrastructure.Http;
using GixDotnet.Infrastructure.Services;

namespace GixDotnet.Services
{
    internal class AnalysisServices : BaseServices
    {
        public AnalysisServices()
        {
        }

        public AnalysisServices(GixRequestOptions defaultOptions) : base(defaultOptions)
        {
        }
    }
}