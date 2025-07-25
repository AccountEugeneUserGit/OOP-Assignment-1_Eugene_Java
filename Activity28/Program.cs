using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int limit = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i < limit; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine($"Sum of multiples of 3 or 5 below {limit}: {sum}");
    }
}
