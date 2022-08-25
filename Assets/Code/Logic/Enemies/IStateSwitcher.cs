using Code.Logic.Enemies.States;

namespace Code.Logic.Enemies
{
    public interface IStateSwitcher
    {
        void SwitchState<T>() where T : IEnemyState;
    }
}