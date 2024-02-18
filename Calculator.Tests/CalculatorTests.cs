using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new CalculatorArithmetic.Calculator();
            int a = 5, b = 3;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }
        
        [TestMethod]
        public void Subtract_ReturnsCorrectDifference()
        {
            // Arrange
            var calculator = new CalculatorArithmetic.Calculator();
            int a = 5, b = 3;

            // Act
            int result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }
        
        [TestMethod]
        public void Multiply_ReturnsCorrectProduct()
        {
            // Arrange
            var calculator = new CalculatorArithmetic.Calculator();
            int a = 5, b = 3;

            // Act
            int result = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            var calculator = new CalculatorArithmetic.Calculator();

            // Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}