namespace design_patterns_csharp.State.Components
{
    public interface IState
    {
         void Play();
         void Pause();
         void Stop();
    }
}