using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a numeric string: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine($"Result after adding 10: {number + 10}");
        }
        else
        {
            Console.WriteLine("Error: Input is not a valid number.");
        }
    }
}

