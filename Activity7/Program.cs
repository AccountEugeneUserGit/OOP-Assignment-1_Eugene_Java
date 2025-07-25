using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        float num1 = float.Parse(Console.ReadLine());

        Console.Write("Enter the operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Enter the second number: ");
        float num2 = float.Parse(Console.ReadLine());

        if (op == "+" || op == "-" || op == "*" || op == "/")
        {
            if (op == "/" && num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                float result = op switch
                {
                    "+" => num1 + num2,
                    "-" => num1 - num2,
                    "*" => num1 * num2,
                    "/" => num1 / num2,
                    _ => 0
                };
                Console.WriteLine($"Result: {result}");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid operator.");
        }
    }
}
