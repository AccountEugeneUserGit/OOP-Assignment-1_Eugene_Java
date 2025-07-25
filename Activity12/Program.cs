using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        string result = (number % 2 == 0) ? "even" : "odd";
        Console.WriteLine($"The number is {result}.");
    }
}
