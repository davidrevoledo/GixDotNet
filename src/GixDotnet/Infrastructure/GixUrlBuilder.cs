using System;
using System.Runtime.InteropServices;
using System.Text;
using GixDotnet.Infrastructure.Services;

namespace GixDotnet.Infrastructure
{
    /// <summary>
    ///     Gix Url Builder to reach an Gix Endpoint keeping in mind
    ///     Company Url
    ///     Versioning
    ///     Resourcing.
    /// </summary>
    [ComVisible(true)]
    [Serializable]
    public sealed class GixUrlBuilder
    {
        private const string VersionFormat = "{version}";
        private const string ResourceFormat = "{version}";
        private const string CompanyUrlFormat = "{version}";

        private readonly StringBuilder _stringBuilder =
            new StringBuilder($"{CompanyUrlFormat}/{VersionFormat}/{ResourceFormat}");

        private int _mayorVersion = 1;
        private BaseUrlParams _params = BaseUrlParams.Create();
        private string _resource;
        private string _uri;

        public GixUrlBuilder MayorVersion(int version)
        {
            Guard.Ensures(version > 1);
            _mayorVersion = version;
            return this;
        }

        public GixUrlBuilder Resource(string resource)
        {
            Guard.Ensures(!resource.Contains(VersionFormat));
            _resource = resource;
            return this;
        }

        public GixUrlBuilder CompanyUrl(string uri)
        {
            _uri = uri;
            return this;
        }

        public GixUrlBuilder Filters(BaseUrlParams filters)
        {
            _params = filters;
            return this;
        }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(_resource))
                throw new InvalidOperationException("Please complete resource first");

            if (_uri == null)
                throw new InvalidOperationException("Please complete company url first");

            const int minor = (int) Versioning.MinorVersion._4;
            _stringBuilder.Replace(CompanyUrlFormat, _uri);
            _stringBuilder.Replace(ResourceFormat, $"{_mayorVersion}.{minor}");
            _stringBuilder.Replace(ResourceFormat, _resource);

            return _stringBuilder.ToString();
        }
    }
}