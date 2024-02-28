
using System.Data;

int pairOfRows = int.Parse(Console.ReadLine());

Dictionary<string, List<double>> studentsGrades = new();

for (int i = 0; i < pairOfRows; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!studentsGrades.ContainsKey(name))
    {
        studentsGrades.Add(name, new List<double> { grade });
    }
    else
    {
        studentsGrades[name].Add(grade);
    }
}
//foreach (var item in studentsGrades)
//{
//    double averageGrade = item.Value.Average();

//    if (averageGrade >= 4.50)
//    {
//        Console.WriteLine($"{item.Key} -> {averageGrade:f2}");
//    }
//}
var excellent = studentsGrades.Where(kvp => kvp.Value.Average() >= 4.50);

foreach (var student in excellent)
{
    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
}
 