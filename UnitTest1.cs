using Xunit;
using CalculatorUnitConverter;

namespace CalculatorUnitConverter.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ReturnsCorrectResult()
        {
            Assert.Equal(15, CalculatorFunctions.Add(10, 5));
        }

        [Fact]
        public void Subtract_ReturnsCorrectResult()
        {
            Assert.Equal(5, CalculatorFunctions.Subtract(10, 5));
        }

        [Fact]
        public void Multiply_ReturnsCorrectResult()
        {
            Assert.Equal(50, CalculatorFunctions.Multiply(10, 5));
        }

        [Fact]
        public void Divide_ReturnsCorrectResult()
        {
            Assert.Equal(2, CalculatorFunctions.Divide(10, 5));
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(
                () => CalculatorFunctions.Divide(10, 0));
        }

        [Fact]
        public void KilometresToMiles_ReturnsCorrectResult()
        {
            Assert.Equal(6.21371, CalculatorFunctions.KilometresToMiles(10), 5);
        }

        [Fact]
        public void MilesToKilometres_ReturnsCorrectResult()
        {
            Assert.Equal(16.0934, CalculatorFunctions.MilesToKilometres(10), 4);
        }

        [Fact]
        public void CelsiusToFahrenheit_ReturnsCorrectResult()
        {
            Assert.Equal(77, CalculatorFunctions.CelsiusToFahrenheit(25));
        }

        [Fact]
        public void FahrenheitToCelsius_ReturnsCorrectResult()
        {
            Assert.Equal(25, CalculatorFunctions.FahrenheitToCelsius(77));
        }

        [Fact]
        public void CedisToDollars_ReturnsCorrectResult()
        {
            Assert.Equal(2, CalculatorFunctions.CedisToDollars(20, 10));
        }

        [Fact]
        public void CedisToDollars_RejectsInvalidRate()
        {
            Assert.Throws<ArgumentException>(
                () => CalculatorFunctions.CedisToDollars(20, 0));
        }
    }
}