
using System.Text;

string command = "";
string secondCommand = "";
double allCarsHorsepower = 0;
double allTrucksHorsepower = 0;
int carsCount = 0;
int trucksCount = 0;

List<VehicleCatalogue> currentVehicle = new List<VehicleCatalogue>();


while ((command = Console.ReadLine()) != "End")
{
    string[] vehicleInfo = command.Split();
    string type = vehicleInfo[0];
    string model = vehicleInfo[1];
    string color = vehicleInfo[2];
    int horsepower = int.Parse(vehicleInfo[3]);

    VehicleCatalogue catalogue = new VehicleCatalogue(type, model, color, horsepower);

    if (type == "car")
    {
        carsCount++;
        allCarsHorsepower += horsepower;
    }
    else
    {
        trucksCount++;
        allTrucksHorsepower += horsepower;
    }

    currentVehicle.Add(catalogue);
}

while ((secondCommand = Console.ReadLine()) != "Close the Catalogue")
{

    foreach (VehicleCatalogue machines in currentVehicle.Where(x => x.Model == secondCommand))
    {
        Console.WriteLine($"Type: {char.ToUpper(machines.Type[0]) + machines.Type.Substring(1)}\nModel: {machines.Model}\nColor: {machines.Color}\nHorsepower: {machines.Horsepower}");
    }
}
Console.WriteLine($"Cars have average horsepower of: {allCarsHorsepower / carsCount:f2}.");
Console.WriteLine($"Trucks have average horsepower of: {allTrucksHorsepower / trucksCount:f2}.");



public class VehicleCatalogue
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }

    public VehicleCatalogue(string type)
    {
        this.Type = type;
    }

    public VehicleCatalogue(string type, string model, string color, int horsepower) : this(type)
    {
        this.Model = model;
        this.Color = color;
        this.Horsepower = horsepower;
    }


}