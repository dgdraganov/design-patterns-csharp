namespace design_patterns_csharp.Strategy.Components
{
    public class SeagrassEatingBehaviour : IEatingBehaviour
    {
        public void Eat()
        {
            System.Console.WriteLine("Nothing better than fresh, green seagrass ... ");
        }
    }
}