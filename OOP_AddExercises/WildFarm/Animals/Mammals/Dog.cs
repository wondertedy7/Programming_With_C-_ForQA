using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals.Mammals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string LivingRegion) : base(name, weight, LivingRegion)
        {
        }

        public override string Talk()
        {
            return "Woof!";
        }
    }
}
