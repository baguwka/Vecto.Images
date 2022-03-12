using System;

namespace Vecto.Images.Contract.Plugins
{
    public interface IPluginCollection
    {
        ImagePlugin[] GetPlugins();
        /// <exception cref="InvalidOperationException">Occurs when there is no such plugin with key</exception>
        ImagePlugin GetPlugin(string key);
    }
}