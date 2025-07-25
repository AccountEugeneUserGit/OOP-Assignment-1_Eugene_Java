using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int digitCount = number.ToString().Length;
        Console.WriteLine($"Number of digits: {digitCount}");
    }
}
