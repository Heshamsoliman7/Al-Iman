using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Al_Iman.Utilities
{
    public class ImageOperations
    {
        IWebHostEnvironment _env;

        public ImageOperations(IWebHostEnvironment env)
        {
            _env = env;
        }
        public string ImageUpload(IFormFile file)
        {
            string filename = null;
            if (file != null)
            {
                string fileDirectory = Path.Combine(_env.WebRootPath, "Images");
                filename = Guid.NewGuid() + "-" + file.FileName;
                string filepath = Path.Combine(fileDirectory, filename);
                using (FileStream fs = new FileStream(filepath, FileMode.Create))
                {
                    file.CopyToAsync(fs);
                }
            }
            return filename;
        }
    }

}
