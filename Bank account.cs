using System;
class BankAccount
{
    public double Balance = 0;
    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }
    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
            Console.WriteLine("Insufficient Balance");
    }
}
class SavingsAccount : BankAccount
{
    public void AddInterest(double rate)
    {
        double interest = Balance * rate / 100;
        Balance += interest;
        Console.WriteLine("Interest Added: " + interest);
    }
}
class Program
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount();
        sa.Deposit(1000);
        sa.AddInterest(5);
        sa.Withdraw(500);
    }
}