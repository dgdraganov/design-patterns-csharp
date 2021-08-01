namespace design_patterns_csharp.State.Components
{
    public class PausedState : State
    {
        public PausedState(Player player) : base(player)
        {
        }

        public override void Pause()
        {
            System.Console.WriteLine("Already in paused mode!");
        }

        public override void Play()
        {
            player.SetState(player.GetPlayingState());
        }

        public override void Stop()
        {
            player.SetState(player.GetStoppedState());
        }
        
        public override string ToString()
        {
            return "Pause";
        }
    }
}