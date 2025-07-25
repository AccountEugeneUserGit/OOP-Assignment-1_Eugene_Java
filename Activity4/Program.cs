using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        float celsius = float.Parse(Console.ReadLine());

        if (celsius < -100 || celsius > 100)
        {
            Console.WriteLine("Error: Temperature must be between -100 and 100.");
        }
        else
        {
            float fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
        }
    }
}
