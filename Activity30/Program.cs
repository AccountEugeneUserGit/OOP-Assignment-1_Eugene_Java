using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int terms = int.Parse(Console.ReadLine());

        if (terms <= 0)
        {
            Console.WriteLine("Error: Number of terms must be positive.");
            return;
        }

        int a = 0, b = 1;

        Console.WriteLine("Fibonacci Sequence:");

        for (int i = 1; i <= terms; i++)
        {
            Console.WriteLine(a);
            int nextTerm = a + b;
            a = b;
            b = nextTerm;
        }
    }
}
