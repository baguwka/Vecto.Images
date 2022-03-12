using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Vecto.Images.Contract.Plugins
{
    /// <summary>
    /// Base class for plugins
    /// </summary>
    public abstract class ImagePlugin
    {
        public abstract PluginDetails Details { get; }
        public abstract Task<byte[]> ProcessImage(byte[] image, string rawData);
        
        protected T Deserialize<T>(string rawData) where T : IPluginDataObject 
        {
            return JsonConvert.DeserializeObject<T>(rawData);
        }
    }
}