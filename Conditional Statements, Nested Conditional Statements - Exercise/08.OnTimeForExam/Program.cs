namespace _08.OnTimeForExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input 

            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            //logic

            examMinute = examMinute + examHour * 60;
            arrivalMinute = arrivalMinute + arrivalHour * 60;

            int difference = examMinute - arrivalMinute;

            if (difference < 0)
            {
                Console.WriteLine("Late");

                if (difference > -60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference / 60)}:{Math.Abs(difference % 60):d2} hours after the start");
                }
            }
            else if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");

                if (difference > 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");

                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{difference / 60}:{difference % 60:d2} hours before the start");
                }

            }

        }
    }
}