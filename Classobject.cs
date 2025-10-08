using System;
class Person
{
    public string Name;
    public int Age;
    public void Read()
    {
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();
        Console.Write("Enter Age: ");
        Age = Convert.ToInt32(Console.ReadLine());
    }
    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}
class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Read();
        p.Display();
    }
}
