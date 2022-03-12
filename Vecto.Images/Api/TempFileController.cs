using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vecto.Images.Contract;

namespace Vecto.Images.Api
{
    [Microsoft.AspNetCore.Components.Route("/api/v1/temp-files")]
    public class TempFileController
    {
        [HttpPost]
        public async Task<FilePrimitive> Upload(IFormFile file)
        {
            
        }
    }
    
}