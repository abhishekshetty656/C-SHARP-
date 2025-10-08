using System;
class NumberCheck
{
    int num;
    public void Read()
    {
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    public void Display()
    {
        if (num % 2 == 0)
            Console.WriteLine(num + " is Even.");
        else
            Console.WriteLine(num + " is Odd.");
    }
}
class Program
{
    static void Main()
    {
        NumberCheck n = new NumberCheck();
        n.Read();
        n.Display();
    }
}