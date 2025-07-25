using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your full name: ");
        string name = Console.ReadLine();

        string formattedName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
        Console.WriteLine($"Formatted Name: {formattedName}");
    }
}

