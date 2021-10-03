using design_patterns_csharp.Strategy.Components;

namespace design_patterns_csharp.Strategy
{
    public class StrategyPattern
    {
        public void Main()
        {
            Animal kangaroo = new Animal(
                movingBehaviour: new JumpMovingBehaviour(),
                eatingBehaviour: new GrassEatingBehaviour()
                );
            Animal shark = new Animal(
                movingBehaviour: new SwimMovingBehaviour(),
                eatingBehaviour: new FishEatingBehaviour()
                );
            Animal waterKangaroo = new Animal(
                movingBehaviour: new SwimMovingBehaviour(),
                eatingBehaviour: new GrassEatingBehaviour()
                );
        }
    }
}