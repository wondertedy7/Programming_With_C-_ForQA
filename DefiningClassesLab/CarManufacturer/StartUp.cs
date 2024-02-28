using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            var tires = new Tire[]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.1),
                new Tire(2, 0.5),
                new Tire(2, 2.3),
            };

            var engine = new Engine(500, 6300);

            var lambo = new Car("Lamorghini", "Urus", 2010, 250, 9, engine, tires);

            var skoditU = new Car("Skoda", "Fabia", 2008, 40, 6, engine, tires);

            Console.WriteLine(skoditU.WhoAmI());
            

        }
    }
}
