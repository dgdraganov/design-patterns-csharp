namespace design_patterns_csharp.Decorator.Components
{
    public class SalamiDecorator : BaseDecorator
    {
        public SalamiDecorator(IComponent component) : base(component)
        {
        }

        public override void Describe()
        {
            base.Describe();
            System.Console.WriteLine("\t-salami");
        }
    }
}