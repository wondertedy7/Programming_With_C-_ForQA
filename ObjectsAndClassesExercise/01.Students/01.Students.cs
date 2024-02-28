
using System.Security.Cryptography.X509Certificates;

int studentsCount = int.Parse(Console.ReadLine());

List<Students> allStudents = new List<Students>();

for (int i = 0; i < studentsCount; i++)
{
    string[] studentsList = Console.ReadLine().Split();
    string firstName = studentsList[0];
    string lastName = studentsList[1];
    double grade = double.Parse(studentsList[2]);

    Students currentStudent = new Students(firstName, lastName, grade);

    allStudents.Add(currentStudent);
}
allStudents = allStudents.OrderByDescending(x => x.Grade).ToList();

foreach (Students student in allStudents)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
}


public class Students
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

    public Students(string firstName, string lastName, double grade)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Grade = grade;
    }


}