public abstract class Person : IPersonService{
    public string FirstName{get;set;}
    public string LastName{get;set;}
    protected DateTime BirthDate{get;set;}
    protected List<string> Addresses{get;set;}
    protected decimal BaseSalary{get;set;}

    public Person(string firstName, string lastName, DateTime birthDate, decimal baseSalary){
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        BaseSalary = baseSalary;
        Addresses = new List<string>();
    }

    public abstract string GetFullName();

    public void PrintName(){
     Console.WriteLine($"First Name : {FirstName}, Last Name : {LastName}");
    }

    public int CalculateAge(DateTime birthDate)
    {
        int age = DateTime.Now.Year - birthDate.Year;
        if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
        {
            age = age - 1;
        }
        return age;
    }

    public virtual decimal CalculateSalary(decimal baseSalary)
    {
        if (baseSalary < 0) throw new Exception("Base salary cannot be negative");
        decimal salary = baseSalary + (baseSalary * 0.1M);
        return salary;
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