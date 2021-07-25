using design_patterns_csharp.Decorator.Components;

namespace design_patterns_csharp.Decorator
{
    public class DecoratorPattern
    {
        public void Main()
        {
            IComponent pizza = new PizzaComponent();

            pizza = new TomatoSauceDecorator(pizza);
            pizza = new SalamiDecorator(pizza);
            pizza = new MushroomsDecorator(pizza);

            pizza.Describe();
        }
    }
}