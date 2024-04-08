using ds.test.impl;

/// <summary>
/// Static class providing access to plugin functionality through a PluginFactory instance.
/// </summary>
public static class StatisPluginFactory
{
    /// <summary>
    /// Private readonly instance of the PluginFactory 
    /// </summary>
    private static readonly PluginFactory factory = new PluginFactory();

    /// <summary>
    /// Gets the number of available plugins, delegated to the internal PluginFactory instance.
    /// </summary>
    public static int PluginsCount => factory.PluginsCount;

    /// <summary>
    /// Gets an array of names of all available plugins, delegated to the internal PluginFactory instance.
    /// </summary>
    public static string[] GetPluginNames => factory.GetPluginNames;

    /// <summary>
    /// Gets a plugin instance by its name, delegated to the internal PluginFactory instance.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    /// <returns>The plugin instance or null if not found.</returns>
    public static IPlugin GetPlugin(string pluginName)
    {
        return factory.GetPlugin(pluginName);
    }
}