using design_patterns_csharp.Strategy.Components;

namespace design_patterns_csharp.Strategy
{
    public class StrategyPattern
    {
        public void Main()
        {
            AnimalClient kangaroo = new AnimalClient(new JumpBehaviour());
            AnimalClient fish = new AnimalClient(new SwimBehaviour());
        }
    }
}