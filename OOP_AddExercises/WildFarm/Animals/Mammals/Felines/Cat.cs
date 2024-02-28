using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string LivingRegion, string breed) : base(name, weight, LivingRegion, breed)
        {
        }

        public override string Talk()
        {
            return "Meow";
        }
    }
}
