namespace P10.SummerOutfit
{
     internal class Program
        {
         static void Main(string[] args)
            {
            //input

            int temp = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            //string clothes = "";
            //string shoes = "";

            //logic

            //if (temp >= 10 && temp <= 18)
            //{
            //    if (timeOfDay == "Morning")
            //    {
            //        clothes = "Sweatshirt";
            //        shoes = "Sneakers";
            //    }
            //    else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
            //    {
            //        clothes = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //}
            //else if (temp > 18 && temp <= 24)
            //{
            //    if (timeOfDay == "Morning" || timeOfDay == "Evening")
            //    {
            //        clothes = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //    else if (timeOfDay == "Afternoon")
            //    {
            //        clothes = "T-Shirt";
            //        shoes = "Sandals";
            //    }
            //}
            //else if (temp >= 25)
            //{
            //    if(timeOfDay == "Morning")
            //    {
            //        clothes = "T-Shirt";
            //        shoes = "Sandals";
            //    }
            //    else if (timeOfDay == "Afternoon")
            //    {
            //        clothes = "Swim Suit";
            //        shoes = "Barefoot";
            //    }
            //    else if (timeOfDay == "Evening")
            //    {
            //        clothes = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //}

            ////output

            //Console.WriteLine($"It's {temp} degrees, get your {clothes} and {shoes}.");

            // *********

            //if (timeOfDay == "Morning")
            //{
            //    if (temp >= 10 && temp <= 18)
            //    {
            //        clothes = "Sweatshirt";
            //        shoes = "Sneakers";
            //    }
            //    else if (18 < temp && temp <= 24)
            //    {
            //        clothes = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //    else if (temp >= 25)
            //    {
            //        clothes = "T-Shirt";
            //        shoes = "Sandals";
            //    }
            //}
            //else if (timeOfDay == "Afternoon")
            //{
            //    if (temp >= 10 && temp <= 18)
            //    {
            //        clothes = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //    else if (18 < temp && temp <= 24)
            //    {
            //        clothes = "T-Shirt";
            //        shoes = "Sandals";
            //    }
            //    else if (temp >= 25)
            //    {
            //        clothes = "Swim Suit";
            //        shoes = "Barefoot";
            //    }
            //}
            //else if (timeOfDay == "Evening")
            //{
            //    clothes = "Shirt";
            //    shoes = "Moccasins";
            //}

            //Console.WriteLine($"It's {temp} degrees, get your {clothes} and {shoes}.");

            // **********

            string clothes = "Shirt";
            string shoes = "Moccasins";

            if ((timeOfDay == "Morning" && temp >= 25) 
                || (timeOfDay == "Afternoon" && temp > 18 && temp <= 24)) 
            {
                clothes = "T-Shirt";
                shoes = "Sandals";
            }             
            else if (timeOfDay == "Morning" && temp <= 18)
            {
                clothes = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (timeOfDay == "Afternoon" && temp >= 25)
            {
                clothes = "Swim Suit";
                shoes = "Barefoot";
            }

            Console.WriteLine($"It's {temp} degrees, get your {clothes} and {shoes}.");

        }
    }
}
