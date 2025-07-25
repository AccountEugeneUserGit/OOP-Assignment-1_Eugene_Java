using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number % 2 == 0)
                Console.WriteLine("The number is even.");
            else
                Console.WriteLine("The number is odd.");
        }
        else
        {
            Console.WriteLine("Error: Input is not an integer.");
        }
    }
}
