
List<Student> allStudents = new List<Student>();

string command = "";

while ((command = Console.ReadLine()) != "end")
{
    string[] studentsInfo = command.Split();
    string firstName = studentsInfo[0];
    string lastName = studentsInfo[1];
    int age = int.Parse(studentsInfo[2]);
    string homeTown = studentsInfo[3];

    Student currentStudent = new Student()
    {
        FirstName = firstName,
        LastName = lastName,
        Age = age,
        HomeTown = homeTown
    };

    allStudents.Add(currentStudent);
}

string town = Console.ReadLine();

List<Student> selectedStudents = allStudents.Where(x => x.HomeTown == town).ToList();

foreach (Student student in selectedStudents)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
}

public class Student
{

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string HomeTown { get; set; }

}

