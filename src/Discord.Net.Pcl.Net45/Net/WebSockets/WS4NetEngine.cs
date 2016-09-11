
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Discord.Net.WebSockets
{
    internal class WS4NetEngine : IWebSocketEngine
    {
        public event EventHandler<BinaryMessageEventArgs> BinaryMessage;
        public event EventHandler<TextMessageEventArgs> TextMessage;

        public Task Connect(String host, CancellationToken cancelToken)
        {
            throw new NotImplementedException();
        }

        public Task Disconnect()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Task> GetTasks(CancellationToken cancelToken)
        {
            throw new NotImplementedException();
        }

        public void QueueMessage(String message)
        {
            throw new NotImplementedException();
        }
        internal WS4NetEngine(DiscordConfig config, TaskManager taskManager)
        {
        }
    }
}