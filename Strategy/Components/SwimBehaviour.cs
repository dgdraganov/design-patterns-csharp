namespace design_patterns_csharp.Strategy.Components
{
    public class SwimBehaviour : IMovingBehaviour
    {
        public void Move()
        {
            System.Console.WriteLine("Swimming around!");
        }
    }
}