using IntegrationApi.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace IntegrationApi.Service.Services
{
    public class QueueService : IQueueService
    {
        private readonly Channel<string> _channel;
        
        public QueueService()
        {
            _channel = Channel.CreateUnbounded<string>();  
        }

        public async Task EnqueueAsync(string item)
        {
            await _channel.Writer.WriteAsync(item);
        }

        public async Task ReadAll()
        {
            throw new NotImplementedException();
        }
    }
}
