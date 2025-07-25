using System;

class Program
{
    static void Main()
    {
        // Prompt for the user's first and last name
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        // Validate input
        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
        {
            Console.WriteLine("Name cannot be empty!");
        }
        else
        {
            // Output the full name
            Console.WriteLine($"Your full name is: {firstName} {lastName}");
        }
    }
}
