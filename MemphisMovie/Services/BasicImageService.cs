using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MemphisMovie.Services
{
    public class BasicImageService : IImageService
    {
        public string DecodePoster(byte[] poster, string contentType)
        {
            //if (poster == null)
            if (poster is null)
            {
                return null;
            }
            var posterImage = Convert.ToBase64String(poster);
            return $"data:{contentType};base64,{posterImage}";
        }

        public async Task<byte[]> EncodePosterAsync(IFormFile poster)
        {
            if (poster is null)
            {
                return null;
            }
            using var ms = new MemoryStream();
            await poster.CopyToAsync(ms);
            return ms.ToArray();
        }

        public string RecordContentType(IFormFile poster)
        {
            if (poster is null)
            {
                return null;
            }
            return poster.ContentType;
        }
    }
}
