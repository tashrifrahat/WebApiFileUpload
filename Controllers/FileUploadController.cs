//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.IO;
//using System.Threading;
//using System.Threading.Tasks;

//namespace WebApiFileUpload.Controllers
//{
//    //[Route("api/[controller]")]
//    [ApiController]
//    public class FileUploadController : ControllerBase
//    {
//        [HttpPost]
//        [Route("SaveFile")]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]

//        public async Task<IActionResult> UploadFile(IFormFile file, CancellationToken cancellationToken)
//        {
//            await WriteFile(file);

//            return Ok();
//        }

//        private async Task<bool> WriteFile(IFormFile file)
//        {
//            bool isSaveSuccess = false;
//            string fileName;
//            try
//            {
//                var extension = '.' + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
//                fileName = DateTime.Now.Ticks + extension; //create a new name for uploded files

//                var pathBuilt = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\files");

//                if(!Directory.Exists(pathBuilt))
//                {
//                    Directory.CreateDirectory(pathBuilt);
//                }

//                var path = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\files",fileName);
//                Random.ReferenceEquals(path, Path.GetRandomFileName());
//                using(var stream = new FileStream(path,FileMode.Create))
//                {
//                    await file.CopyToAsync(stream);
//                }
//                isSaveSuccess = true;
//            }
//            catch(Exception e)
//            {

//            }
//            return isSaveSuccess;
//        }
        

        

//    }
//}
