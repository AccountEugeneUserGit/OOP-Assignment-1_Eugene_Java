using System;

class Program
{
    static void Main()
    {
        // Prompt for the user's age in years
        Console.Write("Enter your age in years: ");
        int age = int.Parse(Console.ReadLine());

        // Validate input
        if (age < 1 || age > 120)
        {
            Console.WriteLine("Age must be between 1 and 120.");
        }
        else
        {
            // Convert to months
            int ageInMonths = age * 12;
            Console.WriteLine($"You are {ageInMonths} months old.");
        }
    }
}
