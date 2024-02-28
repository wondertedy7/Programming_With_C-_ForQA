using _05.PokemonTrainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//namespace _05.PokemonTrainer
//{
//    public class Trainer
//    {
//        private string trainerName;

//        public string TrainerName { get; set; }
//        public int NumberOfBadges { get; set; }
//        public List<Pokemon> PokemonCollection { get; set; }

//        public Trainer(string trainerName, List<Pokemon> pokemons)
//        {
//            this.trainerName = trainerName;
//        }
//        public Trainer(string trainerName, int numberOfBadges) : this(trainerName)
//        { 
//            this.NumberOfBadges = numberOfBadges = 0;
//            this.PokemonCollection = new List<Pokemon> ();
//        }

//        public Trainer(string trainerName)
//        {
//            this.trainerName = trainerName;
//        }

//        //public Trainer()
//        //{
//        //    PokemonCollection = new List<Pokemon>(); // Initialize the collection in the constructor
//        //}

//        public void CheckElement(string element)
//        {
//            bool hasElement = PokemonCollection.Any(p => p.Element == element);
//            if (hasElement)
//            {
//                NumberOfBadges++;
//            }
//            else
//            {
//                foreach (Pokemon pokemon in PokemonCollection)
//                {
//                    pokemon.Health -= 10;
//                }
//                PokemonCollection.RemoveAll(p => p.Health <= 0);
//            }
//        }
//        public override string ToString()
//        {
//            return $"{TrainerName} {NumberOfBadges} {PokemonCollection.Count}";
//        }

//    }
//}


namespace _08.Pokemon_Trainer
{
    public class Trainer
    {
        public string name;
        public int badges;
        public List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.name = name;
            this.badges = 0;
            this.pokemons = new List<Pokemon>();
        }
    }
}
