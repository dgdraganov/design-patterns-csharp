namespace design_patterns_csharp.Decorator.Components
{
    public class PizzaComponent : IComponent
    {
        public void Describe()
        {
            System.Console.WriteLine("Pizza dough");
        }
    }
}