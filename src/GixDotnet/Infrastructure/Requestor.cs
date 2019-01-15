using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GixDotnet.Infrastructure.Http;
using Newtonsoft.Json;

namespace GixDotnet.Infrastructure
{
    /// <summary>
    ///     Requestor middleware to interact with HttpEngine
    /// </summary>
    internal static class Requestor
    {
        static Requestor()
        {
            HttpClient =
                PrimaryBackOfficeConfigurations.HttpMessageHandler != null
                    ? new HttpClient(PrimaryBackOfficeConfigurations.HttpMessageHandler)
                    : new HttpClient();

            if (PrimaryBackOfficeConfigurations.HttpTimeSpan.HasValue)
                HttpClient.Timeout = PrimaryBackOfficeConfigurations.HttpTimeSpan.Value;
        }

        internal static HttpClient HttpClient { get; }

        public static Task<GixResponse<T>> GetStringAsync<T>(
            string url,
            GixRequestOptions options)
        {
            var wr = GetRequestMessage(url, HttpMethod.Get, options);
            return ExecuteRequestAsync<T>(wr);
        }

        public static Task<GixResponse<T>> PostStringAsync<T>(
            string url,
            GixRequestOptions options,
            object data = null)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post, options, data);
            return ExecuteRequestAsync<T>(wr);
        }

        private static async Task<GixResponse<T>> ExecuteRequestAsync<T>(HttpRequestMessage requestMessage)
        {
            var response = await HttpClient.SendAsync(requestMessage).ConfigureAwait(false);
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            var result = JsonConvert.DeserializeObject<GixResponse<T>>(responseText);

            if (result == null)
                throw new PrimaryException("The response was not in a proper format");

            if (result.Status.ToUpper() != "OK")
                throw new PrimaryException($"Error in Primary BackOffice api : {result.ErrorDescription}");

            return result;
        }

        private static HttpRequestMessage GetRequestMessage(
            string url,
            HttpMethod method,
            GixRequestOptions options,
            object data = null)
        {
            var request = BuildRequest(method, $"{url}", data);

            var client = new Client(request);
            client.ApplyUserAgent();
            client.ApplyClientData();

            if (!string.IsNullOrWhiteSpace(options.Token))
                request.Headers.Add("Authorization", new List<string>
                {
                    $"Token {options.Token}"
                });

            if (!string.IsNullOrWhiteSpace(options.User) && !string.IsNullOrWhiteSpace(options.Password))
                request.Headers.Add("Authorization", new List<string>
                {
                    $"Basic {options.User}:{options.Password}"
                });

            return request;
        }

        private static HttpRequestMessage BuildRequest(HttpMethod method, string url, object data)
        {
            if (method != HttpMethod.Post)
                return new HttpRequestMessage(method, new Uri(url));

            var request = default(HttpRequestMessage);

            if (data != null)
            {
                var postData = JsonConvert.SerializeObject(data);
                request = new HttpRequestMessage(method, new Uri(url))
                {
                    Content = new StringContent(postData, Encoding.UTF8, "application/json")
                };
            }
            else if (!string.IsNullOrEmpty(new Uri(url).Query))
            {
                var postData = new Uri(url).Query.Substring(1);
                var newUrl = url.Substring(0, url.IndexOf("?", StringComparison.CurrentCultureIgnoreCase));

                request = new HttpRequestMessage(method, new Uri(newUrl))
                {
                    Content = new StringContent(postData, Encoding.UTF8, "application/json")
                };
            }

            return request;
        }
    }
}