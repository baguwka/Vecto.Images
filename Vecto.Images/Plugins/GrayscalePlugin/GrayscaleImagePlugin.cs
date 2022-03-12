using System.Threading.Tasks;
using Vecto.Images.Contract.Plugins;

namespace Vecto.Images.Plugins.GrayscalePlugin
{
    public class GrayscaleImagePlugin : ImagePlugin
    {
        public override PluginDetails Details => new("Convert to grayscale", PluginEditorStrategy.Checkbox, typeof(GrayscalePluginData));
        
        public override async Task<byte[]> ProcessImage(byte[] image, string rawData)
        {
            var data = Deserialize<GrayscalePluginData>(rawData);
            var isToApply = data.Apply;
            //TODO apply grayscale over original image if its selected
            return await Task.FromResult(image);
        }
    }
}