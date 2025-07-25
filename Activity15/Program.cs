using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to print the multiplication table: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}
