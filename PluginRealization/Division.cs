
using System.Drawing;

/// <summary>
/// Internal class representing a division plugin.
/// </summary>
internal class DivisionPlugin : AbstractPlugin
{
    /// <summary>
    /// Initializes a new instance of the DivisionPlugin class with the specified plugin name.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    internal DivisionPlugin(string pluginName) : base(pluginName) { }

    /// <summary>
    /// Initializes a new instance of the DivisionPlugin class with the specified plugin name and image.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    /// <param name="image">The image associated with the plugin.</param>
    internal DivisionPlugin(string pluginName, Image image) : base(pluginName, image) { }

    /// <summary>
    /// Initializes a new instance of the DivisionPlugin class with the specified plugin name, image, and version.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    /// <param name="image">The image associated with the plugin.</param>
    /// <param name="version">The version of the plugin.</param>
    internal DivisionPlugin(string pluginName, Image image, string version) : base(pluginName, image, version) { }

    /// <inheritdoc />
    public override int Run(int input1, int input2)
    {
        /// <summary>
        /// Performs division operation on the two input numbers.
        /// </summary>
        /// <param name="input1">The first number.</param>
        /// <param name="input2">The second number (divisor).</param>
        /// <returns>The result of dividing input1 by input2.</returns>
        /// <exception cref="ArgumentException">Thrown if the second number (divisor) is zero.</exception>

        if (input2 == 0)
        {
            throw new ArgumentException("Division by zero is not allowed.");
        }
        return input1 / input2;
    }
}