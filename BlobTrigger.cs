using System;
using Azure.Storage.Queues.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace BlobTrigger
{
    public class BlobTrigger
    {
        private readonly ILogger<BlobTrigger> _logger;

        public BlobTrigger(ILogger<BlobTrigger> logger)
        {
            _logger = logger;
        }

        [Function(nameof(BlobTrigger))]
        public void Run([QueueTrigger("fani-test", Connection = "BlobStorageEndpoint")] QueueMessage message)
        {
            _logger.LogInformation($"C# Queue trigger function processed: {message.MessageText}");
        }
    }
}
