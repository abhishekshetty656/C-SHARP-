using System;

class primenum
    {
    static void Main(string[] args)
    {
        int n = 100;
        bool isPrime;
        for (int i = 2; i <= n; i++)
        {
            isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(i);
            }
        }
    }
}
