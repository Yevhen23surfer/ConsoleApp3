/*
// Code project 1 - write code that validates integer input

using System;

class ValidateIntegerInput
{
    static void Main(string[] args)
    {
        int userInput;

        do
        {
            Console.WriteLine("Please enter an integer between 5 and 10: ");
            string inputString = Console.ReadLine();

            // Check if input is a valid integer
            if (!int.TryParse(inputString, out userInput))
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again.");
                continue; // Skip to the next iteration if input is not an integer
            }

            // Check if the integer is within the range
            if (userInput < 5 || userInput > 10)
            {
                Console.WriteLine($"You entered {userInput}. Please enter a number between 5 and 10.");
            }    
        } while (userInput < 5 || userInput > 10); // Loop continues until a valid input between 5 and 10 is entered

        Console.WriteLine("Your input, ({0}), has been accepted.", userInput);
    }
}
*/

// Code project 2 - write code that validates string input

using System;

class ValidateStringInput
{
    static void Main(string[] args)
    {
        string userRole;

        do
        {
            Console.WriteLine("Enter your role name (Administrator, Manager, or User): ");
            userRole = Console.ReadLine().Trim().ToLower(); // Trim and convert to lowercase

            // Check the role
            if (userRole != "Administrator" && userRole != "Manager" && userRole != "User")
            {
                Console.WriteLine($"The role name that you entered, '{userRole}'. Enter your role name (Administrator, Manager, or User)");
            }
        } while (userRole != "administrator" && userRole != "manager" && userRole != "user");

        Console.WriteLine("Your input, ({0}), has been accepted.", userRole);
    }
}