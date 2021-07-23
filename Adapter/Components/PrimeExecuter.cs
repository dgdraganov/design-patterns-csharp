namespace design_patterns_csharp.Adapter.Components
{
    public class PrimeExecuter : IExecutable
    {
        public void Execute()
        {
            System.Console.WriteLine("* Executing some fancy logic *");
        }
    }
}