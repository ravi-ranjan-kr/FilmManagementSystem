using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FilmManagementSystem.Repositories
{
    public class UploadBlob
    {
        private readonly ILogger _logger;

        public IConfiguration _configuration;

        public BlobServiceClient _client;

        public BlobContainerClient _containerClient;
        private readonly string _blobConnectionString;
        private readonly string _containerName;
        public UploadBlob(IConfiguration _configuration,
            ILogger<UploadBlob> logger)
        {
            _logger = logger;
            _blobConnectionString = _configuration["blobConnectionString"];
            _containerName = _configuration["containerName"];
        }

        public async Task<string> UploadFileToBlobAsync(Stream fileStream, string fileName, string contentType)
        {
            try
            {
                var container = new BlobContainerClient(_blobConnectionString, _containerName);
                var createResponse = await container.CreateIfNotExistsAsync();
                if (createResponse != null && createResponse.GetRawResponse().Status == 201)
                    await container.SetAccessPolicyAsync(PublicAccessType.Blob);
                var blob = container.GetBlobClient(fileName);
                await blob.DeleteIfExistsAsync(DeleteSnapshotsOption.IncludeSnapshots);
                await blob.UploadAsync(fileStream, new BlobHttpHeaders { ContentType = contentType });
                return blob.Uri.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
