using System;

namespace Vecto.Images.Contract.Plugins
{
    public record PluginDetails
    {
        public PluginDetails(
            string name,
            PluginEditorStrategy editorStrategy, 
            Type dataType
        )
        {
            DataType = dataType;
            Name = name;
            EditorStrategy = editorStrategy;
        }

        public Type DataType;
        public string Name { get; }
        public PluginEditorStrategy EditorStrategy { get; } 
    }
}