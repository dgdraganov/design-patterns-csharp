namespace design_patterns_csharp.Adapter.Components
{
    public class StartExecuteAdapter : IStarter
    {
        private IExecutable _executer;
        public StartExecuteAdapter(IExecutable executer)
        {
            _executer = executer;
        }
        public void Start()
        {
            _executer.Execute();
        }
    }
}