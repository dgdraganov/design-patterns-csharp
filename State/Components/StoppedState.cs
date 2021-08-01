namespace design_patterns_csharp.State.Components
{
    public class StoppedState : State
    {
        public StoppedState(Player player) : base(player)
        {
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Pause()
        {
            System.Console.WriteLine("Can't pause in stopped mode!");
        }

        public override void Play()
        {
            var playingState = player.GetPlayingState();
            player.SetState(playingState);
        }

        public override void Stop()
        {
            System.Console.WriteLine("Already in stopped mode!");
        }

        public override string ToString()
        {
            return "Stop";
        }
    }
}