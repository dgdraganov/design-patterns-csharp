namespace design_patterns_csharp.Command.Components
{
    public class TurnDeviceOnCommand : ICommand
    {
        public TurnDeviceOnCommand(ITurnOnOff device)
        {
            Device = device;
        }
        public ITurnOnOff Device { get; }
        public void Execute()
        {
            System.Console.WriteLine("Execute On command!");
            Device.On();
        }
    }
}