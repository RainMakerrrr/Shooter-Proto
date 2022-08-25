namespace Code.Logic.Enemies.States
{
    public class NormalState : IEnemyState
    {
        private readonly IHealth _health;

        public NormalState(IHealth health)
        {
            _health = health;
        }

        public void Enter()
        {
            
        }

        public void Exit()
        {
        }

        public void TakeDamage(float damage)
        {
            _health.TakeDamage(damage);
        }
    }
}