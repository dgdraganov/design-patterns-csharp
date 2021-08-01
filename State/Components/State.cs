namespace design_patterns_csharp.State.Components
{
    public abstract class State : IState
    {
        protected Player player { get; }
        public State(Player player)
        {
            this.player = player;
        }

        public abstract void Pause();

        public abstract void Play();

        public abstract void Stop();
    }
}