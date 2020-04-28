using Cafedebug.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cafedebug.Business.Services
{
    public class FileService : IFileService
    {
        public bool UploadImage(IFormFile arquivo)
        {
			if (arquivo.Length <= 0) return false;

			var imgPrefix = Guid.NewGuid() + "_";

			var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/tmp", imgPrefix + arquivo.FileName);

			if (System.IO.File.Exists(path))
			{
				//aqui você coloca uma notificação de erro
				return false;
			}

			using (var stream = new FileStream(path, FileMode.Create))
			{
				arquivo.CopyToAsync(stream);
			}

			return true;
		}
    }
}
