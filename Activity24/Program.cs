using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Error: Number must be positive.");
            return;
        }

        int sum = 0;
        for (int i = 1; i <= n; i += 2)
        {
            sum += i;
        }

        Console.WriteLine($"Sum of odd numbers from 1 to {n}: {sum}");
    }
}
