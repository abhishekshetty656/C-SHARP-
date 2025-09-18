using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            int rev = 0;
            while (num != 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine("Reversed Number: " + rev);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
