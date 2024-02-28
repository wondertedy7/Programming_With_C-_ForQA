
using System.Reflection;

string command = "";

Catalog vehiclesCatalog = new();

while ((command = Console.ReadLine()) != "end")
{
    List<string> vehicles = command.Split("/").ToList();

    string typeOfVehicle = vehicles[0];
    string brandOfVehicle = vehicles[1];
    string modelOfVehicle = vehicles[2];
    int horsePowerOrWeight = int.Parse(vehicles[3]);

    if (typeOfVehicle == "Car")
    {
        Car currentCar = new Car()
        {
            Brand = brandOfVehicle,
            Model = modelOfVehicle,
            HorsePower = horsePowerOrWeight,
        };
        vehiclesCatalog.CarCollection.Add(currentCar);
    }
    else if (typeOfVehicle == "Truck")
    {
        Truck currentTruck = new Truck()
        {
            Brand = brandOfVehicle,
            Model = modelOfVehicle,
            Weight = horsePowerOrWeight,
        };
        vehiclesCatalog.TruckCollection.Add(currentTruck);
    }
}


if (vehiclesCatalog.CarCollection.Any()) // .Any() does the same as: .Count > 0
{
    List<Car> orderedCars = vehiclesCatalog.CarCollection.OrderBy(x => x.Brand).ToList();

    Console.WriteLine("Cars:");
    foreach (Car car in orderedCars)
    {
        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
    }
}
if (vehiclesCatalog.TruckCollection.Any())
{
    List<Truck> orderedTrucks = vehiclesCatalog.TruckCollection.OrderBy(y => y.Brand).ToList();

    Console.WriteLine("Trucks:");
    foreach (Truck truck in orderedTrucks)
    {
        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
    }

}

public class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}

public class Catalog
{
    public Catalog() //използва се или този каталог, или се пише, както долу 
    {
        TruckCollection = new List<Truck>();
        CarCollection = new List<Car>();
    }
    public List<Truck> TruckCollection { get; set; } //= new List<Truck>();
    public List<Car> CarCollection { get; set; } //= new List<Car>();
}