using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter DOB (yyyy-mm-dd): ");
        DateTime dob = DateTime.Parse(Console.ReadLine());
        int age = DateTime.Now.Year - dob.Year;

        if (DateTime.Now.DayOfYear < dob.DayOfYear)
            age--;

        Console.WriteLine($"You are {age} years old.");
    }
}

