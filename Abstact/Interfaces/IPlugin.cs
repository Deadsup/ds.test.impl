namespace ds.test.impl
{

/// <summary>
/// Interface that defines a plugin contract.
/// </summary>
public interface IPlugin
{
    /// <summary>
    /// Gets the name of the plugin.
    /// </summary>
    string PluginName { get; }

    /// <summary>
    /// Gets the version of the plugin.
    /// </summary>
    string Version { get; }

    /// <summary>
    /// Gets the image associated with the plugin.
    /// </summary>
    System.Drawing.Image Image { get; }

    /// <summary>
    /// Gets the description of the plugin.
    /// </summary>
    string Description { get; }

    /// <summary>
    /// Runs the plugin with the specified inputs.
    /// </summary>
    /// <param name="input1">The number on which the mathematical operation will be performed.</param>
    /// <param name="input2">The second input value.</param>
    /// <returns>The output of the plugin.</returns>
    int Run(int input1, int input2);
}
}

