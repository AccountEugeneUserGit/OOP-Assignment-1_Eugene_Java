using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        float fahrenheit = float.Parse(Console.ReadLine());

        float celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Temperature in Celsius: {celsius}");
    }
}
