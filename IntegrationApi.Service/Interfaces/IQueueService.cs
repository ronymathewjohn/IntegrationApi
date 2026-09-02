using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationApi.Service.Interfaces
{
    public interface IQueueService
    {
        Task EnqueueAsync(string item);
        Task ReadAll();
    }
}
