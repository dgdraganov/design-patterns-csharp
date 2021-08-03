namespace design_patterns_csharp.Builder.Components
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public string Manager { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $@"Name:       {FirstName} {LastName} [ID: {Id}]
Department: {Department}
Position:   {Position}
Manager:    {Manager}
Salary:     {Salary} gold/mo";
        }
    }
}