using Vecto.Images.Contract.Plugins;

namespace Vecto.Images.Plugins.Resizer
{
    public class ResizerPluginData : IPluginDataObject
    {
        public int PixelsHeight { get; set; }
        public int PixelsWidth { get; set; }
    }
}