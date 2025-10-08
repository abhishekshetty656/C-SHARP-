using System;
class Payment
{
    public double Amount;
    public string Date;
    public void Display()
    {
        Console.WriteLine("Amount: " + Amount);
        Console.WriteLine("Date: " + Date);
    }
}
class CreditCardPayment : Payment
{
    public string CardNumber;
    public string CardHolderName;
    public void DisplayCC()
    {
        Display();
        Console.WriteLine("Card Number: " + CardNumber);
        Console.WriteLine("Card Holder: " + CardHolderName);
    }
}
class UPIPayment : Payment
{
    public string UPIId;
    public string BankName;
    public void DisplayUPI()
    {
        Display();
        Console.WriteLine("UPI ID: " + UPIId);
        Console.WriteLine("Bank: " + BankName);
    }
}
class Program
{
    static void Main()
    {
        CreditCardPayment cc = new CreditCardPayment();
        cc.Amount = 2500;
        cc.Date = "09-09-2025";
        cc.CardNumber = "1234-5678-9876";
        cc.CardHolderName = "John Doe";
        cc.DisplayCC();
        UPIPayment upi = new UPIPayment();
        upi.Amount = 1500;
        upi.Date = "09-09-2025";
        upi.UPIId = "john@upi";
        upi.BankName = "SBI";
        upi.DisplayUPI();
    }
}
