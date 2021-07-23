namespace design_patterns_csharp.Strategy.Components
{
    public class FishEatingBehaviour : IEatingBehaviour
    {
        public void Eat()
        {
            System.Console.WriteLine("Nothing better than eating smaller fishes ... if you can catch them!");
        }
    }
}