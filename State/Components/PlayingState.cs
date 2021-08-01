namespace design_patterns_csharp.State.Components
{
    internal class PlayingState : State
    {
        public PlayingState(Player player) : base(player)
        {
        }

        public override void Pause()
        {
            player.SetState(player.GetPausedState());
        }

        public override void Play()
        {
            System.Console.WriteLine("Already is playing mode!");
        }

        public override void Stop()
        {
            player.SetState(player.GetStoppedState());
        }

        public override string ToString()
        {
            return "Play";
        }
    }
}