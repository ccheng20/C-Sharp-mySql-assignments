public interface IInstructorService : IPersonService{
    string GetFullName();
    void PrintName();
    void addAddress(string address);
    List<string> getAddresses();
    decimal CalculateSalary(decimal baseSalary);

    

}