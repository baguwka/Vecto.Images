using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Vecto.Images.Contract.Plugins;

namespace Vecto.Images.Api
{
    [Route("api/v1/images")]
    public class ImageController : ControllerBase
    {
        private readonly IPluginCollection _pluginCollection;

        public ImageController(
            IPluginCollection pluginCollection
            )
        {
            _pluginCollection = pluginCollection;
        }
        
        [HttpGet("editor")]
        public async Task<EditorDto> GetEditor()
        {
            var plugins = _pluginCollection.GetPlugins();

            var dto = new EditorDto
            {
                Fields = plugins
                    .Select(x =>
                    {
                        var details = x.Details;
                        return new PluginFieldEditorDto
                        {
                            Key = details.DataType.FullName!,
                            Name = details.Name,
                            EditorStrategy = details.EditorStrategy,
                            Value = JObject.FromObject(Activator.CreateInstance(details.DataType))
                        };
                    }).ToArray()
            };

            return await Task.FromResult(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Apply(
            IFormFile file,
            [ModelBinder(BinderType = typeof(JsonModelBinder))]
            ApplyImageDto data
        )
        {
            var bytes = await GetBytes(file);

            var processedImage = bytes;
            
            foreach (var field in data.Fields)
            {
                var plugin = _pluginCollection.GetPlugin(field.Key);
                processedImage = await plugin.ProcessImage(processedImage, field.Value.ToString());
            }
            
            return new FileContentResult(processedImage, file.ContentType);
        }

        private static async Task<byte[]> GetBytes(IFormFile formFile)
        {
            await using var memoryStream = new MemoryStream();
            await formFile.CopyToAsync(memoryStream);
            return memoryStream.ToArray();
        }
    }
}