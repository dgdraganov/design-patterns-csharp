namespace design_patterns_csharp.Command.Components
{
    public class TurnVolumeUpCommand : ICommand
    {

        public TurnVolumeUpCommand(IVolumeControl device)
        {
            this.Device = device;
        }
        public IVolumeControl Device { get; }
        public void Execute()
        {
            System.Console.WriteLine("Turning volume Up!");
            Device.Up();
        }
    }
}