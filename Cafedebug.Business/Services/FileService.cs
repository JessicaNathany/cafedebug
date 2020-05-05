using Amazon.S3;
using Amazon.S3.Transfer;
using Cafedebug.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Cafedebug.Business.Services
{
    public class FileService : BaseService, IFileService
    {
		private readonly IAmazonS3 _s3Client;
		public FileService(IAmazonS3 s3Client, INotifier notifier) : base(notifier)
		{
            _s3Client = s3Client;
		}
		public bool UploadImage(IFormFile arquivo)
        {
			if (arquivo.Length <= 0) return false;

			var imgPrefix = Guid.NewGuid() + "_";

			var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/tmp", imgPrefix + arquivo.FileName);

			if (System.IO.File.Exists(path))
			{
                Notify("Já existe um arquivo com esse nome.");

                return false;
			}

			using (var stream = new FileStream(path, FileMode.Create))
			{
				arquivo.CopyTo(stream);
			}

			return true;
		}

        public async Task UploadImageS3(IFormFile file)
        {
            var bucketName = "Upload";
            try
            {
                var fileTransferUtility =
                    new TransferUtility(_s3Client);

                // Option 1. Upload a file. The file name is used as the object key name.
                //await fileTransferUtility.UploadAsync(file, bucketName);
                //Console.WriteLine("Upload 1 completed");

                // Option 2. Specify object key name explicitly.
                //await fileTransferUtility.UploadAsync(path, bucketName, keyName);
                //Console.WriteLine("Upload 2 completed");

                //  Option 3.Upload data from a type of System.IO.Stream.

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/tmp", file.FileName);

                using (var stream = new FileStream(path, FileMode.Open))
                {
                    await fileTransferUtility.UploadAsync(stream, bucketName, file.FileName);
                }
                Console.WriteLine("Upload 3 completed");

                // Option 4. Specify advanced settings.
                //var fileTransferUtilityRequest = new TransferUtilityUploadRequest
                //{
                //    BucketName = bucketName,
                //    FilePath = path,
                //    StorageClass = S3StorageClass.StandardInfrequentAccess,
                //    PartSize = 6291456, // 6 MB.
                //    Key = keyName,
                //    CannedACL = S3CannedACL.PublicRead
                //};
                //fileTransferUtilityRequest.Metadata.Add("param1", "Value1");
                //fileTransferUtilityRequest.Metadata.Add("param2", "Value2");

                //await fileTransferUtility.UploadAsync(fileTransferUtilityRequest);
                //Console.WriteLine("Upload 4 completed");
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error encountered on server. Message:'{0}' when writing an object", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
            }

        }
    }
}
	

