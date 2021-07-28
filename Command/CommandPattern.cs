using design_patterns_csharp.Command.Components;

namespace design_patterns_csharp.Command
{
    public class CommandPattern
    {
        public void Main()
        {
            TVController controller = new TVController();

            TVDevice device = new TVDevice();

            ICommand onCmd = new TurnDeviceOnCommand(device);
            controller.AddCommand("On", onCmd);

            ICommand offCmd = new TurnDeviceOffCommand(device);
            controller.AddCommand("Off", offCmd);

            ICommand upVolCmd = new TurnVolumeUpCommand(device);
            controller.AddCommand("Up", upVolCmd);

            ICommand downVolCmd = new TurnVolumeDownCommand(device);
            controller.AddCommand("Down", downVolCmd);

            // testing
            controller.Invoke("On");
            controller.Invoke("Up");
            controller.Invoke("Down");
            controller.Invoke("Off");
        }
    }
}