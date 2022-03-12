using Vecto.Images.Contract.Plugins;

namespace Vecto.Images.Api
{
    public class PluginFieldEditorDto : PluginFieldDto
    {
        public string Name { get; set; }
        public PluginEditorStrategy EditorStrategy { get; set; }
    }
}