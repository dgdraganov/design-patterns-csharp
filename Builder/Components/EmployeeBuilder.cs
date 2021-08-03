namespace design_patterns_csharp.Builder.Components
{
    public class EmployeeBuilder : IEmployeeBuilder
    {
        private Employee employee;

        public Employee Employee
        {
            get
            {
                return employee;
            }
        }
        public EmployeeBuilder()
        {
            employee = new Employee();
        }
        public IEmployeeBuilder HasId(int id)
        {
            employee.Id = id;
            return this;
        }

        public IEmployeeBuilder HasSalary(decimal salary)
        {
            employee.Salary = salary;
            return this;
        }

        public IEmployeeBuilder InDepartment(string department)
        {
            employee.Department = department;
            return this;
        }

        public IEmployeeBuilder OnPosition(string position)
        {
            employee.Position = position;
            return this;
        }

        public IEmployeeBuilder ReportsTo(string managerFullName)
        {
            employee.Manager = managerFullName;
            return this;
        }

        public IEmployeeBuilder WithFirstName(string firstName)
        {
            employee.FirstName = firstName;
            return this;
        }

        public IEmployeeBuilder WithLastName(string lastName)
        {
            employee.LastName = lastName;
            return this;
        }
    }
}