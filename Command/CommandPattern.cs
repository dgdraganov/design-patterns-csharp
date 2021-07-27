using design_patterns_csharp.Command.Components;

namespace design_patterns_csharp.Command
{
    public class CommandPattern
    {
        public void Main()
        {
            // Finish: Make An Invoker !!

            TVDevice device = new TVDevice();

            ICommand onCmd = new TurnDeviceOnCommand(device);
            onCmd.Execute();

            ICommand offCmd = new TurnDeviceOffCommand(device);
            offCmd.Execute();

            ICommand upCmd = new TurnVolumeUpCommand(device);
            upCmd.Execute();

            ICommand downCmd = new TurnVolumeDownCommand(device);
            downCmd.Execute();
        }
    }
}