using System.Threading.Channels;

namespace CalculatorArithmetic;

public class program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the calculator program!");
        Console.WriteLine("This program can add, subtract, multiply, and divide numbers.");
        Console.WriteLine("But, the interesting part of this program is that it is tested using MSTest.");
        Console.WriteLine("This program is for educational purposes only.");
        Console.WriteLine("Please, do not use it for any serious calculations.");
        Console.WriteLine("See I'm adding two numbers ;)");
        
        var calculator = new Calculator();
        int a = 5, b = 3;
        int result = calculator.Add(a, b);
        Console.WriteLine($"The sum of {a} and {b} is {result}");
    }
}