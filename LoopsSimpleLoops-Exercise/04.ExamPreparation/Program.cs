namespace _04.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());

            int fails = 0;
            int solvedProblems = 0;
            double gradesSum = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (fails < poorGrades)
            {
                string problemName = Console.ReadLine();

                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    fails ++;
                }
                gradesSum += grade;
                solvedProblems ++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {fails} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solvedProblems:f2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");

            }
        }
    }
}