using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public class Dog
    {
        public Dog()         // това е конструктор! той се извиква в момента, в който кажем "new Dog()"
        {
            Name = "Default name";    
        }

        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bau Bau");
        }
    }
}
