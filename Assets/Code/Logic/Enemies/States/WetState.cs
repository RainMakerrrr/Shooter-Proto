namespace Code.Logic.Enemies.States
{
    public class WetState : IEnemyState
    {
        private const int DamageReduce = 10;
        private readonly IHealth _health;

        public WetState(IHealth health)
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
            _health.TakeDamage(damage - DamageReduce);
        }
    }
}