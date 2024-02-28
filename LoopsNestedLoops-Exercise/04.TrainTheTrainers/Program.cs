using System.Security.Cryptography;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryMembers = int.Parse(Console.ReadLine());

            double averageGrade = 0;
            string presentation;
            double finalAssessment = 0;
            int counter = 0;
            while ((presentation = Console.ReadLine()) != "Finish" )
            {
                counter ++;

                double finalGrade = 0;

                for (int i = 1; i <= juryMembers; i++)
                {

                    double grades = double.Parse(Console.ReadLine());

                    averageGrade += grades;
                }
                finalGrade = averageGrade / juryMembers;
                Console.WriteLine($"{presentation} - {finalGrade:f2}.");

                averageGrade = 0;

                finalAssessment += finalGrade;

            }
            Console.WriteLine($"Student's final assessment is {finalAssessment / counter:f2}.");
        }
    }
}