public interface IPersonService{
    int CalculateAge(DateTime birthDate);
    decimal CalculateSalary(decimal baseSalary);
    List<String> getAddresses();

}