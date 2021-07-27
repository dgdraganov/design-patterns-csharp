namespace design_patterns_csharp.Command.Components
{
    public class TurnDeviceOffCommand : ICommand
    {
        public TurnDeviceOffCommand(ITurnOnOff device)
        {
            this.Device = device;
        }
        public ITurnOnOff Device { get; }
        public void Execute()
        {
            System.Console.WriteLine("Execute Off command!");
            Device.Off();
        }
    }
}