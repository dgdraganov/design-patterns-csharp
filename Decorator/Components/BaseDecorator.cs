namespace design_patterns_csharp.Decorator.Components
{
    public abstract class BaseDecorator : IComponent
    {
        public BaseDecorator(IComponent component)
        {
            Base = component;
        }
        public IComponent Base { get; set; }
        public virtual void Describe()
        {
            Base.Describe();
        }
    }
}