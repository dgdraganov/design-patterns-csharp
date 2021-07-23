using design_patterns_csharp.Strategy.Components;

namespace design_patterns_csharp.Strategy
{
    public class StrategyPattern
    {
        public void Main()
        {
            AnimalClient kangaroo = new AnimalClient(
                movingBehaviour: new JumpMovingBehaviour(),
                eatingBehaviour: new GrassEatingBehaviour()
                );
            AnimalClient fish = new AnimalClient(
                movingBehaviour: new SwimMovingBehaviour(),
                eatingBehaviour: new SeagrassEatingBehaviour()
                );
        }
    }
}