public class Student : Person
{
    // Properties
    private int StudentID { get; set; }
    private string Major { get; set; }

    // Constructor
    public Student(string firstName, string lastName, int studentID, string major, DateTime birthDate, decimal baseSalary) : base(firstName, lastName, birthDate, baseSalary)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        BaseSalary = baseSalary;
        Addresses = new List<string>();
        StudentID = studentID;
        Major = major;
    }

    // Implementation of abstract method
    public override string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}