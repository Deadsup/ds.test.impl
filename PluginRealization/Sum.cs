
using System.Drawing;

/// <summary>
/// Internal class representing a summation plugin.
/// </summary>
internal class SumPlugin : AbstractPlugin
{
    /// <summary>
    /// Initializes a new instance of the SumPlugin class with the specified plugin name.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    internal SumPlugin(string pluginName) : base(pluginName) { }

    /// <summary>
    /// Initializes a new instance of the SumPlugin class with the specified plugin name and image.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    /// <param name="image">The image associated with the plugin.</param>
    internal SumPlugin(string pluginName, Image image) : base(pluginName, image) { }

    /// <summary>
    /// Initializes a new instance of the SumPlugin class with the specified plugin name, image, and version.
    /// </summary>
    /// <param name="pluginName">The name of the plugin.</param>
    /// <param name="image">The image associated with the plugin.</param>
    /// <param name="version">The version of the plugin.</param>
    internal SumPlugin(string pluginName, Image image, string version) : base(pluginName, image, version) { }

    /// <summary>
    /// Performs summation operation on the two input numbers with overflow checking.
    /// </summary>
    /// <param name="input1">The first number (addend).</param>
    /// <param name="input2">The second number (addend).</param>
    /// <returns>The sum of input1 and input2.</returns>
    /// <remarks>
    /// The `checked` keyword is used to perform overflow checking during addition.
    /// If the result overflows the range of an `int`, a runtime exception (OverflowException) is thrown.
    /// </remarks>
    public override int Run(int input1, int input2)
    {
        return checked(input1 + input2);
    }
}
