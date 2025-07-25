using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };

        int[] uniqueNumbers = numbers.Distinct().ToArray();

        Console.WriteLine("Array without duplicates:");
        foreach (var num in uniqueNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
