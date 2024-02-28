using _05.PokemonTrainer;
using _08.Pokemon_Trainer;
using System.Text;

//Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

//string input = "";

//while ((input = Console.ReadLine()) != "Tournament")
//{
//    string[] trainerPokemonInfo = input.Split();
//    string trainerName = trainerPokemonInfo[0];
//    string pokemonName = trainerPokemonInfo[1];
//    string pokemonElement = trainerPokemonInfo[2];
//    int pokemonHealth = int.Parse(trainerPokemonInfo[3]);

//    if (!trainers.ContainsKey(trainerName))
//    {
//        Trainer trainer = new Trainer(trainerName);
//        trainers[trainerName] = trainer;
//    }
//    Trainer trainerInstance = trainers[trainerName];
//    Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
//    trainerInstance.PokemonCollection.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));

//    while ((input = Console.ReadLine()) != "End")
//    {
//        foreach (Trainer trainer in trainers.Values)
//        {
//            trainerInstance.CheckElement(input);
//        }
//    }

//    var sortedTrainers = trainers.Values
//        .OrderByDescending(t => t.NumberOfBadges)
//        .ThenBy(t => t.PokemonCollection.Count);

//    StringBuilder result = new StringBuilder();
//    foreach (var trainer in sortedTrainers)
//    {
//        result.AppendLine(trainer.ToString());
//    }

//    Console.WriteLine(result.ToString().Trim());
//}


//string command = string.Empty;

//var trainerList = new List<Trainer>();

//while ((command = Console.ReadLine()) != "Tournament")
//{
//    var tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);


//    var trainerName = tokens[0];
//    var pokemonName = tokens[1];
//    var pokemonElement = tokens[2];
//    var pokemonHealth = int.Parse(tokens[3]);


//    var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

//    if (trainerList.Any(x => x.TrainerName == trainerName))
//    {
//        foreach (var tr in trainerList)
//        {
//            if (trainerName == tr.TrainerName)
//            {
//                tr.PokemonCollection.Add(pokemon);
//            }
//        }
//    }
//    else
//    {
//        Trainer trainer = new Trainer(trainerName, new List<Pokemon> { pokemon });
//        trainerList.Add(trainer);
//    }

//}

//while ((command = Console.ReadLine()) != "End")
//{

//    //if (command == "Fire")
//    //{
//    //    Tournament(trainerList, command);
//    //}
//    //else if (command == "Water")
//    //{
//    //    Tournament(trainerList, command);
//    //}
//    //else
//    //{
//    //    Tournament(trainerList, command);
//    //}

//    foreach (Trainer trainer in trainerList)
//    {
//        if (trainer.PokemonCollection.Any(p => p.Element == command))
//        {
//            trainer.NumberOfBadges++;
//        }
//        else
//        {
//            foreach (Pokemon pokemon in trainer.PokemonCollection)
//            {
//                pokemon.Health -= 10;
//            }

//            trainer.PokemonCollection = trainer.PokemonCollection.Where(p => p.Health > 0).ToList();
//        }
//    }
//}

//foreach (var tr in trainerList.OrderByDescending(x => x.NumberOfBadges))
//{
//    Console.WriteLine($"{tr.TrainerName} {tr.NumberOfBadges} {tr.PokemonCollection.Count}");
//}


// static void Tournament(List<Trainer> trainerList, string command)
//{
//    foreach (var tr in trainerList)
//    {
//        if (tr.PokemonCollection.Any(x => x.Element == command))
//        {

//            tr.NumberOfBadges++;

//        }
//        else
//        {
//            tr.PokemonCollection.Select(x => x.Health -= 10).ToList();
//            var fileredListOfPokemons = tr.PokemonCollection.Where(x => x.Health > 0).ToList();
//            tr.PokemonCollection = fileredListOfPokemons;
//        }
//    }
//}

string command = Console.ReadLine();
List<Trainer> trainers = new List<Trainer>();

while (command != "Tournament")
{
    string[] tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
    string trainerName = tokens[0];
    string pokemonName = tokens[1];
    string element = tokens[2];
    int health = int.Parse(tokens[3]);

    if (!trainers.Any(t => t.name == trainerName))
    {
        trainers.Add(new Trainer(trainerName));
    }



    Trainer trainer = trainers.First(t => t.name == trainerName);
    trainer.pokemons.Add(new Pokemon(pokemonName, element, health));


    command = Console.ReadLine();
}

command = Console.ReadLine();

while (command != "End")
{
    foreach (Trainer trainer in trainers)
    {
        if (trainer.pokemons.Any(p => p.element == command))
        {
            trainer.badges++;
        }
        else
        {
            foreach (Pokemon pokemon in trainer.pokemons)
            {
                pokemon.health -= 10;
            }

            trainer.pokemons = trainer.pokemons.Where(p => p.health > 0).ToList();
        }
    }

    command = Console.ReadLine();
}

foreach (Trainer trainer in trainers.OrderByDescending(t => t.badges))
{
    Console.WriteLine("{0} {1} {2}", trainer.name, trainer.badges, trainer.pokemons.Count);
}