using System;

public class UnitConverter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lets convert temperatures");
        Console.WriteLine("Choose a conversion type:");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Enter the temperature in Celsius:");
            if (double.TryParse(Console.ReadLine(), out double celsius)) // Input validation
            {
                double fahrenheit = CelsiusToFahrenheit(celsius);
                Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        else if (choice == "2")
        {
            Console.WriteLine("Enter the temperature in Fahrenheit:");
            if (double.TryParse(Console.ReadLine(), out double fahrenheit)) // Input validation
            {
                double celsius = FahrenheitToCelsius(fahrenheit);
                Console.WriteLine("The temperature in Celsius is: " + celsius);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please choose 1 or 2.");
        }

        Console.ReadKey(); // Keep console open
    }

    static double CelsiusToFahrenheit(double celsius) => celsius * 9 / 5 + 32; // Expression-bodied method
    static double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9; // Expression-bodied method
}
