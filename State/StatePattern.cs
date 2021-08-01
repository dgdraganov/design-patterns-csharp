using design_patterns_csharp.State.Components;

namespace design_patterns_csharp.State
{
    public class StatePattern
    {
        public void Main()
        {
            Player player = new Player();

            player.Stop();  // already stopped
            player.Pause(); // cat't pause when stopped
            player.Play();  // play
            player.Pause(); // pause
            player.Pause(); // already paused
            player.Stop();  // stop 
        }
    }
}