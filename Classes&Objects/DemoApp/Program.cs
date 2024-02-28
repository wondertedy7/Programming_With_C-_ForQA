namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //различни синтаксиси за създаване на обекти в даден клас:

            Dog puppy = new Dog()
            {
                Name = "Sparky",
                Breed = "Corgi",
                Age = 3
            };

            puppy.Bark(); //извикваме метода "Bark"

            //*******

            Dog friend = new Dog();
            friend.Name = "Khan";
            friend.Breed = "German Shepherd";
            friend.Age = 3; 

            friend.Bark();

            //Ако си изкараме класа в отделен .cs файл, можем да ползваме горните обекти и без да ги има горните namespase, internal class и static oid Main. 
            // НО заради judge системата, засега е добре всичко да ни е в един файл, за де на се налага да копираме и пействаме от две места!!!!!

            // типове именуване:
            //PascalCase
            //camelCase
            //kebap-case
            //underscore_case
            //ALL_UPPER_CASE

        }
    }
}