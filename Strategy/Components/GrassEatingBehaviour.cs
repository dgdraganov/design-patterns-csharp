namespace design_patterns_csharp.Strategy.Components
{
    public class GrassEatingBehaviour : IEatingBehaviour
    {
        void IEatingBehaviour.Eat()
        {
            System.Console.WriteLine("Eating grass and stuff ...");
        }
    }
}