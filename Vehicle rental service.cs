using System;

class Vehicle
{
    public string Model;
    public string Brand;
    public double RentalPricePerDay;

    public void Display()
    {
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Rental price per day: " + RentalPricePerDay);
    }
}

class Car : Vehicle
{
    public int Seats;
    public string FuelType;

    public void DisplayCar()
    {
        Display(); // base class display
        Console.WriteLine("Seats: " + Seats);
        Console.WriteLine("Fuel Type: " + FuelType);
    }
}

class Program
{
    static void Main()
    {
        Car c = new Car();
        c.Model = "120";
        c.Brand = "Toyota";
        c.RentalPricePerDay = 1500;
        c.Seats = 5;
        c.FuelType = "Petrol";
        c.DisplayCar();
    }
}
