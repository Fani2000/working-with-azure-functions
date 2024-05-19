using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace BlobTrigger
{
    public class GetBlobFile
    {
        private readonly ILogger<GetBlobFile> _logger;

        public GetBlobFile(ILogger<GetBlobFile> logger)
        {
            _logger = logger;
        }

        [Function(nameof(GetBlobFile))]
        public async Task Run([BlobTrigger("fani-container/{name}", Connection = "BlobStorageEndpoint")] Stream stream, string name)
        {
            /*
            using var blobStreamReader = new StreamReader(stream);
            var content = await blobStreamReader.ReadToEndAsync();
            */
            _logger.LogInformation($"C# Blob trigger function Processed blob\n Name: {name}");
        }
    }
}
