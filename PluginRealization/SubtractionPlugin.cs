
using System.Drawing;

/// <summary>
/// Internal class representing a subtraction plugin.
/// </summary>
internal class SubtractionPlugin : AbstractPlugin
{
    /// <summary>
    /// Initializes a new instance of the SubtractionPlugin class with the specified plugin name.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    internal SubtractionPlugin(string pluginName) : base(pluginName) { }

    /// <summary>
    /// Initializes a new instance of the SubtractionPlugin class with the specified plugin name and image.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    /// <param name="image">The image associated with the plugin.</param>
    internal SubtractionPlugin(string pluginName, Image image) : base(pluginName, image) { }

    /// <summary>
    /// Initializes a new instance of the SubtractionPlugin class with the specified plugin name, image, and version.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    /// <param name="image">The image associated with the plugin.</param>
    /// <param name="version">The version of the plugin.</param>
    internal SubtractionPlugin(string pluginName, Image image, string version) : base(pluginName, image, version) { }

    /// <inheritdoc />
    public override int Run(int input1, int input2)
    {
        /// <summary>
        /// Performs subtraction operation on the two input numbers with overflow checking.
        /// </summary>
        /// <param name="input1">The first number (minuend).</param>
        /// <param name="input2">The second number (subtrahend).</param>
        /// <returns>The difference between input1 and input2.</returns>
        /// <remarks>
        /// The `checked` keyword is used to perform overflow checking during subtraction.
        /// If the result overflows the range of an `int`, a runtime exception (OverflowException) is thrown.
        /// </remarks>
        return checked(input1 - input2);
    }
}
