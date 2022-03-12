using Newtonsoft.Json.Linq;

namespace Vecto.Images.Api
{
    public class PluginFieldDto
    {
        public string Key { get; set; }
        public JObject Value { get; set; }
    }
}