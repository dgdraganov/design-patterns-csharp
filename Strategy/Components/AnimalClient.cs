namespace design_patterns_csharp.Strategy.Components
{
    public class AnimalClient 
    {
        private IMovingBehaviour _movingBehaviour;

        public AnimalClient(IMovingBehaviour movingBehaviour)
        {
            _movingBehaviour = movingBehaviour;
        }

        public void Move()
        {
            _movingBehaviour.Move();
        }
    }
}