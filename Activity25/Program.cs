using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        int wordCount = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine($"Number of words: {wordCount}");
    }
}
