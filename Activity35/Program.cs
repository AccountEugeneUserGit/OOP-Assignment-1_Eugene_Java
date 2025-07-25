using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 3, 8, 4, 2 };

        Console.WriteLine("Before sorting:");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Bubble Sort
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("After sorting:");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
