using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace BookSwap.API.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(IFormFile file)
        {
            try
            {
                using (var input = new MemoryStream())
                {
                    file.CopyTo(input);
                    input.Position = 0;

                    using (var result = new MemoryStream())
                    {
                        PhotoSauce.MagicScaler.MagicImageProcessor.ProcessImage(input, result, new PhotoSauce.MagicScaler.ProcessImageSettings { Height = 250 });

                        var bytes = result.ToArray();
                        var str = "data:image/png;base64," + Convert.ToBase64String(bytes);
                    
                        return Ok(str);
                    }
                }
            }
            catch(Exception)
            {
                return BadRequest("Invalid file type. Please be sure to upload an image.");
            }
        }
    }
}