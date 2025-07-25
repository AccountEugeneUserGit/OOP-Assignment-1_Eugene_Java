using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Error: Number of elements must be positive.");
            return;
        }

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter number {i}: ");
            sum += int.Parse(Console.ReadLine());
        }

        double average = sum / (double)n;
        Console.WriteLine($"Average: {average}");
    }
}
    