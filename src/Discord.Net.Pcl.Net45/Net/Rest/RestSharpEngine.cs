
using Discord.Logging;
using Nito.AsyncEx;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Discord.Net.Rest
{
    internal class RestSharpEngine : IRestEngine
    {
        private string baseUrl;
        private DiscordConfig config;
        private ILogger logger;

        public RestSharpEngine(DiscordConfig config, string baseUrl, ILogger logger)
        {
            this.config = config;
            this.baseUrl = baseUrl;
            this.logger = logger;
        }

        public Task<string> Send(string method, string path, string json, CancellationToken cancelToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> SendFile(string method, string path, string filename, Stream stream, CancellationToken cancelToken)
        {
            throw new NotImplementedException();
        }

        public void SetToken(string token)
        {
            throw new NotImplementedException();
        }
    }

}
