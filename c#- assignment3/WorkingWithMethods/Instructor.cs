public class Instructor: Person, IInstructorService{
    // Properties
    private int EmployeeID { get; set; }
    private string Department { get; set; }
    private DateTime HireDate { get; set; }

    // Constructor
    public Instructor(string firstName, string lastName, int employeeID, string department, DateTime birthDate, decimal baseSalary, DateTime hireDate) : base(firstName, lastName, birthDate, baseSalary)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        BaseSalary = baseSalary;
        Addresses = new List<string>();
        EmployeeID = employeeID;
        Department = department;
        HireDate = hireDate;
    }

    // Implementation of abstract method
    public override string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    // add bonus salary based on years of experience

    public override decimal CalculateSalary(decimal baseSalary)
    {
        if (baseSalary < 0) throw new Exception("Base salary cannot be negative");
        decimal salary = baseSalary + (baseSalary * 0.1M);
        int yearsOfExperience = DateTime.Now.Year - HireDate.Year;
        if (DateTime.Now.DayOfYear < HireDate.DayOfYear)
        {
            yearsOfExperience = yearsOfExperience - 1;
        }
        if (yearsOfExperience > 5)
        {
            salary = salary + (salary * 0.05M);
        }
        return salary;
    }

    public void PrintName()
    {
        Console.WriteLine( $"{FirstName} {LastName}");
    }

    public void addAddress(string address)
    {
        Addresses.Add(address);
    }

    public List<string> getAddresses()
    {
        return Addresses;
    }
}