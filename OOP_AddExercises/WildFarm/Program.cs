
using System;
using WildFarm;
using WildFarm.Animals;
using WildFarm.Animals.Mammals.Felines;
using WildFarm.Foods;

Farm farm = new Farm();

string animalInput = "";

while ((animalInput = Console.ReadLine()) != "End")
{
    Animal animal = farm.ReadAnimal(animalInput);
    try
    {
        farm.AddAnimal(animal);
    }
    catch (ArgumentException)
    {
        Console.WriteLine("Unnown animal");
    }
    
    Console.WriteLine(animal.Talk());

    string foodInput = "";
    try
    {
        foodInput = Console.ReadLine();

    }
    catch (ArgumentException)
    {
        Console.WriteLine("Unnknown food");
    }
    Food food = farm.ReadFood(foodInput);

    try
    {
        farm.FeedAnimal(animal, food);
    }
    catch (ArgumentException)
    {
        Console.WriteLine($"{animal.GetType().Name} does not eat {food.GetType().Name}!");
    }
}

foreach (Animal currentAnimal in farm.Animals)
{
    Console.WriteLine(currentAnimal);
}