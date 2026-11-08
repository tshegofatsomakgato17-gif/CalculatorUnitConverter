namespace CalculatorUnitConverter
{
    public static class CalculatorFunctions
    {
        public static double Add(double a, double b) => a + b;

        public static double Subtract(double a, double b) => a - b;

        public static double Multiply(double a, double b) => a * b;

        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return a / b;
        }

        public static double KilometresToMiles(double km)
            => km * 0.621371;

        public static double MilesToKilometres(double miles)
            => miles * 1.60934;

        public static double CelsiusToFahrenheit(double celsius)
            => (celsius * 9 / 5) + 32;

        public static double FahrenheitToCelsius(double fahrenheit)
            => (fahrenheit - 32) * 5 / 9;

        public static double CedisToDollars(double cedis, double exchangeRate)
        {
            if (exchangeRate <= 0)
                throw new ArgumentException("Exchange rate must be greater than zero.");

            return cedis / exchangeRate;
        }
    }
}