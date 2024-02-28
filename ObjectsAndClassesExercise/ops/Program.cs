using System.Text;

namespace ops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            string secondCommand = "";

            List<VehicleCatalogue> currentVehicle = new List<VehicleCatalogue>();


            while ((command = Console.ReadLine()) != "End")
            {
                string[] vehicleInfo = command.Split();
                string type = char.ToUpper(vehicleInfo[0][0]) + vehicleInfo[0].Substring(1);
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                int horsepower = int.Parse(vehicleInfo[3]);
                string capitalizedType = char.ToUpper(type[0]) + type.Substring(1);

                VehicleCatalogue catalogue = new VehicleCatalogue(type, model, color, horsepower);

                currentVehicle.Add(catalogue);
            }

            while ((secondCommand = Console.ReadLine()) != "Close the Catalogue")
            {

                foreach (VehicleCatalogue machines in currentVehicle.Where(x => x.Model == secondCommand))
                {
                    Console.WriteLine($"Type: {machines.Type}\nModel: {machines.Model}\nColor: {machines.Color}\nHorsepower: {machines.Horsepower}");
                }
            }
            double carsAverageHorsepower = CalculateAverageHorsepower(currentVehicle, "Car");
            double trucksAverageHorsepower = CalculateAverageHorsepower(currentVehicle, "Truck");
            Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsepower:f2}.");
        }
        static double CalculateAverageHorsepower(List<VehicleCatalogue> currentVehicle, string vehicleType)
        {
            double totalHorsepower = currentVehicle.Where(v => v.Type == vehicleType).Sum(v => v.Horsepower);
            int vehicleCount = currentVehicle.Count(v => v.Type == vehicleType);
            double averageHorsepower = totalHorsepower / vehicleCount;
            return averageHorsepower;
        }
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
    }
}