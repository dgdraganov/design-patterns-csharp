namespace design_patterns_csharp.Command.Components
{
    public class TurnVolumeDownCommand: ICommand
    {
        public TurnVolumeDownCommand(IVolumeControl device)
        {
            this.Device = device;
        }
        public IVolumeControl Device { get; }
        public void Execute()
        {
            System.Console.WriteLine("Turning volume Down!");
            Device.Down();
        }
    }
}