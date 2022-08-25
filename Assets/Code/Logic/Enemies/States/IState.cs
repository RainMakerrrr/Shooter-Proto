namespace Code.Logic.Enemies.States
{
    public interface IEnemyState
    {
        void Enter();
        void Exit();
        void TakeDamage(float damage);
    }
}