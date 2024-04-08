using System.Drawing;
using ds.test.impl;

/// <summary>
/// Abstract base class for plugins, providing common functionality and enforcing the IPlugin contract.
/// </summary>
public abstract class AbstractPlugin : IPlugin
{
    /// <summary>
    /// Initializes a new instance of the AbstractPlugin class with the specified plugin name.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    internal AbstractPlugin(string pluginName)
    {
        PluginName = pluginName;
    }

    /// <summary>
    /// Initializes a new instance of the AbstractPlugin class with the specified plugin name and image.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    /// <param name="image">The image associated with the plugin.</param>
    internal AbstractPlugin(string pluginName, Image image) : this(pluginName)
    {
        Image = image;
    }

    /// <summary>
    /// Initializes a new instance of the AbstractPlugin class with the specified plugin name, image, and version.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    /// <param name="image">The image associated with the plugin.</param>
    /// <param name="version">The version of the plugin.</param>
    internal AbstractPlugin(string pluginName, Image image, string version) : this(pluginName, image)
    {
        Version = version;
    }

    /// <inheritdoc />
    public string PluginName { get; }

    /// <inheritdoc />
    public string Version { get; }

    /// <inheritdoc />
    public Image Image { get; }

    /// <inheritdoc />
    public string Description { get; }

    /// <inheritdoc />
    public abstract int Run(int input1, int input2);
}

