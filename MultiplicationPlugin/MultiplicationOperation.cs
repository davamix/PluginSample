using PluginBase;

namespace MultiplicationPlugin;

public class MultiplicationOperation : IPluginBase {
    public string Name => "Multiplication Operation";

    public string Description => "Multiply two numbers";

    public void Execute() {

        Console.Write("First number: ");
        var firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second number: ");
        var secondNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"Result: {firstNumber * secondNumber}");
    }
}
