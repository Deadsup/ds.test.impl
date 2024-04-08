using ds.test.impl;

/// <summary>
/// Interface that defines a factory for creating plugins.
/// </summary>
public interface IPluginFactory
{
    /// <summary>
    /// Gets the number of available plugins.
    /// </summary>
    int PluginsCount { get; }

    /// <summary>
    /// Gets an array of names of all available plugins.
    /// </summary>
    string[] GetPluginNames { get; }

    /// <summary>
    /// Gets a specific plugin instance by its name.
    /// </summary>
    /// <param name="pluginName">The name of the plugin to retrieve.</param>
    /// <returns>An instance of the requested plugin</returns>
    IPlugin GetPlugin(string pluginName);
}
