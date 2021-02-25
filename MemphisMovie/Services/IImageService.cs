using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemphisMovie.Services
{
    public interface IImageService
    {
        Task<byte[]> EncodePosterAsync(IFormFile poster);
        string DecodePoster(byte[] poster, string contentType);
        string RecordContentType(IFormFile poster);
    }
}
