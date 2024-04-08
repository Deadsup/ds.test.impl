using ds.test.impl;

/// <summary>
/// Plugin factory that implements the IPluginFactory interface.
/// </summary>
internal class PluginFactory : IPluginFactory
{
    /// <summary>
    /// Gets the number of available plugins.
    /// </summary>
    public int PluginsCount => GetPluginNames.Length;

    /// <summary>
    /// Gets an array of names of all available plugins.
    /// </summary>
    public string[] GetPluginNames { get; } = { "sum", "division", "subtraction", "multiple" };

    /// <summary>
    /// Gets a plugin instance by its name.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    /// <returns>The plugin instance or null if not found.</returns>
    public IPlugin GetPlugin(string pluginName)
    {
        pluginName = pluginName.ToLower();
        return pluginName switch
        {
            "sum" => new SumPlugin("Sum"),
            "division" => new DivisionPlugin("Division"),
            "subtraction" => new SubtractionPlugin("Subtraction"),
            "multiple" => new MultiplicationPlugin("Multiplication"),
            _ => null 
        };
    }
}

