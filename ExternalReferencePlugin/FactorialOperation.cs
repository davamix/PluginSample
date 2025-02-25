using PluginBase;
using MathNet.Numerics;

namespace ExternalReferencePlugin;

public class FactorialOperation : IPluginBase {
    public string Name => "Factorial Operation";

    public string Description => "Calculates the factorial of a number";

    public void Execute() {
        Console.Write("Write the number to get the Factorial: ");
        var number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(SpecialFunctions.Factorial(number));
    }
}
