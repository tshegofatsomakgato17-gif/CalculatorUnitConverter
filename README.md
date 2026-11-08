# Calculator and Unit Converter

## Project Description
A C# console application developed using .NET 10. The application performs basic mathematical calculations and converts distance, temperature and currency.

## Features
- Addition, subtraction, multiplication and division.
- Kilometres to miles and miles to kilometres.
- Celsius to Fahrenheit and Fahrenheit to Celsius.
- Ghanaian Cedis (GHS) to US Dollars (USD).
- Input validation and division-by-zero handling.
- Menu system that allows users to perform multiple operations.

## Technologies Used
- C#
- .NET 10
- Visual Studio
- xUnit for automated testing

## How to Run
1. Install the .NET 10 SDK.
2. Open `CalculatorUnitConverter.slnx` in Visual Studio.
3. Set `CalculatorUnitConverter` as the startup project.
4. Run the application using Ctrl + F5.

## Testing
The project includes automated unit tests using xUnit.

The tests cover mathematical calculations, distance conversions, temperature conversions and currency conversion.

**Test results: 11 passed, 0 failed.**

## Assumptions and Limitations
- The user enters the exchange rate manually.
- The exchange rate must be greater than zero.
- Currency conversion is based on the rate supplied by the user.
- The application runs in a console and does not have a graphical interface.
- The application does not retrieve live exchange rates.

## Design Explanation
The application uses separate methods to perform different operations. A `CalculatorFunctions` class contains reusable calculation and conversion logic. Automated tests verify that these functions return the expected results.
