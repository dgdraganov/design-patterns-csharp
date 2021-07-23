namespace design_patterns_csharp.Strategy.Components
{
    public class JumpMovingBehaviour : IMovingBehaviour
    {
        public void Move()
        {
            System.Console.WriteLine("Jump! Jump! Jump!");
        }
    }
}