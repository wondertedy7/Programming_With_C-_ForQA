using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals.Mammals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string LivingRegion) : base(name, weight, LivingRegion)
        {
        }

        public override string Talk()
        {
            return "Squeak";
        }
    }
}
