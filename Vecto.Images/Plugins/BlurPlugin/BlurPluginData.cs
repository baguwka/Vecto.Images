using Vecto.Images.Contract.Plugins;

namespace Vecto.Images.Plugins.BlurPlugin
{
    public class BlurPluginData : IPluginDataObject
    {
        public int Pixels { get; set; }
    }
}