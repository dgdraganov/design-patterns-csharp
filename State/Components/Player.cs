namespace design_patterns_csharp.State.Components
{
    public class Player
    {
        IState playingState;
        IState stoppedState;
        IState pausedState;

        IState state;

        public Player()
        {
            state = new StoppedState(this);

            stoppedState = new StoppedState(this);
            pausedState = new PausedState(this);
            playingState = new PlayingState(this);
        }

        public IState GetStoppedState()
        {
            return stoppedState;
        }

        public IState GetPlayingState(){
            return playingState;
        }

        public IState GetPausedState(){
            
            return pausedState;
        }

        public void SetState(IState newState){
            System.Console.WriteLine($"[Player]: *{newState.ToString()}*");
            this.state = newState;
        }

        public void Play()
        {
            state.Play();
        }

        public void Pause()
        {
            state.Pause();
        }

        public void Stop()
        {
            state.Stop();
        }
    }
}