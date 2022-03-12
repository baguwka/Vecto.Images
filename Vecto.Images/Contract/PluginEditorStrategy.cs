using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Vecto.Images.Contract.Plugins
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PluginEditorStrategy
    {
        Checkbox,
        Slider,
        RawInput
    }
}