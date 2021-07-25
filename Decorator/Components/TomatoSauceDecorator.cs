namespace design_patterns_csharp.Decorator.Components
{
    public class TomatoSauceDecorator : BaseDecorator
    {
        public TomatoSauceDecorator(IComponent component) : base(component)
        {
        }

        public override void Describe()
        {
            base.Describe();
            System.Console.WriteLine("\t-tomato sauce");
        }
    }
}