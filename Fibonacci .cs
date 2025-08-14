using System;

class Fibonacciseries
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of terms in the Fibonacci series:");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }
    }
    static int Fibonacci(int term)
    {
        if (term <= 1)
            return term;
        return Fibonacci(term - 1) + Fibonacci(term - 2);
    }
}