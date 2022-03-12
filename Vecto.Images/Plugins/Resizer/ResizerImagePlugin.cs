using System.Threading.Tasks;
using Vecto.Images.Contract.Plugins;

namespace Vecto.Images.Plugins.Resizer
{
    public class ResizerImagePlugin : ImagePlugin
    {
        public override async Task<byte[]> ProcessImage(byte[] image, string rawData)
        {
            var data = Deserialize<ResizerPluginData>(rawData);
            var result = MockResize(image, data.PixelsHeight, data.PixelsWidth);
            return await Task.FromResult(result);
        }

        private byte[] MockResize(byte[] input, int pixelsH, int pixelsW)
        {
            //TODO fake resize;
            return input;
        }

        public override PluginDetails Details => new("Resize to px", PluginEditorStrategy.RawInput, typeof(ResizerPluginData));
    }
}