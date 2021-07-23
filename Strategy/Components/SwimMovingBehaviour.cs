namespace design_patterns_csharp.Strategy.Components
{
    public class SwimMovingBehaviour : IMovingBehaviour
    {
        public void Move()
        {
            System.Console.WriteLine("Swimming around!");
        }
    }
}