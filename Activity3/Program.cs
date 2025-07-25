using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the price of the item: ");
        float price = float.Parse(Console.ReadLine());

        Console.Write("Enter the quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        if (price <= 0 || quantity <= 0)
        {
            Console.WriteLine("Error: Both price and quantity must be positive.");
        }
        else
        {
            float totalCost = price * quantity;
            Console.WriteLine($"Total cost: Php {totalCost:F2}");
        }
    }
}
