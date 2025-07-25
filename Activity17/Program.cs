using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string input = Console.ReadLine();

        string reversed = new string(input.Reverse().ToArray());

        if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("The word is a palindrome.");
        else
            Console.WriteLine("The word is not a palindrome.");
    }
}
