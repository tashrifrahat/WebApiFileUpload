using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFileUpload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFilesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> OnPostUploadAsync(IFormFile files)
        {
            //long size = files.Sum(f => f.Length);

            //foreach (var formFile in files)
            //{
            //    if (formFile.Length > 0)
            //    {
                    var fileName = Path.GetRandomFileName();
                    var extension = Path.GetExtension(files.FileName); 
                    var pathBuilt = Path.Combine(Directory.GetCurrentDirectory(), "Upload//Files");
                    
                    if(!Directory.Exists(pathBuilt))
                    {
                        Directory.CreateDirectory(pathBuilt);
                    }
                    var path = Path.Combine(pathBuilt, fileName+extension);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await files.CopyToAsync(stream);
                    }
            //}
            //}

            // Process uploaded files
            // Don't rely on or trust the FileName property without validation.

            //return Ok(new { count = files.Count, size });
            return Ok(fileName);
        }
    }
}
