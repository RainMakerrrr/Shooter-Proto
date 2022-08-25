using Code.Logic.Debuffs;

namespace Code.Logic.Enemies.States
{
    public class BurningState : IEnemyState
    {
        private const int DamageAmplify = 10;
        
        private readonly IHealth _health;
        private readonly BurningDebuff _debuff;
        
        public BurningState(IHealth health, BurningDebuff debuff)
        {
            _health = health;
            _debuff = debuff;
        }

        public void Enter()
        {
            _debuff.ApplyDebuff();
        }

        public void Exit()
        {
            _debuff.Reset();
        }

        public void TakeDamage(float damage)
        {
            _health.TakeDamage(damage + DamageAmplify);
        }
    }
}