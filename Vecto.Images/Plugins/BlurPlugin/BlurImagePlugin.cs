using System.Threading.Tasks;
using Vecto.Images.Contract.Plugins;

namespace Vecto.Images.Plugins.BlurPlugin
{
    public class BlurImagePlugin : ImagePlugin
    {
        public override PluginDetails Details => new("Add blur of pixels size", PluginEditorStrategy.RawInput, typeof(BlurPluginData));
        
        public override async Task<byte[]> ProcessImage(byte[] image, string rawData)
        {
            var data = Deserialize<BlurPluginData>(rawData);
            var blurPixels = data.Pixels;
            //todo Do blur by pixels;
            return await Task.FromResult(image);
        }
    }
}