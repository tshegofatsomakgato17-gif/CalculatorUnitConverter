Console.WriteLine("===============================");
Console.WriteLine(" CALCULATOR & UNIT CONVERTER");
Console.WriteLine("===============================");

Console.WriteLine();
Console.WriteLine("1.Calculator");
Console.WriteLine("2.distance Converter");
Console.WriteLine("3.Temperature Converter");
Console.WriteLine("4.Currency Converter");
Console.WriteLine("5.Exit");

Console.WriteLine();
Console.Write("Choose an option");

string choice = Console.ReadLine() ?? "";
switch (choice)
{
    case "1":
        calculator();
        break;

    case "2":
        Console.WriteLine("You selected Distance Converter.");
        break;

    case "3":
        Console.WriteLine("You selected Temperature Converter.");
        break;

    case "4":
        Console.WriteLine("You selected Currency Converter.");
        break;

    case "5":
        Console.WriteLine("Thank you for using our application!");
        break;

    default:
        Console.WriteLine("Invalid option.Please choose between 1 and 5.");
        break;
}
static void calculator()
{
    Console.WriteLine();
    Console.WriteLine("=======CALCULATOR=======");

    Console.Write("Enter the fisrt number:");
    if (!double.TryParse(Console.ReadLine(), out double firstNumber))
    {
        Console.WriteLine("Invalid number. Please try again.");
        return;
    }

    Console.WriteLine("Enter the second number:");
    if(!double.TryParse(Console.ReadLine(), out double secondNumber))
    {
        Console.WriteLine("Invalid number. Please try again.");
        return;
    }

    Console.WriteLine();
    Console.WriteLine("Select an operation:");
    Console.WriteLine("1.Addition(+)");
    Console.WriteLine("2.Subtraction(-)");
    Console.WriteLine("3.Multiplication(*)");
    Console.WriteLine("4.Division(/)");

    Console.WriteLine("Choose an operation:");
    string operation = Console.ReadLine() ?? "";

    switch (operation)
    {
        case "1":
            Console.WriteLine($"Results:{firstNumber + secondNumber}");
            break;

        case "2":
            Console.WriteLine($"Results:{firstNumber + secondNumber}");
            break;

        case "3":
            Console.WriteLine($"Results:{firstNumber + secondNumber}");
            break;

        case "4":
            if (secondNumber == 0)
            {
                Console.WriteLine("Error:Cannot devide by zero.");
            }
            else
            {
                Console.WriteLine($"Results:{firstNumber / secondNumber}");
            }
            break;

        default:
            Console.WriteLine("Invalid operation.");
            break;
    }
}

