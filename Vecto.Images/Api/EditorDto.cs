using System;

namespace Vecto.Images.Api
{
    public class EditorDto
    {
        public PluginFieldEditorDto[] Fields { get; set; } = Array.Empty<PluginFieldEditorDto>();
    }
}