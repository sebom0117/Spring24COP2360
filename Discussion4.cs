
using System;

class Disc4_Try_Catch_Divide
{
    static void Main(string[] args)
    {
        string userChoice = "y"; // Set initial user choice to 'y' for yes

        while (userChoice.ToLower() == "y")
        {
        Console.WriteLine(" "); // For Spacing
        Console.WriteLine("This program divides two numbers"); //Intro to the program
        Console.WriteLine("Please Enter Two Numbers to being, starting with your first number."); //Intro to the program
        Console.WriteLine(" "); // For Spacing

            Console.WriteLine("Please Enter First Number"); // First Number Entry
            string FirstNumber = Console.ReadLine();

            Console.WriteLine("Please Enter Second Number"); // Second Number Entry
            string SecondNumber = Console.ReadLine();

            try
            {
                int FirstNumberInt = Convert.ToInt32(FirstNumber);
                int SecondNumberInt = Convert.ToInt32(SecondNumber);

                int Result = Divide(FirstNumberInt, SecondNumberInt);

                Console.WriteLine("Dividing " + FirstNumber + " by " + SecondNumber + " equals " + Result);
            }
            
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid number(s)"); // checks to validate the numbers entered
            }

            catch (OverflowException)
            {
                Console.WriteLine("The number entered is too large or too small for an integer"); // catch overflow error
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero"); // check to make sure no numbers are zero
            }

            catch (Exception)
            {
                Console.WriteLine("An error occurred unexpectedly"); // catches any other errors
            }

            // Ask if the user wants to continue (default is no)
            Console.WriteLine("Would you like to perform another calculation? (y/N)");
            userChoice = Console.ReadLine();
        }

        Console.WriteLine("Goodbye!");
    }

    static int Divide(int FirstNumberInt, int SecondNumberInt)
    {
        return FirstNumberInt / SecondNumberInt;
    }
}
