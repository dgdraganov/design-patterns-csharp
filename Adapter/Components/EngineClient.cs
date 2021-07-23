namespace design_patterns_csharp.Adapter.Components
{
    public class EngineClient
    {
        private IStarter _starter;

        public EngineClient(IStarter starter)
        {
            _starter = starter;
        } 
    }
}