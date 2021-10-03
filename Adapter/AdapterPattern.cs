using design_patterns_csharp.Adapter.Components;

namespace design_patterns_csharp.Adapter
{
    public class AdapterPattern
    {
        public void Main()
        {
            StartExecuteAdapter adaptedExecuter = new StartExecuteAdapter(new PrimeExecuter());
            EngineStartClient engine = new EngineStartClient(starter: adaptedExecuter); 
        }
    }
}