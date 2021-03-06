﻿using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nrk.HttpRequester
{
    public interface IWebRequester
    {
        Task<string> GetResponseAsStringAsync(string path, int retries = 0);
        Task<string> GetResponseAsStringAsync(string pathTemplate, NameValueCollection parameters, int retries = 0);
        Task<HttpResponseMessage> GetResponseAsync(string path, int retries = 0);
        Task<HttpResponseMessage> GetResponseAsync(string pathTemplate, NameValueCollection parameters, int retries = 0);
    }
}
