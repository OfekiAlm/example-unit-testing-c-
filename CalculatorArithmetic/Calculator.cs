namespace CalculatorArithmetic;

public class Calculator
{
    /// <summary>
    /// Adds two numbers.
    /// </summary>
    /// <param name="num1">The first number.</param>
    /// <param name="num2">The second number.</param>
    /// <returns>The sum of the two numbers.</returns>
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    /// <summary>
    /// Subtracts two numbers.
    /// </summary>
    /// <param name="num1">The first number.</param>
    /// <param name="num2">The second number.</param>
    /// <returns>The difference between the two numbers.</returns>
    public int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    /// <summary>
    /// Multiplies two numbers.
    /// </summary>
    /// <param name="num1">The first number.</param>
    /// <param name="num2">The second number.</param>
    /// <returns>The product of the two numbers.</returns>
    public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    
    /// <summary>
    /// Divides two numbers.
    /// </summary>
    /// <param name="num1">The dividend.</param>
    /// <param name="num2">The divisor.</param>
    /// <returns>The quotient of the division.</returns>
    /// <exception cref="System.DivideByZeroException">Thrown when the divisor is zero.</exception>
    public double Divide(int num1, int num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return (double)num1 / num2;
    }
}