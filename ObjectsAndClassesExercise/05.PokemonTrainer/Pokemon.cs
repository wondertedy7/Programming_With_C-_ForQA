using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PokemonTrainer
{
    //public class Pokemon
    //{
    //    public string Name { get; set; }
    //    public string Element {  get; set; }
    //    public int Health { get; set; }


    //    public Pokemon(string pokemonName, string pokemonElement, int pokemonHealth)
    //    {
    //        this.Name = pokemonName;
    //        this.Element = pokemonElement;
    //        this.Health = pokemonHealth;
    //    }
    //}



    public class Pokemon
    {
        public string name;
        public string element;
        public int health;

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }
    }
}

