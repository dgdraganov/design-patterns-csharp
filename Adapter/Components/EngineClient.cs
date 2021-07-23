namespace design_patterns_csharp.Adapter.Components
{
    public class EngineClient
    {
        private IStarter _starter;

        public EngineClient(IRunnable starter)
        {
            _starter = starter;
        } 
    }
}