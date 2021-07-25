namespace design_patterns_csharp.Decorator.Components
{
    public class MushroomsDecorator : BaseDecorator
    {
        public MushroomsDecorator(IComponent component) : base(component)
        {
        }

        public override void Describe()
        {
            base.Describe();
            System.Console.WriteLine("\t-mushrooms");
        }
    }
}