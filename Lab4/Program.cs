using System;

class Car
{
    public string model;
    public string color;
    public int year;

    public Car()
    {
        model = string.Empty;
        color = string.Empty;
        year = 0;
    }

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    public void Start() // Step 1
    {
        Console.WriteLine("The car is starting.");
    }
    
    public void Drive(int miles) // Step 2
    {
        Console.WriteLine("The car drove " + miles + " miles."); // Step 3
    }

    public string GetDescription()
    {
        return year + " " + color + " " + model;
    }

    public void Repaint(string newColor) // Step 4
    {
        color = newColor;
        Console.WriteLine("The car has been repainted to " + newColor + ".");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display(); 
        myCar.Start();
        myCar.Drive(50);
        string description = myCar.GetDescription();
        Console.WriteLine(description);
        myCar.Repaint("red");
        Console.WriteLine("Color after repaint: " + myCar.color);
    }
    
}