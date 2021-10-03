namespace design_patterns_csharp.Adapter.Components
{
    public class EngineStartClient
    {
        private IStarter _starter;

        public EngineStartClient(IStarter starter)
        {
            _starter = starter;
        } 

        public void Start(){
            _starter.Start();
        }
    }
}