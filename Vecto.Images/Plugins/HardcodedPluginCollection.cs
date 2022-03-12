using System;
using System.Collections.Generic;
using System.Linq;
using Vecto.Images.Contract.Plugins;
using Vecto.Images.Plugins.BlurPlugin;
using Vecto.Images.Plugins.GrayscalePlugin;
using Vecto.Images.Plugins.Resizer;

namespace Vecto.Images.Plugins
{
    public class HardcodedPluginCollection : IPluginCollection
    {
        private readonly Lazy<Dictionary<string, ImagePlugin>> _collection =
            new(ValueFactory);

        private static Dictionary<string, ImagePlugin> ValueFactory()
        {
            return new ImagePlugin[]
            {
                new ResizerImagePlugin(),
                new BlurImagePlugin(),
                new GrayscaleImagePlugin()
            }.ToDictionary(x => x.Details.DataType.FullName!, x => x);
        }

        public ImagePlugin[] GetPlugins()
        {
            return _collection.Value.Values.ToArray();
        }

        /// <exception cref="InvalidOperationException"></exception>
        public ImagePlugin GetPlugin(string key)
        {
            if (_collection.Value.ContainsKey(key))
            {
                return _collection.Value[key];
            }

            throw new InvalidOperationException($"There is no plugin with key {key}");
        }
    }
}