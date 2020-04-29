using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cafedebug.Business.Interfaces
{
    public interface IFileService
    {
        bool UploadImage(IFormFile arquivo);
        Task UploadImageS3(IFormFile file);
    }
}
