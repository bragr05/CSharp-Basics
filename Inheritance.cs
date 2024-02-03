// Children Class
public class Airplane : Vehicle
{
    public decimal MaxFlightAltitude { get; set; }

    public Airplane(decimal height, string name, int price) : base(name, price)
    {
        MaxFlightAltitude = height;
    }
}


// Children Class
public class Car : Vehicle
{
    public int NumberDoors { get; set; }

    public Car(int doors, string name, int price) : base(name, price)
    {
        NumberDoors = doors;
    }
}

// Parent class
public class Vehicle
{
    public string VehicleName { get; set; }
    public int VehiclePrice { get; set; }

    public Vehicle(string name, int price)
    {
        VehicleName = name;
        VehiclePrice = price;
    }
}