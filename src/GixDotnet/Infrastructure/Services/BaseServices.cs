using GixDotnet.Infrastructure.Http;

namespace GixDotnet.Infrastructure.Services
{
    /// <summary>
    ///     Base Services.
    /// </summary>
    public abstract class BaseServices
    {
        protected BaseServices()
        {
        }

        protected BaseServices(GixRequestOptions defaultOptions)
        {
            DefaultOptions = defaultOptions;
        }

        protected GixRequestOptions DefaultOptions { get; set; }

        protected GixRequestOptions SetupRequestOptions(GixRequestOptions gixRequestOptions)
        {
            return gixRequestOptions ??
                   new GixRequestOptions
                   {
                       BaseUrl = DefaultOptions?.BaseUrl,
                       ApiKey = DefaultOptions?.ApiKey,
                       Version = DefaultOptions?.Version ?? 1
                   };
        }
    }
}