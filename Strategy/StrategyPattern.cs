using design_patterns_csharp.Strategy.Components;

namespace design_patterns_csharp.Strategy
{
    public class StrategyPattern
    {
        public void Main()
        {
            AnimalClient kangaroo = new AnimalClient(
                movingBehaviour: new JumpMovingBehaviour(),
                eatingBehaviour: new FishEatingBehaviour()
                );
            AnimalClient fish = new AnimalClient(
                movingBehaviour: new SwimMovingBehaviour(),
                eatingBehaviour: new FishEatingBehaviour()
                );
            AnimalClient waterKangaroo = new AnimalClient(
                movingBehaviour: new JumpMovingBehaviour(),
                eatingBehaviour: new FishEatingBehaviour()
                );
        }
    }
}