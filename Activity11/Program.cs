using System;

class Program
{
    static void Main()
    {
        string correctPin = "1234";
        int attempts = 3;

        while (attempts > 0)
        {
            Console.Write("Enter your PIN: ");
            string pin = Console.ReadLine();

            if (pin == correctPin)
            {
                Console.WriteLine("Access granted.");
                return;
            }
            else
            {
                attempts--;
                Console.WriteLine($"Incorrect PIN. You have {attempts} attempts left.");
            }
        }

        Console.WriteLine("Access denied. Too many incorrect attempts.");
    }
}

