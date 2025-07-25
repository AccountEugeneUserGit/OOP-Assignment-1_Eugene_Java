using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your height (in meters): ");
        float height = float.Parse(Console.ReadLine());

        if (string.IsNullOrWhiteSpace(name) || age < 1 || age > 120 || height <= 0)
        {
            Console.WriteLine("Error: Invalid input. Ensure name is not empty, age is valid, and height is positive.");
        }
        else
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}");
        }
    }
}
