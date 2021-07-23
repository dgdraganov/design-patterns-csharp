using design_patterns_csharp.Adapter.Components;

namespace design_patterns_csharp.Adapter
{
    public class AdapterPattern
    {
        public void Main()
        {
            StartExecuteAdapter adaptedExecuter = new StartExecuteAdapter(new PrimeExecuter());
            EngineClient engine = new EngineClient(starter: adaptedExecuter); 
        }
    }
}