using System;


class Vehicle
{
    protected double x, y;
    protected double price; 
    protected double speed; 
    protected int year; 

    public Vehicle(double x, double y, double price, double speed, int year)
    {
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public virtual void info()
    {
        Console.WriteLine($"Coordinates: ({x}, {y})");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Speed: {speed} km/h");
        Console.WriteLine($"Year: {year}");
    }
}


class Plane : Vehicle
{
    private double altitude; 
    private int passengers; 

    public Plane(double x, double y, double price, double speed, int year, double altitude, int passengers)
        : base(x, y, price, speed, year)
    {
        this.altitude = altitude;
        this.passengers = passengers;
    }

    public override void info()
    {
        base.info();
        Console.WriteLine($"Altitude: {altitude} m");
        Console.WriteLine($"Passengers: {passengers}");
    }
}


class Car : Vehicle
{
    public Car(double x, double y, double price, double speed, int year)
        : base(x, y, price, speed, year)
    {
    }
}


class Ship : Vehicle
{
    private int passengers; 
    private string port; 

    public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
        : base(x, y, price, speed, year)
    {
        this.passengers = passengers;
        this.port = port;
    }

    public override void info()
    {
        base.info();
        Console.WriteLine($"Passengers: {passengers}");
        Console.WriteLine($"Port: {port}");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Vehicle vehicle = new Vehicle(10.5, 20.3, 25000, 120, 2018);
        Plane plane = new Plane(50.0, 75.2, 50000000, 800, 2022, 10000, 350);
        Car car = new Car(15.7, 30.1, 35000, 180, 2020);
        Ship ship = new Ship(100.0, 200.0, 100000000, 35, 2015, 5000, "New York");

   
        Console.WriteLine("Vehicle information:");
        vehicle.info();
        Console.WriteLine();

        Console.WriteLine("Plane information:");
        plane.info();
        Console.WriteLine();

        Console.WriteLine("Car information:");
        car.info();
        Console.WriteLine();

        Console.WriteLine("Ship information:");
        ship.info();
        Console.WriteLine();
    }
}
