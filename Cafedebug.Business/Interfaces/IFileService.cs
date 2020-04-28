using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafedebug.Business.Interfaces
{
    public interface IFileService
    {
        bool UploadImage(IFormFile arquivo);
    }
}
