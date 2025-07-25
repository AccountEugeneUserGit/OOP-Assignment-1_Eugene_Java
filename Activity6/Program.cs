﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade (0-100): ");
        int grade = int.Parse(Console.ReadLine());

        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Error: Grade must be between 0 and 100.");
        }
        else
        {
            char letterGrade;
            if (grade >= 90) letterGrade = 'A';
            else if (grade >= 80) letterGrade = 'B';
            else if (grade >= 70) letterGrade = 'C';
            else if (grade >= 60) letterGrade = 'D';
            else letterGrade = 'F';

            Console.WriteLine($"Your letter grade is: {letterGrade}");
        }
    }
}
