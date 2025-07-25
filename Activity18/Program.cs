using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine("Error: Number must be greater than 1.");
            return;
        }

        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine("The number is prime.");
        else
            Console.WriteLine("The number is not prime.");
    }
}
