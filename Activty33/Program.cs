using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the start of the range: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the end of the range: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime numbers in the range:");

        for (int i = start; i <= end; i++)
        {
            bool isPrime = true;

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && i > 1)
                Console.WriteLine(i);
        }
    }
}
