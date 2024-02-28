using System.Diagnostics;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input

            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            //logic

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;
                    
                if (nightsCount > 7 && nightsCount <= 14)
                {
                    studioPrice = studioPrice * 0.95;
                }
                else if (nightsCount > 14)
                {
                    studioPrice =  studioPrice * 0.70;
                    apartmentPrice = apartmentPrice * 0.90;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                
               if (nightsCount > 14)
                {
                    studioPrice = studioPrice * 0.80;
                    apartmentPrice = apartmentPrice * 0.90;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;
                if (nightsCount > 14)
                {
                    apartmentPrice = apartmentPrice * 0.90;
                }
            }

            //output

            Console.WriteLine($" Apartment: {apartmentPrice * nightsCount:f2} lv.");
            Console.WriteLine($" Studio: {studioPrice * nightsCount:f2} lv.");
        }
    }
}