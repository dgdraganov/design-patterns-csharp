using design_patterns_csharp.Builder.Components;

namespace design_patterns_csharp.Builder
{
    public class BuilderPattern
    {

        public void Main()
        {
            IEmployeeBuilder employeeBuilder = new EmployeeBuilder();
            Employee employee = employeeBuilder.WithFirstName("Jon")
                                                .WithLastName("Snow")
                                                .HasId(007)
                                                .OnPosition("Software Engineer")
                                                .InDepartment("Software Development")
                                                .ReportsTo("Daenerys Targaryen")
                                                .HasSalary(120)
                                                .Employee;

            System.Console.WriteLine(employee.ToString());
        }

    }
}