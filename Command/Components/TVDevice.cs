namespace design_patterns_csharp.Command.Components
{
    public class TVDevice : ITurnOnOff, IVolumeControl
    {
        public int MaxVolume { get; } = 100;
        public int Volume { get; set; } = 10;

        public void Down()
        {
            Volume--;
            System.Console.WriteLine($"Down - {Volume}/{MaxVolume}.");
        }

        public void Off()
        {
            System.Console.WriteLine("TV is Off");
            
        }

        public void On()
        {
            System.Console.WriteLine("TV is On");
        }

        public void Up()
        {
            Volume++;
            System.Console.WriteLine($"Up - {Volume}/{MaxVolume}.");
        }
    }
}