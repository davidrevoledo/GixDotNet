using System;
using System.Collections.Generic;
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
        private int _minorVersion;
        private BaseUrlParams _params = BaseUrlParams.Create();
        private string _resource;
        private Uri _uri;

        public GixUrlBuilder MayorVersion(int version)
        {
            Guard.Ensures(version > 1);
            _mayorVersion = version;
            return this;
        }

        public GixUrlBuilder MinorVersion(Versioning.MinorVersion minorVersion)
        {
            var version = (int) minorVersion;
            Guard.Ensures(version >= 0);
            _minorVersion = version;
            return this;
        }

        public GixUrlBuilder Resource(string resource)
        {
            Guard.Ensures(!resource.Contains(VersionFormat));
            _resource = resource;
            return this;
        }

        public GixUrlBuilder CompanyUrl(Uri uri)
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

            _stringBuilder.Replace(CompanyUrlFormat, _uri.AbsoluteUri);
            _stringBuilder.Replace(ResourceFormat, $"{_mayorVersion}.{_minorVersion}");
            _stringBuilder.Replace(ResourceFormat, _resource);

            return _stringBuilder.ToString();
        }
    }
}