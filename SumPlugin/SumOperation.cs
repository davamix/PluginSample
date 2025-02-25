using PluginBase;

namespace SumPlugin;

public class SumOperation : IPluginBase {
    public string Name => "Sum Operation";

    public string Description => "Add two numbers";

    public void Execute() {
        Console.Write("First number: ");
        var firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second number: ");
        var secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Result: {firstNumber + secondNumber}");
    }
}

public class OtherClass {

}