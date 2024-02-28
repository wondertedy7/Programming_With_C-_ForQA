namespace _01.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            //if (age >= 0 && age <= 2)
            //{
            //    Console.WriteLine("baby");
            //}
            //else if (age >= 3 && age <= 13)
            //{
            //    Console.WriteLine("child");
            //}
            //else if (age >= 14 && age <= 19)
            //{
            //    Console.WriteLine("teenager");
            //}
            //else if (age >= 20 && age <= 65)
            //{
            //    Console.WriteLine("adult");
            //}
            //else if (age >= 66)
            //{
            //    Console.WriteLine("elder");
            //}

            string category = "";

            switch (age) 
            {
                case  int n when (n >= 0 && n <= 2):
                    category = "baby";
                    break;
                case int n when (n >= 3 && n <= 13):
                    category = "child";
                    break;
                case int n when (n >= 14 && n <= 19):
                    category = "teenager";
                    break;
                case int n when (n >= 20 && n <= 65):
                    category = "adult";
                    break;
                case int n when (n >= 65):
                    category = "elder";
                    break;
            }
            Console.WriteLine(category);

        }
    }
}