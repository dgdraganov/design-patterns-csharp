namespace design_patterns_csharp.Builder.Components
{
    public interface IEmployeeBuilder
    {
         Employee Employee { get; }
         IEmployeeBuilder HasId(int id);
         IEmployeeBuilder WithFirstName(string firstName);
         IEmployeeBuilder WithLastName(string lastName);
         IEmployeeBuilder HasSalary(decimal salary);
         IEmployeeBuilder ReportsTo(string managerFullName);
         IEmployeeBuilder InDepartment(string department);
         IEmployeeBuilder OnPosition(string position);
    }
}