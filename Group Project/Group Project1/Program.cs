//See Bottom for Documentation on functions

using System;
using System.Collections.Generic;

class Program
{
    // Sean: Dictionary Setup + Populate Function
    static Dictionary<string, List<string>> PopulateDictionary()
    {
        var studentList = new Dictionary<string, List<string>>
        {
            {"Alice", new List<string> {"25", "reading, coding"}}
        };
        Console.WriteLine("Student List populated.");
        return studentList;
    }


    // Helper function to simulate input for testing
    static string GetInput(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine() ?? string.Empty;
    }

    //Nicholas: Display + Sort Functions
    static void DisplayDictionary(Dictionary<string, List<string>> studentList)
    {
        Console.WriteLine("\nDisplay Options:");
        Console.WriteLine("1. Names");
        Console.WriteLine("2. Details");
        Console.WriteLine("3. Name-Details Pairs");

        string choice = GetInput("Choose an option:");

        if (choice == "1")
        {
            Console.WriteLine("\nNames: " + string.Join(", ", studentList.Keys));
        }
        else if (choice == "2")
        {
            foreach (var detailsList in studentList.Values)
            {
                Console.WriteLine("\nDetails: " + String.Join(", ", detailsList));
            }
        }
        else if (choice == "3")
        {
            Console.WriteLine("\nItems:");
            foreach (var kvp in studentList)
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    static void SortKeys(Dictionary<string, List<string>> studentList)
    {
        var sortedKeys = new List<string>(studentList.Keys);
        sortedKeys.Sort();
        Console.WriteLine("\nSorted Names: " + String.Join(", ", sortedKeys));
    }

    // Jhonny: Add and Update Functions
    static void AddKeyValue(Dictionary<string, List<string>> studentList)
    {
        string name = GetInput("Enter student name:");
        string age = GetInput("Enter age:");
        string hobbies = GetInput("Enter hobbies (comma separated):");

        if (studentList.ContainsKey(name))
        {
            Console.WriteLine("Name already exists. Use 'Update' option to add details.");
        }
        else
        {
            studentList[name] = new List<string> { age, hobbies };
            Console.WriteLine("Student and details added.");
        }
    }

    static void UpdateKey(Dictionary<string, List<string>> studentList)
    {
        string name = GetInput("Enter student name to update:");

        if (studentList.ContainsKey(name))
        {
            string age = GetInput("Enter age:");
            string hobbies = GetInput("Enter hobbies (comma separated):");
            studentList[name] = new List<string> { age, hobbies };
            Console.WriteLine("Details updated for existing student.");
        }
        else
        {
            Console.WriteLine("Name not found.");
        }
    }

    // Hava: Remove + Switch Menu + Documentation
    static void RemoveKey(Dictionary<string, List<string>> studentList)
    {
        string name = GetInput("Enter student name to remove:");

        if (studentList.Remove(name))
        {
            Console.WriteLine("Student removed.");
        }
        else
        {
            Console.WriteLine("Name not found.");
        }
    }

    static void Main()
    {
        var studentList = PopulateDictionary();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display Student List");
            Console.WriteLine("2. Remove a Student");
            Console.WriteLine("3. Add New Student and Details");
            Console.WriteLine("4. Add Details to Existing Student");
            Console.WriteLine("5. Sort Names");
            Console.WriteLine("6. Exit");

            string choice = GetInput("Select an option:");

            switch (choice)
            {
                case "1":
                    DisplayDictionary(studentList);
                    break;
                case "2":
                    RemoveKey(studentList);
                    break;
                case "3":
                    AddKeyValue(studentList);
                    break;
                case "4":
                    UpdateKey(studentList);
                    break;
                case "5":
                    SortKeys(studentList);
                    break;
                case "6":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
// Documentation:
// This program is a simple student list management system that allows users to add, update, display, and remove student details.
// The program uses a dictionary to store student names as keys and a list of age and hobbies as values.
// The program starts by populating the dictionary with a default student.
// The main menu allows users to choose from the following options:
// 1. Display Student List: Displays student names, details, or name-details pairs.
// 2. Remove a Student: Removes a student from the list.
// 3. Add New Student and Details: Adds a new student and their age and hobbies.
// 4. Add Details to Existing Student: Updates the age and hobbies of an existing student.
// 5. Sort Names: Sorts the student names in alphabetical order.
// 6. Exit: Exits the program.
// The program uses a switch statement to handle user input and call the appropriate functions.
// Each function performs the required operation and provides feedback to the user.
// The program continues to run until the user chooses to exit.
// The program is designed to be simple and easy to use, providing basic functionality for managing a student list.
// The code is organized into functions for each operation, making it easy to read and maintain.
// The program uses a dictionary to store student details, allowing for efficient lookup and manipulation of data.
// Overall, this program provides a straightforward solution for managing a student list with basic CRUD operations.
// End of documentation
